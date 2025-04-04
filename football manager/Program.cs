using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace football_manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            veri.okuma asd = new veri.okuma();
      
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
