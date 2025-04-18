using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Retreat_Management_System
{



    public partial class RetreatDetails : Form
    {



        private readonly Retreat_Management_DBEntities retreatManagementEntities;





        public RetreatDetails()
        {
            InitializeComponent();
            this.Load += RetreatDetails_Load;
            cbRetreatName.SelectedIndexChanged += cbRetreatName_SelectedIndexChanged;
            retreatManagementEntities = new Retreat_Management_DBEntities();
            //this.btnBackToDashboard.Click += new System.EventHandler(this.btnBackToDashboard_Click);
        }

        private void RetreatDetails_Load(object sender, EventArgs e)
        {
            var Retreat = retreatManagementEntities.Retreats.ToList();
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
                        // If no image, display a placeholder or a default image
                        pbRetreat.Image = null;  // Or set a default image
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
                var bookingPage = new BookingPage();
                bookingPage.SetRetreatName(selectedRetreat.RetreatName); // Send the retreat name
                this.Hide();  // Hide the RetreatDetails form
                bookingPage.FormClosed += (s, args) => this.Show();  // Show it again when booking closes
                bookingPage.Show();
            }
            else
            {
                MessageBox.Show("Please select a retreat first.");
            }
            //var bookingPage = new BookingPage();
            //bookingPage.Show();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to return to the dashboard", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                
                //Close();
                
                this.Hide();
                var dashboard = new UserDash();
                dashboard.Show();

            }
        }
    }



}