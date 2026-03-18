using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kshieldvpn
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static bool IsUserLoggedIn = false;  // Keeps track of login session
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Form());

            if (KshieldVPN.Properties.Settings.Default.RememberMe)
            {
                IsUserLoggedIn = true;
            }

            Application.Run(new Login_Form());
        }
    }
}
