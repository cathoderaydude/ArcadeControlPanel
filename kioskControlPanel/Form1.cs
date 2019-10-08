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
    public partial class Form1 : Form
    {
        public static FTDI ftdi;
        public static FTDI.FT_STATUS ft_status;
        public static UInt32 bytesWritten;

        private int counter;

        public Form1()
        {
            InitializeComponent();

            ftdi = new FTDI();
            ft_status = FTDI.FT_STATUS.FT_OK;
            bytesWritten = 0;

            keysDown = new bool[] {false, false, false, false};
            counter = 0;

            ft_status = ftdi.OpenByIndex(0);
            ft_status = ftdi.SetBitMode(255, 1);
            ft_status = ftdi.SetBaudRate(300);
            //ft_status = ftdi.SetTimeouts(5, 5);
        }

        public static bool[] keysDown;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        int x;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = 0;

            byte[] readData = new byte[256];
            uint bytesRead = 0;


            ft_status = ftdi.GetRxBytesAvailable(ref bytesRead);
            if (ft_status != FTDI.FT_STATUS.FT_OK)
            {
                throw new Exception("Failed to get number of bytes available to read (error " + ft_status.ToString() + ")");
                //return;
            }

            ftdi.Read(readData, bytesRead, ref bytesRead);
            //Console.WriteLine("Data bytes: " + bytesRead.ToString());
            //string readDataS = System.Text.Encoding.ASCII.GetString(readData, 0, (int)bytesRead).Replace("\\", "");
            //Console.WriteLine("Data:" + readDataS);
            //Console.WriteLine("Data:" + readData[0].ToString());
            //Console.Write("Data: ");
            /*foreach (byte b in readData)
            {
                Console.Write(b.ToString());
            }
            Console.WriteLine();*/
            String aa = "";
            for (x=0;x<256;x++)
            {
                aa += readData[x].ToString();
            }
            //Console.WriteLine(aa);
            
            if ( ( ( ( (int) readData[0]) & 16) != 0) && keysDown[0] == false)
            {
                keysDown[0] = true;
                SendKeys.Send("{F5}");
                Console.WriteLine("F5");
            }
            else if (readData[0] != 16)
            {
                keysDown[0] = false;
            }

            if (((((int)readData[0]) & 64) != 0) && keysDown[1] == false)
            {
                keysDown[1] = true;
                SendKeys.Send("%{F4}");
                Console.WriteLine("Alt-F4");
            }
            else if (readData[0] != 64)
            {
                keysDown[1] = false;
            }

            if (((((int)readData[0]) & 128) != 0) && keysDown[2] == false)
            {
                keysDown[2] = true;
                SendKeys.Send("{Esc}");
                Console.WriteLine("Escape");
            }
            else if (readData[0] != 128)
            {
                keysDown[2] = false;
            }

            if (((((int)readData[0]) & 32) != 0) && keysDown[3] == false)
            {
                keysDown[3] = true;
                SendKeys.Send("{5}");
                Console.WriteLine("5");
            }
            else if (readData[0] != 32)
            {
                keysDown[3] = false;
            }
        }
    }
}
