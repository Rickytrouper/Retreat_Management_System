using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class AddRetreat : Form
    {
        private Retreat selectedRetreat;

        public AddRetreat(Retreat selectedRetreat)
        {
            InitializeComponent();
            this.selectedRetreat = selectedRetreat;
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
                // pictureBox.Image = LoadImage(selectedRetreat.ImageURL); // Implement this method to load the image
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
                // Display selected file name or preview the image
                // pictureBox.Image = Image.FromFile(selectedFile); // Assuming you have a PictureBox to show the image
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var userService = new UserService();
            int userId = userService.GetCurrentUserId(); // Get the current user ID
            string userRole = CurrentUser.Role; // Get the current user's role

            Form dashboardForm;

            // Create the appropriate dashboard based on the user's role
            if (userRole == "Admin")
            {
                dashboardForm = new AdminDash(userId); // Pass the user ID
            }
            else if (userRole == "Organizer")
            {
                dashboardForm = new OrganizerDash(userId); // Pass the user ID
            }
            else
            {
                MessageBox.Show("User role not recognized.");
                return;
            }

            // Show the appropriate dashboard and close the current form
            dashboardForm.Show();
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

            var userService = new UserService();
            int organizerID = userService.GetCurrentUserId(); // Get current user ID

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
                                                                    // If you have an image URL, update it as well
                                                                    // retreatToUpdate.ImageURL = "your_image_path"; // Update this if applicable
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
                        ImageURL = "your_image_path", // Set the image URL if applicable
                        ContactInfo = "Contact Information", // Set as needed
                        OrganizerID = organizerID, // Use the current user's ID (either organizer or admin)
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
            // Reset image preview if applicable
            // pictureBox.Image = null; // Assuming you have a PictureBox to show the image
        }
    }
}