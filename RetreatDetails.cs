using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Retreat_Management_System
{

    public partial class lblRetreatDetails : Form
    {

        private readonly Retreat_Management_DBEntities retreat_Management_DBEntities;
        private int currentUserId; // Store the user ID



        public lblRetreatDetails(int userId)
        {
            InitializeComponent();
            this.Load += RetreatDetails_Load;
            cbRetreatName.SelectedIndexChanged += cbRetreatName_SelectedIndexChanged;
            retreat_Management_DBEntities = new Retreat_Management_DBEntities();
            currentUserId = userId; // Store the user ID



        }

        private void RetreatDetails_Load(object sender, EventArgs e)
        {
            var Retreat = retreat_Management_DBEntities.Retreats.ToList();
            cbRetreatName.DisplayMember = "RetreatName";
            cbRetreatName.ValueMember = "ID";
            cbRetreatName.DataSource = Retreat;

        }
        private void cbRetreatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (cbRetreatName.SelectedItem != null)
            {
                // Get the selected retreat object from the ComboBox
                var selectedRetreat = cbRetreatName.SelectedItem as Retreat;

                if (selectedRetreat != null)
                {
                    // Populate the text fields with the retreat details
                    txtDescription.Text = selectedRetreat.Description ?? "N/A";
                    txtLocation.Text = selectedRetreat.Location ?? "N/A";
                    txtRetreatDates.Text = $"{selectedRetreat.StartDate:MM/dd/yyyy} to {selectedRetreat.EndDate:MM/dd/yyyy}";
                    txtRetreatPrice.Text = selectedRetreat.Price.ToString("C");

                    lblDiscriptionName.Text = selectedRetreat.RetreatName; // Set the label text

                    if (!string.IsNullOrEmpty(selectedRetreat.ImageURL))
                    {
                        try
                        {
                            // Decode the base64 string into a byte array
                            byte[] imageBytes = Convert.FromBase64String(selectedRetreat.ImageURL);

                            // Convert the byte array into an Image object
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image retreatImage = Image.FromStream(ms);

                                // Set the decoded image into the PictureBox
                                pbRetreat.Image = retreatImage;
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
                        pbRetreat.Image = null;  //set a default image
                    }
                }
                else
                {
                    MessageBox.Show("Selected retreat is invalid.");
                }
            }
            else
            {
                // Handle the case when nothing is selected
                MessageBox.Show("Please select a retreat.");
            }
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            if (cbRetreatName.SelectedItem is Retreat selectedRetreat)
            {
                int retreatId = selectedRetreat.RetreatID;
                decimal price = selectedRetreat.Price;

                // Create an instance of BookingPage with both userId and retreatId
                var bookingPage = new BookingPage(currentUserId, retreatId, price); // Pass the userId and retreatId

                // Set the retreat name
                bookingPage.SetRetreatName(selectedRetreat.RetreatName);

                // Create an instance of UserService to get user details
                UserService userService = new UserService();
                var user = userService.GetUserDetails(currentUserId); // Fetch user details

                // Check if the user is found and set the username and email
                if (user != null)
                {
                    bookingPage.SetUserName(user.Username); // Pass the username
                    bookingPage.SetEmail(user.Email); // Pass the email
                }

                // Make BookingPage a modal dialog
                bookingPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a retreat first.");
            }
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to return to the dashboard?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close(); // Close the current form, returning to UserDash
            }
        }
    }
}