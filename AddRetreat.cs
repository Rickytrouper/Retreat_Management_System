using System;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class AddRetreat : Form
    {
        private readonly Retreat selectedRetreat;
        private readonly int organizerID; // Store the organizer's ID
        private readonly int createdByUserID; // Store the current user's ID
        private string imageBase64String; // Store the image as a Base64 string

        public AddRetreat(Retreat selectedRetreat, int organizerID, int createdByUserID)
        {
            InitializeComponent();

            // Populate the ComboBox with status options
            cbRetreatStatus.Items.Add("Available");
            cbRetreatStatus.Items.Add("Unavailable");

            this.selectedRetreat = selectedRetreat;
            this.organizerID = organizerID; // Store the organizer ID
            this.createdByUserID = createdByUserID; // Store the user ID
            LoadRetreatData(); // Load data if editing an existing retreat
        }

        private void LoadRetreatData()
        {
            if (selectedRetreat != null)
            {
                txtRetreatName.Text = selectedRetreat.RetreatName;
                rbRetreatDiscription.Text = selectedRetreat.Description;
                txtRetreatLocation.Text = selectedRetreat.Location;
                numPrice.Value = selectedRetreat.Price;
                numCapacity.Value = selectedRetreat.Capacity;

                // Set the combo box status
                cbRetreatStatus.SelectedItem = selectedRetreat.Status ?? "Available"; // Default to Available if null

                // Validate and set start date
                dtpStartDate.Value = selectedRetreat.StartDate >= dtpStartDate.MinDate
                    ? selectedRetreat.StartDate
                    : dtpStartDate.MinDate; // Default valid date

                // Validate and set end date
                dtpEndDate.Value = selectedRetreat.EndDate >= dtpEndDate.MinDate
                    ? selectedRetreat.EndDate
                    : dtpEndDate.MinDate; // Default valid date

                // Load the image if applicable
                if (!string.IsNullOrEmpty(selectedRetreat.ImageURL))
                {
                    try
                    {
                        byte[] imageBytes = Convert.FromBase64String(selectedRetreat.ImageURL);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image retreatImage = Image.FromStream(ms);
                            pictureBox.Image = retreatImage;
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Invalid image format: " + ex.Message);
                    }
                }
                else
                {
                    pictureBox.Image = null; // Set a default image
                }
            }
        }

        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Select Retreat Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                try
                {
                    Image image = Image.FromFile(selectedFile);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        byte[] imageBytes = ms.ToArray();
                        imageBase64String = Convert.ToBase64String(imageBytes);
                    }

                    pictureBox.Image = image;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveRetreat_Click(object sender, EventArgs e)
        {
            // Get the selected status
            string selectedStatus = cbRetreatStatus.SelectedItem?.ToString() ?? "Available"; // Default to "Available"

            // Capture input field values
            string retreatName = txtRetreatName.Text;
            string description = rbRetreatDiscription.Text;
            string location = txtRetreatLocation.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            decimal price = numPrice.Value;
            int capacity = (int)numCapacity.Value; // Cast to int directly

            // Validate inputs
            if (string.IsNullOrWhiteSpace(retreatName) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(location) ||
                startDate >= endDate)
            {
                MessageBox.Show("Please enter valid details for the retreat.");
                return;
            }

            using (var dbContext = new Retreat_Management_DBEntities())
            {
                if (selectedRetreat != null)
                {
                    // Update existing retreat
                    var retreatToUpdate = dbContext.Retreats.Find(selectedRetreat.RetreatID);
                    if (retreatToUpdate != null)
                    {
                        retreatToUpdate.RetreatName = retreatName;
                        retreatToUpdate.Description = description;
                        retreatToUpdate.Location = location;
                        retreatToUpdate.StartDate = startDate;
                        retreatToUpdate.EndDate = endDate;
                        retreatToUpdate.Price = price;
                        retreatToUpdate.Capacity = capacity;
                        retreatToUpdate.Status = selectedStatus; // Update status
                        retreatToUpdate.LastUpdated = DateTime.Now; // Update last modified date
                        retreatToUpdate.ImageURL = imageBase64String; // Update the image
                        retreatToUpdate.ContactInfo = "Contact Information"; // Set appropriate contact information
                        retreatToUpdate.OrganizerID = organizerID; // Ensure this is set
                    }
                    else
                    {
                        MessageBox.Show("Retreat not found in the database.");
                        return;
                    }
                }
                else
                {
                    // Create a new retreat object
                    var retreat = new Retreat
                    {
                        RetreatName = retreatName,
                        Description = description,
                        Location = location,
                        StartDate = startDate,
                        EndDate = endDate,
                        Price = price,
                        Capacity = capacity,
                        Status = selectedStatus, // Set the status for new retreat
                        ImageURL = imageBase64String, // Set the image
                        ContactInfo = "Contact Information", // Set as needed
                        CreatedBy = createdByUserID, // Use the current user's ID
                        OrganizerID = organizerID, // Use the passed OrganizerID
                        DateCreated = DateTime.Now,
                        LastUpdated = DateTime.Now
                    };

                    // Add the retreat to the context
                    dbContext.Retreats.Add(retreat);
                }

                try
                {
                    dbContext.SaveChanges(); // Save changes to the database
                    MessageBox.Show(selectedRetreat != null ? "Retreat updated successfully." : "Retreat saved successfully.");
                    this.Close(); // Close the AddRetreat form after saving
                }
                catch (DbEntityValidationException dbEx)
                {
                    // Handle validation errors
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle other exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtRetreatName.Clear();
            rbRetreatDiscription.Clear(); // Clear the description
            txtRetreatLocation.Clear();
            numPrice.Value = 0; // Reset numeric input
            numCapacity.Value = 0; // Reset numeric input
            cbRetreatStatus.SelectedIndex = 0; // Default to "Available"
            dtpStartDate.Value = DateTime.Now; // Reset to current date
            dtpEndDate.Value = DateTime.Now; // Reset to current date
            pictureBox.Image = null; // Reset image preview
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            LoginPage.PerformLogout(); // Call the logout static method 
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            // About dialog logic here
        }
    }
}