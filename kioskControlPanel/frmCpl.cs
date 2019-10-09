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
using System.Media;
using WMPLib;
using Ini;

namespace kioskControlPanel
{
    public partial class frmCpl : Form
    {
        /*
         * TODO:
         * 
         * - Add systray icon, hide when minimized, default to hidden
         * - Add method to fire off test events from button status indicators
         * - Add sound effect when button test event fires (add "bool soundEffect" flag in buttonInfo)
         * - Add sound effect when button needs to be held for a while to trigger, and then effect when it does trigger?
         * - Add support for multiple sounds and a way to select them
         * - Add feature to save settings
         */

        // Device driver object and response code storage
        public FTDI ftdi;
        public FTDI.FT_STATUS ft_status;

        // Bit values for each button
        public byte[] btnBits;
        
        // Struct to store button state and milliseconds until it should take effect
        private class buttonInfo
        {
            public bool state;
            public int delay;
            public int remaining;
            public bool soundEffect;

            // These allow you to do "if buttonState[i] == true" instead of needing to include .state
            public static bool operator ==(buttonInfo x, bool y)
            {
                return (x.state == y);
            }
            public static bool operator !=(buttonInfo x, bool y)
            {
                return (x.state != y);
            }

            public buttonInfo()
            {
                this.state = false;
                this.delay = 0;
                this.remaining = 0;
                this.soundEffect = true;
            }
        }
        
        private Dictionary<int, buttonInfo> buttonState;
        
        // Array of button status display controls
        private Button[] buttonLights;

        // Arrays of action fields
        private TextBox[] actionStrings;
        private TextBox[] delayValues;

        private WMPLib.WindowsMediaPlayer CoinInSound;
        private WMPLib.WindowsMediaPlayer ExitSound;

        // ================================================================================

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
            btnBits = new byte[] { 1, 2, 4, 8, 16, 32, 64, 128 };
            // Initialize button state array
            buttonState = new Dictionary<int, buttonInfo>();
            buttonState.Add(0, new buttonInfo());
            buttonState.Add(1, new buttonInfo());
            buttonState.Add(2, new buttonInfo());
            buttonState.Add(3, new buttonInfo());
            buttonState.Add(4, new buttonInfo());
            buttonState.Add(5, new buttonInfo());
            buttonState.Add(6, new buttonInfo());
            buttonState.Add(7, new buttonInfo());

            // Initialize button status control array
            buttonLights = new Button[] { btnStatus1, btnStatus2, btnStatus3, btnStatus4, btnStatus5, btnStatus6, btnStatus7, btnStatus8 };
            // Initialize action and delay values
            actionStrings = new TextBox[] { txtButton1, txtButton2, txtButton3, txtButton4, txtButton5, txtButton6, txtButton7, txtButton8 };
            delayValues = new TextBox[] { txtDelay1, txtDelay2, txtDelay3, txtDelay4, txtDelay5, txtDelay6, txtDelay7, txtDelay8 };

            // Load INI file into form, or defaults if no INI
            LoadSettings();

            // Initialize delay values from form fields
            validateDelay(0);
            validateDelay(1);
            validateDelay(2);
            validateDelay(3);
            validateDelay(4);
            validateDelay(5);
            validateDelay(6);
            validateDelay(7);

            // Initialize media player
            dbgW("Initializing sound");
            try
            {
                // Create player and load sound
                CoinInSound = new WindowsMediaPlayer();
                CoinInSound.settings.autoStart = false;

                // We load the sound now so it'll be in memory. If we switched between effects on the fly you could hit I/O pauses
                CoinInSound.URL = "coin in.mp3";

                dbgW("Sound initialized");
                // TODO: Add other sound effect initializers.
            } catch (Exception err)
            {
                dbgW("Unable to initialize sound: " + err.ToString());
                dbgW("There will be no sound effects.");
            }

            dbgW("Initialization complete, ready to go.");

            // This and the below are fairly cursed, and required to allow the app to exist solely in the systray
            // without an extremely unpleasant refactor.
            FirstRun = true;
        }

        private bool FirstRun = false;
        // By overriding the SetVisibleCore class method, we prevent Application.Run from showing the form
        // Then, once the app is loaded, we unset it, and the next time something tries to show the form
        // it will succeed. This is not actually a hack, just weird.
        protected override void SetVisibleCore(bool value)
        {
            if (FirstRun)
            {
                base.SetVisibleCore(false);
                FirstRun = false;
            }
            else
            {
                base.SetVisibleCore(value);
            }
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
                if (((((int)readData[0]) & btnBits[i]) != 0) && buttonState[i] == false)
                {
                    // Button was not pressed and now is
                    // Set flag in button status table
                    buttonState[i].state = true;
                    // Log event
                    dbgW("Button " + i.ToString() + " pressed");

                    int delayValue = buttonState[i].delay;
                    // Check whether the button's action has a delay
                    if (delayValue > 0)
                    {
                        // Yes; turn diagnostic light orange and set the delay value for the button
                        buttonLights[i].BackColor = Color.Orange;
                        buttonState[i].remaining = delayValue;
                        dbgW("Delay of " + (delayValue * 10).ToString() + " milliseconds");
                    }
                    else
                    {
                        // No; Turn diagnostic light green and take action immediately
                        buttonLights[i].BackColor = Color.LimeGreen;
                        buttonEvent(i);
                    }
                }
                else if (((((int)readData[0]) & btnBits[i]) == 0) && buttonState[i] == true)
                {
                    // Button was pressed and has been released
                    // Clear flag in button status table
                    buttonState[i].state = false;
                    // Clear diagnostic light
                    buttonLights[i].BackColor = Color.Maroon;
                    // Log event
                    dbgW("Button " + i.ToString() + " released");
                }
                // No action is taken if the button state hasn't changed, so there's no else
            }
        }

        private void eventTimer_Tick(object sender, EventArgs e)
        {
            // We have two timers because the one polling the FT232 operates at 16ms, the interval of the FT232's read timeout,
            // whereas this one runs at 10ms so we can cleanly count down delay values.
            // Is this distinction worth it? Unknown, but the FT232 is a device I don't understand and this seems to tune
            // it to usability.

            // Check the state of each button
            for (int i = 0; i < btnBits.Length; i++)
            {
                if(buttonState[i] == true)
                {
                    // Button is currently pressed
                    // Check if countdown has expired
                    if (buttonState[i].remaining > 0)
                    {
                        buttonState[i].remaining -= 1; // Button isn't ready to fire; decrement value

                        // We check again here; if we are now under 0, fire the action
                        // This code will never be reached once the number sinks below 0 for the first time
                        if (buttonState[i].remaining <= 0)
                        {
                            buttonLights[i].BackColor = Color.LimeGreen;
                            dbgW("Delay elapsed on button " + i.ToString());
                            buttonEvent(i);
                        }
                    }
                }
            }
        }
        
        // Common function for triggering button events so delay & instant buttons use the same code
        private void buttonEvent(int index)
        {
            // Don't actually send keys if "Enable binds" is unchecked
            if (chkBinds.Checked == true)
            {
                dbgW("Sending keys: " + actionStrings[index].Text);
                if (buttonState[index].soundEffect == true) PlaySound("coinin");
                SendKeys.Send(actionStrings[index].Text);
            } else
            {
                dbgW("Binds disabled; not sending keys");
            }
        }

        // Event when a delay field is changed
        private void event_validateDelay(object sender, EventArgs e)
        {
            // Find field ID and call method to update delay
            TextBox tb = (TextBox)sender;

            int i = int.Parse((string) tb.Tag);
            validateDelay(i);
        }

        // Event for updating button delays
        private void validateDelay(int i)
        {
            // Update delay on start or when text field is changed
            // Check if there's a valid number in the delay field
            try
            {
                // Yep - clear field error color and set delay value
                buttonState[i].delay = int.Parse(delayValues[i].Text);
                this.BackColor = DefaultBackColor;
            }
            catch (Exception err)
            {
                // Nope - flag field and set delay value to 0 so we can continue processing
                dbgW("The value for delay on button " + i.ToString() + " is not a valid number.");
                buttonState[i].delay = 0;
                delayValues[i].BackColor = Color.Pink;
            }
        }

        // Stub to play generic sound; will be expanded in later versions
        private void PlaySound(string index)
        {
            CoinInSound.controls.stop();
            CoinInSound.controls.play();
        }

        // Load settings from INI
        // The ini read method automatically replaces any missing values with stock defaults
        // This will occur if the INI is completely missing or if just the key is missing
        private void LoadSettings()
        {
            try
            {
                IniFile ini = new IniFile(Application.StartupPath + "\\kcp.ini");
                txtButton1.Text = ini.IniReadValue("button1", "bind", "");
                txtButton2.Text = ini.IniReadValue("button2", "bind", "");
                txtButton3.Text = ini.IniReadValue("button3", "bind", "");
                txtButton4.Text = ini.IniReadValue("button4", "bind", "");
                txtButton5.Text = ini.IniReadValue("button5", "bind", "");
                txtButton6.Text = ini.IniReadValue("button6", "bind", "");
                txtButton7.Text = ini.IniReadValue("button7", "bind", "");
                txtButton8.Text = ini.IniReadValue("button8", "bind", "");

                txtDelay1.Text = ini.IniReadValue("button1", "delay", "0");
                txtDelay2.Text = ini.IniReadValue("button2", "delay", "0");
                txtDelay3.Text = ini.IniReadValue("button3", "delay", "0");
                txtDelay4.Text = ini.IniReadValue("button4", "delay", "0");
                txtDelay5.Text = ini.IniReadValue("button5", "delay", "0");
                txtDelay6.Text = ini.IniReadValue("button6", "delay", "0");
                txtDelay7.Text = ini.IniReadValue("button7", "delay", "0");
                txtDelay8.Text = ini.IniReadValue("button8", "delay", "0");
            } catch (Win32Exception err)
            {
                dbgW("Unable to read INI: " + err.ToString());
            }
        }

        

        // Save settings to INI
        private void SaveSettings()
        {
            IniFile ini = new IniFile(Application.StartupPath + "\\kcp.ini");
            ini.IniWriteValue("button1", "bind", txtButton1.Text);
            ini.IniWriteValue("button2", "bind", txtButton2.Text);
            ini.IniWriteValue("button3", "bind", txtButton3.Text);
            ini.IniWriteValue("button4", "bind", txtButton4.Text);
            ini.IniWriteValue("button5", "bind", txtButton5.Text);
            ini.IniWriteValue("button6", "bind", txtButton6.Text);
            ini.IniWriteValue("button7", "bind", txtButton7.Text);
            ini.IniWriteValue("button8", "bind", txtButton8.Text);

            ini.IniWriteValue("button1", "delay", txtDelay1.Text);
            ini.IniWriteValue("button2", "delay", txtDelay2.Text);
            ini.IniWriteValue("button3", "delay", txtDelay3.Text);
            ini.IniWriteValue("button4", "delay", txtDelay4.Text);
            ini.IniWriteValue("button5", "delay", txtDelay5.Text);
            ini.IniWriteValue("button6", "delay", txtDelay6.Text);
            ini.IniWriteValue("button7", "delay", txtDelay7.Text);
            ini.IniWriteValue("button8", "delay", txtDelay8.Text);
        }

        // If user minimizes window, go to tray
        private void frmCpl_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        // Left click on trayicon to raise window
        private void ntiIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal; // In case it was minimized
                this.BringToFront(); // In case it's behind something
            }
        }

        // "Exit" button in trayicon menu
        private void ctiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // "Show" button in trayicon menu
        private void ctiShow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal; // In case it was minimized
            this.BringToFront(); // In case it's behind something
        }

        // Prompt user to exit
        private void frmCpl_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If Windows is shutting down, don't interrupt it
            if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.TaskManagerClosing) return;
            // Otherwise offer a confirmation
            if (MessageBox.Show(this, "Are you sure you want to exit? If you just meant to hide the window, minimize it instead.\r\n\r\nExit anyway?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // If the program is closing, save the settings
        private void frmCpl_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }
    }
}
