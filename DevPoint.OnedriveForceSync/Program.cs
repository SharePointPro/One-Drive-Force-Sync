using DevPoint.OnedriveForceSync.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevPoint.OnedriveForceSync
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Count() > 0 && args[0] == "--nogui")
            {
                //Run Force Sync Logic
                CopyDeleteUtil.Execute();
            }
            else
            {
                //Run Settings Form
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SetupFoldersForm());
            }
        }
    }
}