using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class lblRetreatDetails : Form
    {
        private readonly Retreat_Management_DBEntities retreat_Management_DBEntities;
        private int currentUserId; // Store the user ID
        private readonly UserDash userDashboard;

        public lblRetreatDetails(int userId, string username, UserDash existingUserDash)
        {
            InitializeComponent();
            this.Load += RetreatDetails_Load;
            cbRetreatName.SelectedIndexChanged += cbRetreatName_SelectedIndexChanged;
            retreat_Management_DBEntities = new Retreat_Management_DBEntities();
            currentUserId = userId; // Store the user ID
            userDashboard = existingUserDash; // Assign the existing UserDash instance
            pbRetreat.SizeMode = PictureBoxSizeMode.StretchImage; // This will stretch the image to fit the PictureBox
        }

        private void RetreatDetails_Load(object sender, EventArgs e)
        {
            var retreats = retreat_Management_DBEntities.Retreats.ToList();
            cbRetreatName.DisplayMember = "RetreatName";
            cbRetreatName.ValueMember = "ID";
            cbRetreatName.DataSource = retreats;
        }

        private void cbRetreatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRetreatName.SelectedItem is Retreat selectedRetreat)
            {
                // Fetch the selected retreat from the database using its ID
                var retreat = retreat_Management_DBEntities.Retreats
                    .FirstOrDefault(r => r.RetreatID == selectedRetreat.RetreatID);

                if (retreat != null)
                {
                    // Populate the text fields with retreat details
                    txtDescription.Text = retreat.Description ?? "N/A";
                    txtLocation.Text = retreat.Location ?? "N/A";
                    txtRetreatDates.Text = $"{retreat.StartDate:MM/dd/yyyy} to {retreat.EndDate:MM/dd/yyyy}";
                    txtRetreatPrice.Text = retreat.Price.ToString("C");
                    lblDiscriptionName.Text = retreat.RetreatName; // Set the label text

                    // Access current bookings directly from the retreat object
                    int currentBookings = retreat.currentBookings ?? 0; // Safe handling of null

                    // Set the capacity and calculate vacancies
                    int capacity = retreat.Capacity;
                    txtCapacity.Text = capacity.ToString();
                    int vacancy = capacity - currentBookings; // Calculate vacancies
                    txtVacancy.Text = vacancy >= 0 ? vacancy.ToString() : "0"; // Ensure not negative

                    // Load the retreat image
                    LoadRetreatImage(retreat.ImageURL);
                }
                else
                {
                    MessageBox.Show("Selected retreat not found in the database.");
                }
            }
            else
            {
                MessageBox.Show("Please select a retreat.");
            }
        }

        public void UpdateVacancy(int retreatId, int numberOfSpaces)
        {
            var retreat = retreat_Management_DBEntities.Retreats.Find(retreatId);

            if (retreat != null)
            {
                int currentBookings = retreat.currentBookings ?? 0; // Handle null safely

                // Calculate new bookings
                int newTotalBookings = currentBookings + numberOfSpaces;

                // Check if booking exceeds capacity
                if (newTotalBookings > retreat.Capacity)
                {
                    MessageBox.Show("Not enough available spaces for this booking.");
                    return; // Exit
                }

                // Update current bookings
                retreat.currentBookings = newTotalBookings; // Update the currentBookings

                // Update remaining vacancies
                int remainingVacancy = retreat.Capacity - (retreat.currentBookings ?? 0);
                txtVacancy.Text = remainingVacancy >= 0 ? remainingVacancy.ToString() : "0";

                // Save changes to the database
                try
                {
                    retreat_Management_DBEntities.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving to database: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Retreat not found.");
            }
        }

        private void LoadRetreatImage(string imageUrl)
        {
            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    if (IsBase64String(imageUrl))
                    {
                        string normalizedImageUrl = NormalizeBase64String(imageUrl);
                        byte[] imageBytes = Convert.FromBase64String(normalizedImageUrl);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image retreatImage = Image.FromStream(ms);
                            pbRetreat.Image = retreatImage;
                        }
                    }
                    else
                    {
                        // Load the image from file path
                        if (File.Exists(imageUrl))
                        {
                            pbRetreat.Image = Image.FromFile(imageUrl);
                        }
                        else
                        {
                            MessageBox.Show("Image file not found.");
                            pbRetreat.Image = null;
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid image format: " + ex.Message);
                    pbRetreat.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                    pbRetreat.Image = null;
                }
            }
            else
            {
                pbRetreat.Image = null;
            }
        }

        private bool IsBase64String(string base64)
        {
            // Check if the length is divisible by 4 and does not contain invalid characters
            if (string.IsNullOrEmpty(base64) || base64.Length % 4 != 0)
            {
                return false;
            }

            // Check for invalid characters
            return base64.All(c => "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=".Contains(c));
        }

        // Method to normalize the Base64 string
        private string NormalizeBase64String(string base64String)
        {
            // Remove any whitespace
            base64String = base64String.Replace(" ", "").Replace("\n", "").Replace("\r", "");

            // Add necessary padding
            int padding = base64String.Length % 4;
            if (padding > 0)
            {
                base64String += new string('=', 4 - padding);
            }

            return base64String;
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            if (cbRetreatName.SelectedItem is Retreat selectedRetreat && int.TryParse(txtCapacity.Text, out int numberOfSpaces))
            {
                int retreatId = selectedRetreat.RetreatID;
                decimal price = selectedRetreat.Price;

                // Hide the current retreat form
                this.Hide();

                // Create an instance of BookingPage with both userId and retreatId
                var bookingPage = new BookingPage(currentUserId, retreatId, price, userDashboard);
                bookingPage.SetRetreatName(selectedRetreat.RetreatName);

                // Create a UserService instance to get user details
                UserService userService = new UserService();
                var user = userService.GetUserDetails(currentUserId);

                // Set username and email if user is found
                if (user != null)
                {
                    bookingPage.SetUserName(user.Username);
                    bookingPage.SetEmail(user.Email);
                }

                // Set the BookingPage as an MDI child
                bookingPage.MdiParent = (MDIParentForm)this.MdiParent; // Set MDI parent
                bookingPage.Show(); // Show the form

                // Optional handle the closing of the booking form to show the user dashboard again
                bookingPage.FormClosed += (s, args) => this.Show(); // Show the UserDash again after BookingPage closes
            }
            else
            {
                MessageBox.Show("Please select a retreat and enter the number of spaces to book.");
            }
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to return to the dashboard?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close(); // Close the current form
                userDashboard.Show(); // Show the UserDash again
                userDashboard.BringToFront(); // Bring it to the front
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Set form location to be within MDI container
            if (this.MdiParent != null)
            {
                this.StartPosition = FormStartPosition.CenterParent; // Center form inside MDI parent
                this.Location = new Point(
                    Math.Max(0, (this.MdiParent.ClientSize.Width - this.Width) / 2),
                    Math.Max(0, (this.MdiParent.ClientSize.Height - this.Height) / 2)
                );
            }
        }
    }
}