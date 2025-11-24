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
        private string username; // Store the username

        public lblRetreatDetails(int userId, string username)
        {
            InitializeComponent();
            this.Load += RetreatDetails_Load;
            cbRetreatName.SelectedIndexChanged += cbRetreatName_SelectedIndexChanged;
            retreat_Management_DBEntities = new Retreat_Management_DBEntities();
            currentUserId = userId; // Store the user ID
            this.username = username; // Store the username
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
            if (cbRetreatName.SelectedItem != null)
            {
                var selectedRetreat = cbRetreatName.SelectedItem as Retreat;

                if (selectedRetreat != null)
                {
                    PopulateRetreatDetails(selectedRetreat);
                }
                else
                {
                    MessageBox.Show("Selected retreat is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Please select a retreat.");
            }
        }

        private void PopulateRetreatDetails(Retreat selectedRetreat)
        {
            txtDescription.Text = selectedRetreat.Description ?? "N/A";
            txtLocation.Text = selectedRetreat.Location ?? "N/A";
            txtRetreatDates.Text = $"{selectedRetreat.StartDate:MM/dd/yyyy} to {selectedRetreat.EndDate:MM/dd/yyyy}";
            txtRetreatPrice.Text = selectedRetreat.Price.ToString("C");
            lblDiscriptionName.Text = selectedRetreat.RetreatName;

            if (!string.IsNullOrEmpty(selectedRetreat.ImageURL))
            {
                try
                {
                    if (IsValidBase64String(selectedRetreat.ImageURL))
                    {
                        byte[] imageBytes = Convert.FromBase64String(selectedRetreat.ImageURL);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image retreatImage = Image.FromStream(ms);
                            pbRetreat.Image = retreatImage;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Image format is invalid.");
                        pbRetreat.Image = null; // Clear the image if invalid
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                    pbRetreat.Image = null; // Clear the image in case of error
                }
            }
            else
            {
                pbRetreat.Image = null; // Clear the image if no URL is provided
            }
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            if (cbRetreatName.SelectedItem is Retreat selectedRetreat)
            {
                int retreatId = selectedRetreat.RetreatID;
                decimal price = selectedRetreat.Price;
                OpenBookingPage(selectedRetreat, retreatId, price);
            }
            else
            {
                MessageBox.Show("Please select a retreat first.");
            }
        }

        private void OpenBookingPage(Retreat selectedRetreat, int retreatId, decimal price)
        {
            var bookingPage = new BookingPage(currentUserId, retreatId, price);
            bookingPage.SetRetreatName(selectedRetreat.RetreatName);

            UserService userService = new UserService();
            var user = userService.GetUserDetails(currentUserId);
            if (user != null)
            {
                bookingPage.SetUserName(user.Username);
                bookingPage.SetEmail(user.Email);
            }

            bookingPage.ShowDialog();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to return to the dashboard?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
                UserDash userDash = new UserDash(currentUserId, username);
                userDash.Show();
            }
        }

        private void lblRetreatDetails_Load(object sender, EventArgs e) { }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            LoginPage.PerformLogout();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e) { }

        private bool IsValidBase64String(string base64)
        {
            // Validate Base64 string
            return !string.IsNullOrWhiteSpace(base64) &&
                   (base64.Length % 4 == 0) &&
                   base64.All(c => char.IsLetterOrDigit(c) || c == '+' || c == '/' || c == '=');
        }
    }
}