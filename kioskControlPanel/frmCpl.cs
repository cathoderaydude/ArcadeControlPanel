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
        // Array of button status display controls
        private Button[] buttonLights;

        public frmCpl()
        {
            InitializeComponent();

            // Initialize device object
            ftdi = new FTDI();
            ft_status = FTDI.FT_STATUS.FT_OK;
            // Open the first FT232 (or similar) attached to the system
            // This could be replaced by OpenBySerialNumber for a multi-interface system so that inputs remain constant
            ft_status = ftdi.OpenByIndex(0);
            // Set all pins (255 is a bitmask) to asynchronous GPIO mode
            ft_status = ftdi.SetBitMode(255, 1);
            // I'm not sure how this works, but I couldn't get the buffer to consistently return useful results
            // until I dropped this to 300. It was initially at 9600 and would return whole buffers of 00s
            ft_status = ftdi.SetBaudRate(300);

            // Initialize button bit values
            btnBits = new byte[] { 16, 32, 64, 128 };
            // Initialize button state
            buttonsDown = new bool[] {false, false, false, false};
            // Initialize button status control array
            buttonLights = new Button[] { btnStatus1, btnStatus2, btnStatus3, btnStatus4 };
        }

        // Delete me
        private void button1_Click(object sender, EventArgs e)
        {
            
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
                throw new Exception("Failed to get number of bytes available to read (error " + ft_status.ToString() + ")");
                //return;
            }

            // Read out the buffer
            // readData now contains a series of bytes representing the pin state
            ftdi.Read(readData, bytesRead, ref bytesRead);

            // Uncomment this block to see the raw bytes in the debug console
            /*Console.Write("Data: ");
            String aa = "";
            for (x=0;x<256;x++)
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
                }
                else if (readData[0] != btnBits[i])
                {
                    // Clear flag in button status table
                    buttonsDown[i] = false;
                    // Clear diagnostic light
                    buttonLights[i].BackColor = Color.Maroon;
                }
            }

            // TODO: Loop to take action based on the value of each button - or should this be in the master loop?
        }
    }
}
