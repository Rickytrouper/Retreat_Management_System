using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace Retreat_Management_System
{
    public partial class RegisterAccount: Form
    {
        private UserService userService; // Service to handle user-related operations
        public RegisterAccount()
        {
            InitializeComponent();
            userService = new UserService(); // Initialize user service
        }

        private void picbxProfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                openFileDialog.Title = "Select a Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    picbxProfile.Image = Image.FromFile(filePath);
                    picbxProfile.SizeMode = PictureBoxSizeMode.StretchImage; // Optional
                }
            }
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string username = txtUserName.Text.Trim();
            string password = txtCrePassword.Text.Trim(); // will implement later hash this before saving
            string confirmPassword = txtConPassword.Text.Trim(); // Retrieve confirm password
            string email = txtEmail.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string role = cbRole.SelectedItem.ToString(); // Using a ComboBox for roles
            string contactInfo = txtContactNum.Text.Trim();
            string profilePicture = ""; // Path for the profile picture

            // Validate that the passwords match
            if (password != confirmPassword)
            {
                lbPasswordError.Text = "Passwords do not match. Please try again.";
                return; // Exit the method
            }
            else
            {
                lbPasswordError.Text = ""; // Clear any previous error message
            }

            // Save the profile picture path or image
            if (picbxProfile.Image != null)
            {
                profilePicture = SaveProfilePicture(); // save the image path
            }

            // Create a new User object
            var newUser = new User
            {
                Username = username,
                Password = password, 
                Email = email,
                Role = role,
                FirstName = firstName,
                LastName = lastName,
                ProfilePicture = profilePicture,
                ContactInfo = contactInfo,
                DateCreated = DateTime.Now, // Use  to track creation time of account
                LastLogin = null // User has not logged in yet
            };

            // Add the new user to the context
            using (var dbContext = new Retreat_Management_DBEntities())
            {
                // Check if the username already exists
                var existingUser = dbContext.Users.FirstOrDefault(q => q.Username == username);
                if (existingUser != null)
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                // Save changes to the database
                using (var dbContext = new Retreat_Management_DBEntities())
                {
                    dbContext.Users.Add(newUser); // Add the new user
                    dbContext.SaveChanges(); // Save changes to the database
                }

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form 
            }

            // catch block for  data base error

            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                var errorMessages = dbEx.EntityValidationErrors.SelectMany(validationResult => validationResult.ValidationErrors)
                    .Select(validationError => validationError.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);
                MessageBox.Show($"Validation errors: {fullErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to save the profile picture and return the file path
        private string SaveProfilePicture()
        {
            //logic to save the profile picture to a server or local storage
            string folderPath = @"C:\ProfilePictures\"; // Specify storage path
            string fileName = $"{Guid.NewGuid()}.jpg"; // Generate a file name
            string fullPath = System.IO.Path.Combine(folderPath, fileName);

            //  directory
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            // Save the image to the directory
            picbxProfile.Image.Save(fullPath); // Save the image

            return fullPath; // Return the path to the saved image
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the registration form
        }
    }
}
