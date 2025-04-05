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
        private UserService userService; // Service to handle user-related operations
        // Constructor
    
        public LoginPage()
        {
            InitializeComponent();
            userService = new UserService(); // Initialize user service
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Initialization logic if necessary
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim(); // Get the username input
            string password = txtPassword.Text.Trim(); // Get the password input

            // Validate the inputs (simple check, you can enhance it)
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

             User validatedUser = userService.ValidateUser(userName, password); // Validate user

            if (validatedUser != null) // Check if the user is validated
            {
                MessageBox.Show($"Login successful! Welcome, {validatedUser.Username}.\nYour role is: {validatedUser.Role}",
                                "Login Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Opening the appropriate dashboard based on user role

                this.Hide(); // Hide the login form, or close it if you want
                Form mainForm;

                switch (validatedUser.Role)
                {
                    case "Admin":
                        mainForm = new AdminDash(); // Admin dashboard form
                        break;
                    case "Organizer":
                        mainForm = new OrganizerDash(); // Organizer dashboard form
                        break;
                    case "User":
                        mainForm = new UserDash(validatedUser.UserID); // User dashboard form
                        break;
                    default:
                        mainForm = new LoginPage(); // Default case
                        break;
                }

                mainForm.Show(); // Show the appropriate dashboard
            }
            else
            {
                // Display error message
                lbErrorMessage.Text = "Invalid username or password."; 
               
            }
       
    }

        private bool ValidateUser(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.ShowDialog(); // Show as a dialog to focus on this form until it's closed
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
