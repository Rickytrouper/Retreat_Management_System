using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class LoginPage: Form
    {
        private readonly UserService userService; // Service to handle user-related operations       
    
        public LoginPage()
        {
            InitializeComponent();
            userService = new UserService(); // Initialize user service
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
            
                this.Hide();
                Form mainForm;

                switch (validatedUser.Role)
                {
                    case "Admin":
                        mainForm = new AdminDash(validatedUser.UserID);
                        ((AdminDash)mainForm).SetWelcomeMessage(validatedUser.Username);
                        break;
                    case "Organizer":
                        mainForm = new OrganizerDash(validatedUser.UserID);
                        break;
                    case "User":
                        mainForm = new UserDash(validatedUser.UserID);
                        break;
                    default:
                        mainForm = new LoginPage();
                        break;
                }

                mainForm.Show();
            }
            else
            {
                lbErrorMessage.Text = "Invalid username or password.";
            }
        }

        public void LoginSuccessful(int adminID)
        {
            UserManagementForm userManagementForm = new UserManagementForm(adminID);
            userManagementForm.Show();
            this.Hide(); // Hide the login form
        }


        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.ShowDialog(); 
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the RegistrationForm
            RegisterAccount registrationForm = new RegisterAccount();

           // prevent the user from interacting with the parent form until they close the registration form
           registrationForm.ShowDialog();
           
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {

            // Clear the input fields
            txtUserName.Text = string.Empty; // Clear username text box
            txtPassword.Text = string.Empty;  // Clear password text box

            //  reset the error message label
            lbErrorMessage.Text = string.Empty; 
        }


    }
}
