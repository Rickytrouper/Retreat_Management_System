using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class RegisterAccount : Form
    {
        private readonly UserService userService; // Service to handle user-related operations

        public RegisterAccount()
        {
            InitializeComponent();
            userService = new UserService(); // Initialize user service
            LoadRoles(); // Load roles into the ComboBox
        }

        private void LoadRoles()
        {
            // Clear existing items
            cbRole.Items.Clear();

            // Define roles excluding Admin
            List<string> roles = new List<string>
            {
                "User",
                "Organizer"
            };

            // Populate the ComboBox with roles
            foreach (var role in roles)
            {
                cbRole.Items.Add(role);
            }

            // Optionally, set default selection
            cbRole.SelectedIndex = 0; // Default to the first role
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
            string password = txtCrePassword.Text.Trim();
            string confirmPassword = txtConPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string verifyEmail = txtVerifyEmail.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string role = cbRole.SelectedItem.ToString();
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

            // Validate that the emails match
            if (email != verifyEmail)
            {
                lbEmailMatching.Text = "Email addresses do not match. Please try again.";
                return; // Exit the method
            }
            else
            {
                lbEmailMatching.Text = ""; // Clear any previous error message
            }

            // Save the profile picture path or image
            if (picbxProfile.Image != null)
            {
                profilePicture = SaveProfilePicture();
            }

            // Hash the password before saving
            string hashedPassword = HashPassword(password);

            // Create a new User object
            var newUser = new User
            {
                Username = username,
                Password = hashedPassword, // Use the hashed password
                Email = email,
                Role = role,
                FirstName = firstName,
                LastName = lastName,
                ProfilePicture = profilePicture,
                ContactInfo = contactInfo,
                DateCreated = DateTime.Now,
                LastLogin = null, // User has not logged in yet
                AccountStatus = "Active" // Set the status to "Active"
            };

            // Checking  if the username already exists
            using (var dbContext = new Retreat_Management_DBEntities())
            {
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

        // Method to hash passwords
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        // Method to save the profile picture and return the file path
        private string SaveProfilePicture()
        {
            // Logic to save the profile picture to a server or local storage
            string folderPath = @"C:\ProfilePictures\"; // Specify storage path
            string fileName = $"{Guid.NewGuid()}.jpg"; // Generate a file name
            string fullPath = System.IO.Path.Combine(folderPath, fileName);

            // Create directory if it does not exist
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