using System;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class AddRetreat : Form
    {
        private readonly Retreat selectedRetreat;
        private readonly int currentUserID; // Store the current user's ID
        private string imageBase64String; // Store the image as a Base64 string

        public AddRetreat(Retreat selectedRetreat, int userID) // Pass the user ID
        {
            InitializeComponent();
            this.selectedRetreat = selectedRetreat;
            this.currentUserID = userID; // Store the user ID
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

                // Validate and set start date
                if (selectedRetreat.StartDate >= dtpStartDate.MinDate && selectedRetreat.StartDate <= dtpStartDate.MaxDate)
                {
                    dtpStartDate.Value = selectedRetreat.StartDate;
                }
                else
                {
                    MessageBox.Show("Start date is out of valid range.");
                    dtpStartDate.Value = dtpStartDate.MinDate; // Set to a default valid date
                }

                // Validate and set end date
                if (selectedRetreat.EndDate >= dtpEndDate.MinDate && selectedRetreat.EndDate <= dtpEndDate.MaxDate)
                {
                    dtpEndDate.Value = selectedRetreat.EndDate;
                }
                else
                {
                    MessageBox.Show("End date is out of valid range.");
                    dtpEndDate.Value = dtpEndDate.MinDate; // Set to a default valid date
                }

                // Load image if applicable
                if (!string.IsNullOrEmpty(selectedRetreat.ImageURL))
                {
                    try
                    {
                        // Set the decoded image into the PictureBox
                        byte[] imageBytes = Convert.FromBase64String(selectedRetreat.ImageURL);

                        // Convert the byte array into an Image object
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image retreatImage = Image.FromStream(ms);

                            // Set the decoded image into the PictureBox
                            pictureBox.Image = retreatImage;
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    catch (FormatException ex)
                    {
                        // Handle error if base64 string is invalid
                        MessageBox.Show("Invalid image format: " + ex.Message);
                    }
                }
                else
                {
                    // If no image, display
                    pictureBox.Image = null;  //set a default image
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
                    // Load the image from the file
                    Image image = Image.FromFile(selectedFile);

                    // Convert the image to a Base64 string
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        byte[] imageBytes = ms.ToArray();
                        imageBase64String = Convert.ToBase64String(imageBytes);
                    }

                    // Display the image in the PictureBox
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
            // Close the current form
            this.Close();
        }

        private void btnSaveRetreat_Click(object sender, EventArgs e)
        {
            // Capture input field values
            string retreatName = txtRetreatName.Text;
            string description = rbRetreatDiscription.Text;
            string location = txtRetreatLocation.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            decimal price;
            int capacity;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(retreatName) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(location) ||
                !decimal.TryParse(numPrice.Text, out price) ||
                !int.TryParse(numCapacity.Text, out capacity) ||
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
                        retreatToUpdate.LastUpdated = DateTime.Now; // Update last modified date
                        retreatToUpdate.ImageURL = imageBase64String; // Update the image
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
                        ImageURL = imageBase64String, // Set the image
                        ContactInfo = "Contact Information", // Set as needed
                        CreatedBy = currentUserID, // Set the CreatedBy user ID
                        OrganizerID = currentUserID, // Assuming the current user is the organizer
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
            rbRetreatDiscription.Clear(); // Assuming this is a RichTextBox or similar
            txtRetreatLocation.Clear();
            numPrice.Value = 0; // Reset numeric input
            numCapacity.Value = 0; // Reset numeric input
            dtpStartDate.Value = DateTime.Now; // Reset to current date
            dtpEndDate.Value = DateTime.Now; // Reset to current date
            pictureBox.Image = null; // Reset image preview
        }
    }
}