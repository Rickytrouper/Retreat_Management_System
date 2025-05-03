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

            LoginPage loginForm = new LoginPage();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Get the user ID and role from the login form
                int userID = loginForm.UserID;
                string userRole = loginForm.UserRole;

                // Launch the MDIParentForm, passing the UserID and Role
                MDIParentForm mdiParent = new MDIParentForm(userID, userRole);
                Application.Run(mdiParent);
            }
            else
            {
                // Login failed or was cancelled
                Application.Exit();
            }
        }
    }
}