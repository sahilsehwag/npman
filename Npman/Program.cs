using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npman.Dialogs;
using System.Threading;

namespace Npman
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

            Splash splash = new Splash();
            Application.Run(splash);

            Login login = new Login();
            Application.Run(login);
        }
    }
}
