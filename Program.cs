using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using JentrousMarketing.Forms;
using Telerik.WinControls;

namespace JentrousMarketing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
                
            //RadMessageBox.Show("Reached Maximum Login Attempts. Application Will Now Close.", "Max Attempts",MessageBoxButtons.OK,RadMessageIcon.Exclamation);
        }
    }
}
