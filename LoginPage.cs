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

            // Set the AcceptButton to the login button
            this.AcceptButton = btnLogin;
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate user
            User validatedUser = userService.ValidateUser(userName, password);

            if (validatedUser != null)
            {
                MessageBox.Show($"Login successful! Welcome, {validatedUser.Username}.\nYour role is: {validatedUser.Role}",
                                "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update last login time
                userService.UpdateLastLogin(validatedUser.UserID);

                // Store user details
                UserID = validatedUser.UserID;
                UserRole = validatedUser.Role;
                UserName = validatedUser.Username;

                // Create full name for welcome message
                string fullName = $"{validatedUser.FirstName} {validatedUser.LastName}";
                MDIParentForm mdiParent = new MDIParentForm(UserID, UserRole, fullName); // Pass full name
                mdiParent.Show();
                this.Hide();
            }
            else
            {
                lbErrorMessage.Text = "Invalid username or password.";
                DialogResult = DialogResult.None; // Prevent dialog from closing
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotPassword().ShowDialog();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterAccount().ShowDialog();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            lbErrorMessage.Text = string.Empty; // Clear error message
        }

        public static void PerformLogout()
        {
            // Find the active MDI parent (if it exists)
            Form activeMdiParent = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f.IsMdiContainer);
            if (activeMdiParent != null)
            {
                foreach (Form childForm in activeMdiParent.MdiChildren)
                {
                    childForm.Close();
                }
                activeMdiParent.Close();
            }

            // Show the login page again
            LoginPage loginPage = Application.OpenForms.OfType<LoginPage>().FirstOrDefault();
            if (loginPage != null)
            {
                loginPage.Show();
            }
            else
            {
                new LoginPage().Show();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // If Enter key is pressed
            {
                btnLogin.PerformClick(); // Simulate button click
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // If Enter key is pressed
            {
                btnLogin.PerformClick(); // Simulate button click
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Attach the KeyDown event handlers
            txtUserName.KeyDown += txtUserName_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;
        }
    }
}