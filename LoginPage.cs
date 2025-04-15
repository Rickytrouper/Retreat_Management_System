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
    
        public LoginPage()
        {
            InitializeComponent();
            userService = new UserService(); // Initialize user service
        }       
        private void btnSubmitLogin_Click(object sender, EventArgs e)
{
    string userName = txtUserName.Text.Trim(); // Get the username input
    string password = txtPassword.Text.Trim(); // Get the password input

    // Validate the inputs 
    if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
    {
        MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    User validatedUser = userService.ValidateUser(userName, password); // Validate user

    if (validatedUser != null) // Check if the user is validated
    {
        // Check if the user account is suspended
        if (validatedUser.AccountStatus == "Suspended")
        {
            MessageBox.Show("Your account is suspended. Please contact the administrator.", "Account Suspended", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; // Stop further processing
        }

           // Update the LastLogin property
         validatedUser.LastLogin = DateTime.Now; // Set current date and time
         userService.UpdateUserLastLogin(validatedUser); // Custom service method to update the user



                MessageBox.Show($"Login successful! Welcome, {validatedUser.Username}.\nYour role is: {validatedUser.Role}",
                        "Login Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

        // Opening the appropriate dashboard based on user role
        this.Hide(); // Hide the login form
        Form mainForm;

        switch (validatedUser.Role)
        {
            case "Admin":
                mainForm = new AdminDash(); // Admin dashboard form
                ((AdminDash)mainForm).SetWelcomeMessage(validatedUser.Username); // Set welcome message
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

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.ShowDialog(); 
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the RegistrationForm
            RegisterAccount registrationForm = new RegisterAccount();

           
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
