using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArcadeControlPanel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static StreamWriter fDebug;

        [STAThread]
        static void Main()
        {
            // Debug log
            fDebug = new StreamWriter(@"acp_debug.txt");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCpl());

            fDebug.Close();
        }
    }
}
