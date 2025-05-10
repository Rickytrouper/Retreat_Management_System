using System;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginPage()); // LoginPage is the main form
        }
    }
}