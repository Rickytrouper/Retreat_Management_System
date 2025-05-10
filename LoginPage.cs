using System;
using System.Linq;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class LoginPage : Form
    {
        private readonly UserService userService;

        public int UserID { get; private set; }
        public string UserRole { get; private set; }
        public string UserName { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User validatedUser = userService.ValidateUser(userName, password);

            if (validatedUser != null)
            {
                // Successful login
                MessageBox.Show($"Login successful! Welcome, {validatedUser.Username}.\nYour role is: {validatedUser.Role}",
                                "Login Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Update LastLogin time
                userService.UpdateLastLogin(validatedUser.UserID);

                // Set the properties
                UserID = validatedUser.UserID;
                UserRole = validatedUser.Role;
                UserName = validatedUser.Username;

                // Create and show the MDIParentForm
                MDIParentForm mdiParent = new MDIParentForm(UserID, UserRole);
                mdiParent.Show();

                // Hide the LoginPage instead of closing it
                this.Hide();
            }
            else
            {
                lbErrorMessage.Text = "Invalid username or password.";
                DialogResult = DialogResult.None;
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.ShowDialog();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterAccount registrationForm = new RegisterAccount();
            registrationForm.ShowDialog();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            lbErrorMessage.Text = string.Empty;
        }

        public static void PerformLogout()
        {
            // Find the active MDI parent (if it exists)
            Form activeMdiParent = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f.IsMdiContainer);

            // Close all child forms
            if (activeMdiParent != null)
            {
                foreach (Form childForm in activeMdiParent.MdiChildren)
                {
                    childForm.Close();
                }

                activeMdiParent.Close();
            }

            // Find the LoginPage (if it exists)
            LoginPage loginPage = Application.OpenForms.OfType<LoginPage>().FirstOrDefault();

            // Show the login page again
            if (loginPage != null)
            {
                loginPage.Show();
            }
            else
            {
                LoginPage newLoginPage = new LoginPage();
                newLoginPage.Show();
            }
        }
    }
}