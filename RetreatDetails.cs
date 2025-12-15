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
            // Debugging output to check fetched retreat data
            Console.WriteLine($"Fetched Retreat Name: {retreat.RetreatName}, CurrentBookings: {retreat.currentBookings}, Capacity: {retreat.Capacity}");

            // Populate the text fields with retreat details
            txtDescription.Text = retreat.Description ?? "N/A";
            txtLocation.Text = retreat.Location ?? "N/A";
            txtRetreatDates.Text = $"{retreat.StartDate:MM/dd/yyyy} to {retreat.EndDate:MM/dd/yyyy}";
            txtRetreatPrice.Text = retreat.Price.ToString("C");
            lblDiscriptionName.Text = retreat.RetreatName; // Set the label text

           // Access current bookings directly from the retreat object
            int currentBookings = retreat.currentBookings ?? 0; // Safe handling of null
           Console.WriteLine($"Current Bookings After Fetch: {currentBookings}");

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
                Console.WriteLine($"Initial - CurrentBookings: {currentBookings}");

                // Calculate new bookings
                int newTotalBookings = currentBookings + numberOfSpaces;
                Console.WriteLine($"Total Bookings After Adding: {newTotalBookings} (Adding: {numberOfSpaces})");

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
                    Console.WriteLine("Database updated successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving to database: {ex.Message}");
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
                    byte[] imageBytes = Convert.FromBase64String(imageUrl);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image retreatImage = Image.FromStream(ms);
                        pbRetreat.Image = retreatImage; // Set the decoded image into the PictureBox
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid image format: " + ex.Message);
                    pbRetreat.Image = null; // Fallback to a default image
                }
                catch (Exception ex) // Catch other potential exceptions
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
            else
            {
                pbRetreat.Image = null; // Set a default image
            }
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

                // Hide the current form (UserDash or relevant form)
                this.Hide(); // Hide the current form until the booking is complete

                // Optionally handle the closing of the booking form to show the user dashboard again
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

        private void lblRetreatDetails_Load(object sender, EventArgs e)
        {
            
        }
    }
}