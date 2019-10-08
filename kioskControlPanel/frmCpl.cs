using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTD2XX_NET;
using System.IO;

namespace kioskControlPanel
{
    public partial class frmCpl : Form
    {
        // Device driver object and response code storage
        public FTDI ftdi;
        public FTDI.FT_STATUS ft_status;

        // Bit values for each button
        public byte[] btnBits;
        // Currently-pressed buttons
        public bool[] buttonsDown;
        
        // Building new way to store button info to be applied after this commit
        private struct buttonInfo
        {
            public bool state;
            public int delay;
        }
        
        private KeyValuePair<byte, buttonInfo> buttonState;
        
        // Array of button status display controls
        private Button[] buttonLights;

        public frmCpl()
        {
            InitializeComponent();

            dbgW("Init FT232");
            // Initialize device object
            ftdi = new FTDI();
            ft_status = FTDI.FT_STATUS.FT_OK;
            // Open the first FT232 (or similar) attached to the system
            // This could be replaced by OpenBySerialNumber for a multi-interface system so that inputs remain constant
            ft_status = ftdi.OpenByIndex(0);
            if (ft_status == FTDI.FT_STATUS.FT_OK)
            {
                dbgW("FT232 inited");
            } else
            {
                MessageBox.Show(this, "No FT232 could be detected. Execution cannot continue.", "Error: Device not present", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Set all pins (255 is a bitmask) to asynchronous GPIO mode
            ft_status = ftdi.SetBitMode(255, 1);
            dbgW("Set async pin mode: " + ft_status.ToString());
            // I'm not sure how this works, but I couldn't get the buffer to consistently return useful results
            // until I dropped this to 300. It was initially at 9600 and would return whole buffers of 00s
            ft_status = ftdi.SetBaudRate(300);
            dbgW("Set baud rate: " + ft_status.ToString());
            dbgW("FT232 initialized.");

            // Initialize button bit values
            btnBits = new byte[] { 16, 32, 64, 128 };
            // Initialize button state
            buttonsDown = new bool[] {false, false, false, false};
            // Initialize button status control array
            buttonLights = new Button[] { btnStatus1, btnStatus2, btnStatus3, btnStatus4 };

            dbgW("Initialization complete, ready to go.");
        }

        // Write a line to the debug textbox and file
        private void dbgW(string str)
        {
            string timestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss:fff");
            string debugline = string.Format("[{0}] {1} \r\n", timestamp, str);
            txtDebug.AppendText(debugline);
            Program.fDebug.Write(debugline);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Buffer for pin status
            // Different array sizes have different effects; I don't understand why, but the device
            // will always return as many bytes as the size of your array. 256 seems to be a sweet spot.
            byte[] readData = new byte[256];
            // Number of bytes device actually read out when queried; always the same as the array size
            uint bytesRead = 0;

            // Check whether there are bytes available
            // In GPIO mode, this should always return an infinite number, and indeed it seems to. The reason
            // this is here, more than anything, is to allow an exception if the device isn't happy.
            ft_status = ftdi.GetRxBytesAvailable(ref bytesRead);
            if (ft_status != FTDI.FT_STATUS.FT_OK)
            {
                // If anything went wrong, stop the loop but don't exit so the user can read the logs.
                string errorMessage = "Failed to get number of bytes available to read (error " + ft_status.ToString() + ")";
                dbgW(errorMessage);
                dbgW("Processing halted. Restart program to continue.");
                MessageBox.Show(this, "An error (" + ft_status.ToString() + ") was returned when trying to read the FT232.\r\nProcessing halted. Restart the program to continue.", "Error: Device not present", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Enabled = false;
                return;
            }

            // Read out the buffer
            // readData now contains a series of bytes representing the pin state
            ftdi.Read(readData, bytesRead, ref bytesRead);

            // Uncomment this block to see the raw bytes in the debug console
            // It's probably -not- a good idea to modify this to use the dbgW function, since
            // that would hit disk IO every 16ms.
            /*Console.Write("Data: ");
            String aa = "";
            for (int x=0;x<256;x++)
            {
                aa += readData[x].ToString();
            }
            Console.WriteLine(aa);*/

            

            // Check status of each pin

            for(int i=0;i<btnBits.Length;i++)
            {
                // Check for bit for this button, and make sure the button isn't already pressed
                if (((((int)readData[0]) & btnBits[i]) != 0) && buttonsDown[i] == false)
                {
                    // Button was pressed
                    // Set flag in button status table
                    buttonsDown[i] = true;
                    // Turn diagnostic light green
                    buttonLights[i].BackColor = Color.LimeGreen;
                    // Log event
                    dbgW("Button "+i.ToString()+" pressed");
                }
                else if (((((int)readData[0]) & btnBits[i]) == 0) && buttonsDown[i] == true)
                {
                    // Clear flag in button status table
                    buttonsDown[i] = false;
                    // Clear diagnostic light
                    buttonLights[i].BackColor = Color.Maroon;
                    // Log event
                    dbgW("Button " + i.ToString() + " released");
                }
            }

            // TODO: Loop to take action based on the value of each button - or should this be in the master loop?
        }
    }
}
