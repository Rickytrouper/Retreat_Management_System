using System;
using System.Data.Entity.Infrastructure;
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
        private readonly int organizerID;
        private readonly int createdByUserID;
        private readonly string mode;
        private string imagePath; // Store the image path

        public AddRetreat(Retreat selectedRetreat, int organizerID, int createdByUserID, string mode = "Add")
        {
            InitializeComponent();
            this.mode = mode;
            lblWelcome.Text = mode == "Edit" ? "Edit Retreat" : "Add Retreat";

            this.selectedRetreat = selectedRetreat;
            this.organizerID = organizerID;
            this.createdByUserID = createdByUserID;
            LoadRetreatData();
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
                txtContactDetails.Text = selectedRetreat.ContactInfo;

               
                dtpStartDate.Value = selectedRetreat.StartDate >= dtpStartDate.MinDate ? selectedRetreat.StartDate : dtpStartDate.MinDate;
                dtpEndDate.Value = selectedRetreat.EndDate >= dtpEndDate.MinDate ? selectedRetreat.EndDate : dtpEndDate.MinDate;

                // Load the image from the file path
                if (!string.IsNullOrEmpty(selectedRetreat.ImageURL))
                {
                    try
                    {
                        if (File.Exists(selectedRetreat.ImageURL))
                        {
                            pictureBox.Image = Image.FromFile(selectedRetreat.ImageURL);
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
                else
                {
                    pictureBox.Image = null;
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
                    // Define the directory to save images
                    string directoryPath = @"C:\RetreatImages"; // Adjust to your path
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath); // Create directory if it doesn't exist
                    }

                    // Generate a unique file name to avoid conflicts
                    string fileName = Path.GetFileNameWithoutExtension(selectedFile) + "_" + Guid.NewGuid() + Path.GetExtension(selectedFile);
                    string filePath = Path.Combine(directoryPath, fileName);
                    imagePath = filePath;

                    // Save the image file
                    File.Copy(selectedFile, filePath, true); // Overwrite if file exists

                    pictureBox.Image = Image.FromFile(filePath);
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
            // Extract input values
            string retreatName = txtRetreatName.Text.Trim();
            string description = rbRetreatDiscription.Text.Trim();
            string location = txtRetreatLocation.Text.Trim();
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string contactInfo = txtContactDetails.Text.Trim();
            decimal price = numPrice.Value;
            int capacity = (int)numCapacity.Value;
           

            // Validate inputs
            if (string.IsNullOrWhiteSpace(retreatName) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(location) ||
                startDate >= endDate ||
                price <= 0 ||
                capacity <= 0 
                
                )
            {
                MessageBox.Show("Please provide valid details for all required fields, including a valid status.");
                return;
            }

            using (var dbContext = new Retreat_Management_DBEntities())
            {
                try
                {
                    if (selectedRetreat != null)
                    {
                        var retreatToUpdate = dbContext.Retreats.Find(selectedRetreat.RetreatID);
                        if (retreatToUpdate == null)
                        {
                            MessageBox.Show("Retreat not found in the database.");
                            return;
                        }

                        // Check for existing retreat name for uniqueness
                        var existingRetreat = dbContext.Retreats
                            .FirstOrDefault(r => r.RetreatName == retreatName && r.RetreatID != selectedRetreat.RetreatID);

                        if (existingRetreat != null)
                        {
                            MessageBox.Show("A retreat with this name already exists.");
                            return;
                        }

                        // Update retreat details
                        retreatToUpdate.RetreatName = retreatName;
                        retreatToUpdate.Description = description;
                        retreatToUpdate.Location = location;
                        retreatToUpdate.StartDate = startDate;
                        retreatToUpdate.EndDate = endDate;
                        retreatToUpdate.Price = price;
                        retreatToUpdate.Capacity = capacity;                      
                        retreatToUpdate.LastUpdated = DateTime.Now;

                        // Update the image path if a new image is uploaded
                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            retreatToUpdate.ImageURL = imagePath;
                        }

                        retreatToUpdate.ContactInfo = contactInfo;

                        // Save changes
                        dbContext.SaveChanges();
                        MessageBox.Show("Retreat updated successfully.");
                        this.Close();
                    }
                    else
                    {
                        // Create new retreat logic
                        var newRetreat = new Retreat
                        {
                            RetreatName = retreatName,
                            Description = description,
                            Location = location,
                            StartDate = startDate,
                            EndDate = endDate,
                            Price = price,
                            Capacity = capacity,
                            ImageURL = imagePath,
                            ContactInfo = contactInfo,
                            CreatedBy = createdByUserID,
                            OrganizerID = organizerID, // Set OrganizerID on creation
                            DateCreated = DateTime.Now,
                            LastUpdated = DateTime.Now
                        };

                        dbContext.Retreats.Add(newRetreat);
                        dbContext.SaveChanges();
                        MessageBox.Show("Retreat saved successfully.");
                        this.Close();
                    }
                }
                catch (DbUpdateException dbUpdateEx)
                {
                    var errorMessage = $"Update error: {dbUpdateEx.Message}";
                    if (dbUpdateEx.InnerException != null)
                    {
                        errorMessage += $"\nInner Exception: {dbUpdateEx.InnerException.Message}";
                        if (dbUpdateEx.InnerException.InnerException != null)
                        {
                            errorMessage += $"\nInner Inner Exception: {dbUpdateEx.InnerException.InnerException.Message}";
                        }
                    }
                    MessageBox.Show(errorMessage);
                }
                catch (DbEntityValidationException dbEx)
                {
                    var errorDetails = "Validation errors:\n";
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            errorDetails += $"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}\n";
                        }
                    }
                    MessageBox.Show(errorDetails);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRetreatName.Clear();
            rbRetreatDiscription.Clear();
            txtRetreatLocation.Clear();
            numPrice.Value = 0;
            numCapacity.Value = 0;            
            txtContactDetails.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            pictureBox.Image = null;
            imagePath = null; // Reset the image path
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            LoginPage.PerformLogout();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            // About dialog logic here
        }

        private void AddRetreat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'retreatDetails.Retreat' table. You can move, or remove it, as needed.
            this.retreatTableAdapter.Fill(this.retreatDetails.Retreat);

        }
    }
}