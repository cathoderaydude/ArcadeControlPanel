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
using System.Text.RegularExpressions;

namespace kioskControlPanel
{
    public partial class frmCpl : Form
    {
        // Device driver object and response code storage
        public FTDI ftdi;
        public FTDI.FT_STATUS ft_status;

        // Bit values for each button
        public byte[] btnBits;
        
        // Struct to store button state and milliseconds until it should take effect
        private class ButtonInfo
        {
            public bool state;
            public int delay;
            public int remaining;
            public bool SoundEffect;

            // These allow you to do "if buttonState[i] == true" instead of needing to include .state
            public static bool operator ==(ButtonInfo x, bool y)
            {
                return (x.state == y);
            }
            public static bool operator !=(ButtonInfo x, bool y)
            {
                return (x.state != y);
            }

            public ButtonInfo()
            {
                this.state = false;
                this.delay = 0;
                this.remaining = 0;
                this.SoundEffect = true;
            }
        }
        
        // Array tracking the state of each button
        private Dictionary<int, ButtonInfo> ButtonState;
        
        // Array of button status display controls
        private Button[] buttonLights;

        // Arrays of action fields
        private TextBox[] ActionStrings;
        private TextBox[] delayValues;

        private WMPLib.WindowsMediaPlayer CoinInSound;
        private WMPLib.WindowsMediaPlayer ExitSound;

        // ================================================================================
        // Member definitions complete



        /*
         *   INITIALIZATION ROUTINES
         */

        public frmCpl()
        {
            InitializeComponent();

            DbgW("Init FT232");
            // Initialize device object
            ftdi = new FTDI();
            ft_status = FTDI.FT_STATUS.FT_OK;
            // Open the first FT232 (or similar) attached to the system
            // This could be replaced by OpenBySerialNumber for a multi-interface system so that inputs remain constant
            ft_status = ftdi.OpenByIndex(0);
            if (ft_status == FTDI.FT_STATUS.FT_OK)
            {
                // Print serial number; obvs. later we will need to add methods to select from multiple connected devices
                ftdi.GetSerialNumber(out string SerialNumber);
                DbgW("FT232 inited, SN " + SerialNumber);
            } else
            {
                MessageBox.Show(this, "No FT232 could be detected. Execution cannot continue.", "Error: Device not present", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            // Set all pins (255 is a bitmask) to asynchronous GPIO mode
            ft_status = ftdi.SetBitMode(255, 1);
            DbgW("Set async pin mode: " + ft_status.ToString());
            // I'm not sure how this works, but I couldn't get the buffer to consistently return useful results
            // until I dropped this to 300. It was initially at 9600 and would return whole buffers of 00s
            ft_status = ftdi.SetBaudRate(300);
            DbgW("Set baud rate: " + ft_status.ToString());
            DbgW("FT232 initialized.");

            // Initialize button bit values
            btnBits = new byte[] { 1, 2, 4, 8, 16, 32, 64, 128 };
            // Initialize button state array
            ButtonState = new Dictionary<int, ButtonInfo>
            {
                { 0, new ButtonInfo() },
                { 1, new ButtonInfo() },
                { 2, new ButtonInfo() },
                { 3, new ButtonInfo() },
                { 4, new ButtonInfo() },
                { 5, new ButtonInfo() },
                { 6, new ButtonInfo() },
                { 7, new ButtonInfo() }
            };

            // Initialize button status control array
            buttonLights = new Button[] { btnStatus1, btnStatus2, btnStatus3, btnStatus4, btnStatus5, btnStatus6, btnStatus7, btnStatus8 };
            // Initialize action and delay values
            ActionStrings = new TextBox[] { txtButton1, txtButton2, txtButton3, txtButton4, txtButton5, txtButton6, txtButton7, txtButton8 };
            delayValues = new TextBox[] { txtDelay1, txtDelay2, txtDelay3, txtDelay4, txtDelay5, txtDelay6, txtDelay7, txtDelay8 };

            // Load INI file into form, or defaults if no INI
            LoadSettings();

            // Initialize delay values from form fields
            ValidateDelay(0);
            ValidateDelay(1);
            ValidateDelay(2);
            ValidateDelay(3);
            ValidateDelay(4);
            ValidateDelay(5);
            ValidateDelay(6);
            ValidateDelay(7);

            // Initialize media player
            DbgW("Initializing sound");
            try
            {
                // Create player and load sound
                CoinInSound = new WindowsMediaPlayer();
                CoinInSound.settings.autoStart = false;

                // We load the sound now so it'll be in memory. If we switched between effects on the fly you could hit I/O pauses
                if (File.Exists("coin in.mp3"))
                {
                    CoinInSound.URL = "coin in.mp3";
                } else
                {
                    DbgW("File 'coin in.mp3' does not exist; sound will not function.");
                }
                
                DbgW("Sound initialized");
                // TODO: Add other sound effect initializers.
            } catch (Exception err)
            {
                DbgW("Unable to initialize sound: " + err.ToString());
                DbgW("There will be no sound effects.");
                // TODO: Add code to actually handle this situation elsewhere; right now a crash will occur when a sound tries to play
            }

            DbgW("Initialization complete, ready to go.");

            // Used for testing the macro validator, will remove later
            //Console.WriteLine(ValidateMacro("LALT F4 LCTRL F5"));
            //Console.WriteLine(ValidateMacro("F4 D F C N1 LCTRL N LCTRL"));

            // We need to do this to bump the static constructor in the raw input library; tune this up later
            Console.WriteLine(SendRawInput.YeahWereHere);

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
#if DEBUG
            // It's irritating having to hit the systray icon every time during debugging
            FirstRun = false; 
#endif
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
        private void DbgW(string str)
        {
            string timestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss:fff");
            string debugline = string.Format("[{0}] {1} \r\n", timestamp, str);
            txtDebug.AppendText(debugline);
            Program.fDebug.Write(debugline);
#if DEBUG
            Console.WriteLine(debugline);
#endif
        }

        /*
         *  MAIN PROGRAM FUNCTIONALITY
         */

        private void TmrPoll_Tick(object sender, EventArgs e)
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
                DbgW(errorMessage);
                DbgW("Processing halted. Restart program to continue.");
                MessageBox.Show(this, "An error (" + ft_status.ToString() + ") was returned when trying to read the FT232.\r\nProcessing halted. Restart the program to continue.", "Error: Device not present", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tmrPoll.Enabled = false;
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
                if (((((int)readData[0]) & btnBits[i]) != 0) && ButtonState[i] == false)
                {
                    // Button was not pressed and now is
                    // Set flag in button status table
                    ButtonState[i].state = true;
                    // Log event
                    DbgW("Button " + i.ToString() + " pressed");

                    int delayValue = ButtonState[i].delay;
                    // Check whether the button's action has a delay
                    if (delayValue > 0)
                    {
                        // Yes; turn diagnostic light orange and set the delay value for the button
                        buttonLights[i].BackColor = Color.Orange;
                        ButtonState[i].remaining = delayValue;
                        DbgW("Delay of " + (delayValue * 10).ToString() + " milliseconds");
                    }
                    else
                    {
                        // No; Turn diagnostic light green and take action immediately
                        buttonLights[i].BackColor = Color.LimeGreen;
                        ButtonEvent(i);
                    }
                }
                else if (((((int)readData[0]) & btnBits[i]) == 0) && ButtonState[i] == true)
                {
                    // Button was pressed and has been released
                    // Clear flag in button status table
                    ButtonState[i].state = false;
                    // Clear diagnostic light
                    buttonLights[i].BackColor = Color.Maroon;
                    // Log event
                    DbgW("Button " + i.ToString() + " released");
                }
                // No action is taken if the button state hasn't changed, so there's no else
            }
        }

        private void EventTimer_Tick(object sender, EventArgs e)
        {
            // We have two timers because the one polling the FT232 operates at 16ms, the interval of the FT232's read timeout,
            // whereas this one runs at 10ms so we can cleanly count down delay values.
            // Is this distinction worth it? Unknown, but the FT232 is a device I don't understand and this seems to tune
            // it to usability.

            // Check the state of each button
            for (int i = 0; i < btnBits.Length; i++)
            {
                if(ButtonState[i] == true)
                {
                    // Button is currently pressed
                    // Check if countdown has expired
                    if (ButtonState[i].remaining > 0)
                    {
                        ButtonState[i].remaining -= 1; // Button isn't ready to fire; decrement value

                        // We check again here; if we are now under 0, fire the action
                        // This code will never be reached once the number sinks below 0 for the first time
                        if (ButtonState[i].remaining <= 0)
                        {
                            buttonLights[i].BackColor = Color.LimeGreen;
                            DbgW("Delay elapsed on button " + i.ToString());
                            ButtonEvent(i);
                        }
                    }
                }
            }
        }


        // Common function for triggering button events so delay & instant buttons use the same code
        private void ButtonEvent(int index)
        {
            // New sendkey APIs
            //SendRawInput.SendKeyDown(SendRawInput.KeyCodes.DIK_LCONTROL);
            //SendRawInput.SendKeyPress(SendRawInput.KeyCodes.DIK_V, 50);
            //SendRawInput.SendKeyUp(SendRawInput.KeyCodes.DIK_LCONTROL);

            // Don't actually send keys if "Enable binds" is unchecked
            if (ChkBinds.Checked == false)
            {
                DbgW("Binds disabled; not sending keys");
                return;
            }

            string macro = ActionStrings[index].Text;
            string[] MacroTokens;            
            // Validate the macro and get an array of valid keycodes back
            try
            {
                MacroTokens = ValidateMacro(macro);
            } catch (FormatException e)
            {
                DbgW("Macro for button " + index.ToString() + " is invalid: " + e.Message);
                return;
            }

            // This will track modifier keys to ensure they're all terminated
            List<string> Modifiers = new List<string>();

            DbgW("Sending keys: " + string.Join(",", MacroTokens));
            // Send the actual keystrokes
            foreach (string Token in MacroTokens)
            {
                SendRawInput.KeyInfo key = SendRawInput.KeyData[Token];
                // Track which modifiers are down and send the appropriate Down or Up
                if (key.Modifier)
                {
                    if (!Modifiers.Contains(Token))
                    {
                        Modifiers.Add(Token);
                        SendRawInput.SendKeyDown(Token);
                    }
                    else
                    {
                        Modifiers.Remove(Token);
                        SendRawInput.SendKeyUp(Token);
                    }
                } else
                {
                    // It's a normal key, just press it
                    // Currently there is a 50ms hardcoded delay; this will be improved later
                    SendRawInput.SendKeyPress(Token, 50);
                }
            }

            // Play default sound
            if (ButtonState[index].SoundEffect == true) PlaySound("coinin");
        }

        // Parse a key macro and return a string of tokens
        public string[] ValidateMacro(string macro)
        {
            // This will track modifier keys to ensure they're all terminated
            List<string> Modifiers = new List<string>();
            // Holds series of tokens to be returned
            List<string> KeyTokens = new List<string>();

            // Split input into words
            string[] tokens = macro.Split(' ');

            if (tokens.Length < 1)
            {
                throw new FormatException("Key macro is blank");
            }

            // Iterate over words
            foreach (string token in tokens)
            {
                string tokenU = token.ToUpper();
                // Check if word is a valid key
                if (SendRawInput.KeyData.ContainsKey(tokenU))
                {
                    // Add it to the return value
                    KeyTokens.Add(tokenU);
                    SendRawInput.KeyInfo key = SendRawInput.KeyData[tokenU];
                    // If the key is a modifier and isn't in the Modifiers list, add it.
                    // Otherwise, remove it.
                    // This will be used to ensure all modifiers are terminated.
                    if (key.Modifier)
                    {
                        if (!Modifiers.Contains(tokenU)) {
                            Modifiers.Add(tokenU);
                        } else {
                            Modifiers.Remove(tokenU);
                        }
                    }
                } else
                {
                    // Was not a valid key; give up and throw exception (since otherwise we'd need to
                    // return an empty string, which is vague)
                    throw new FormatException("Invalid key name: " + token);
                }
            }

            // If there are any unmatched modifier keys (pressed but never released), release them now
            if (Modifiers.Count > 0)
            {
#if DEBUG
                DbgW("Modifier keys " + string.Join(",", Modifiers) + " were not terminated, terminating automatically.");
#endif

                // Add each modifier to the returned string
                foreach(string Modifier in Modifiers)
                {
                    KeyTokens.Add(Modifier);
                }
            }

            return KeyTokens.ToArray();
  
            /* 
            * Note for later reference: there are a lot of ways of making modifier keys work, and at some later date,
            * if anyone has interest in this project , I would love to see this language replaced with one that does a
            * cleaner job with them, but parsers are the opposite of my forte, so this isn't going to be clean.
            * 
            * A good way to handle this would be to say that a single modifier by itself is an instantaneous keypress,
            * a modifier prefixed e.g. CTRL {A A S} will send Ctrl keydown, A A S as keypresses, then Ctrl keyup. But
            * the code for that is ugly and confusing to my head, so I'm just going to make every modifier a toggle.
            * 
            * Every modifier is flagged as such in the key value structure, and has a state field. when it's in a
            * macro it will toggle the state every time it's called; macro validation will fail if not all modifiers are
            * released after being set. This is probably adequate long term, frankly.
            */
        }

        /*
         *  UI BEHAVIORS
         */

        // Event when a delay field is changed
        private void Event_ValidateDelay(object sender, EventArgs e)
        {
            // Find field ID and call method to update delay
            TextBox tb = (TextBox)sender;

            int i = int.Parse((string) tb.Tag);
            ValidateDelay(i);
        }

        // Event for updating button delays
        private void ValidateDelay(int i)
        {
            // Update delay on start or when text field is changed
            // Check if there's a valid number in the delay field
            try
            {
                // Yep - clear field error color and set delay value
                ButtonState[i].delay = int.Parse(delayValues[i].Text);
                this.BackColor = DefaultBackColor;
            }
            catch (Exception err)
            {
                // Nope - flag field and set delay value to 0 so we can continue processing
                DbgW("The value for delay on button " + i.ToString() + " is not a valid number.");
                ButtonState[i].delay = 0;
                delayValues[i].BackColor = Color.Pink;
            }
        }

        // Set/clear sound effect flag on a button
        private void Event_SetSoundEffect(object sender, EventArgs e)
        {
            // Find field ID
            CheckBox tb = (CheckBox)sender;
            int i = int.Parse((string)tb.Tag);
            // Set sound effect flag
            ButtonState[i].SoundEffect = tb.Checked;
        }

        // Stub to play generic sound; will be expanded in later versions
        private void PlaySound(string index)
        {
            CoinInSound.controls.stop();
            CoinInSound.controls.play();
        }



        /*
         * WINDOW AND TRAYICON EVENTS
         */

        // If user minimizes window, go to tray
        private void FrmCpl_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        // Left click on trayicon to raise window
        private void NtiIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal; // In case it was minimized
                this.BringToFront(); // In case it's behind something
            }
        }

        // "Exit" button in trayicon menu
        private void CtiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // "Show" button in trayicon menu
        private void CtiShow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal; // In case it was minimized
            this.BringToFront(); // In case it's behind something
        }

        // Prompt user to exit
        private void FrmCpl_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If Windows is shutting down, don't interrupt it
            if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.TaskManagerClosing) return;
            // Otherwise offer a confirmation
            if (MessageBox.Show(this, "Are you sure you want to exit? If you just meant to hide the window, minimize it instead.\r\n\r\nExit anyway?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }



        /*
         * LOADING AND SAVING SETTINGS
         */

        // If the program is closing, save the settings
        private void FrmCpl_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
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

                chkSnd1.Checked = CheckText(ini.IniReadValue("button1", "sound", "false"));
                chkSnd2.Checked = CheckText(ini.IniReadValue("button2", "sound", "false"));
                chkSnd3.Checked = CheckText(ini.IniReadValue("button3", "sound", "false"));
                chkSnd4.Checked = CheckText(ini.IniReadValue("button4", "sound", "false"));
                chkSnd5.Checked = CheckText(ini.IniReadValue("button5", "sound", "false"));
                chkSnd6.Checked = CheckText(ini.IniReadValue("button6", "sound", "false"));
                chkSnd7.Checked = CheckText(ini.IniReadValue("button7", "sound", "false"));
                chkSnd8.Checked = CheckText(ini.IniReadValue("button8", "sound", "false"));
            }
            catch (Win32Exception err)
            {
                DbgW("Unable to read INI: " + err.ToString());
            }
        }
        
        // Just convert "true" or "false" to a bool
        private bool CheckText(string Value)
        {
            if (Value.ToLower() == "true")
            {
                return true;
            } else
            {
                return false;
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

            ini.IniWriteValue("button1", "sound", chkSnd1.Checked.ToString());
            ini.IniWriteValue("button2", "sound", chkSnd2.Checked.ToString());
            ini.IniWriteValue("button3", "sound", chkSnd3.Checked.ToString());
            ini.IniWriteValue("button4", "sound", chkSnd4.Checked.ToString());
            ini.IniWriteValue("button5", "sound", chkSnd5.Checked.ToString());
            ini.IniWriteValue("button6", "sound", chkSnd6.Checked.ToString());
            ini.IniWriteValue("button7", "sound", chkSnd7.Checked.ToString());
            ini.IniWriteValue("button8", "sound", chkSnd8.Checked.ToString());
        }
    }
}
