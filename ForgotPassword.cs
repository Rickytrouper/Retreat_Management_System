using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            lbMessage.Visible = false; // Initially hide the message label
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email and simulate sending password reset
            bool emailSentSuccess = ValidateAndSendPasswordReset(email);
            if (emailSentSuccess)
            {
                lbMessage.Text = "A password reset link has been sent to your email.";
                lbMessage.ForeColor = System.Drawing.Color.Green; // Set label color to green for success
            }
            else
            {
                lbMessage.Text = "Email not found or failed to send email. Please try again.";
                lbMessage.ForeColor = System.Drawing.Color.Red; // Set label color to red for failure
            }
            lbMessage.Visible = true; // Show the message label
        }

        private bool ValidateAndSendPasswordReset(string email)
        {
            using (var context = new Retreat_Management_DBEntities()) 
            {
                // Check if the email exists in the database
                var user = context.Users.FirstOrDefault(q => q.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
                if (user != null)
                {
                    // Email exists— generate password reset link and send email
                    string resetLink = GeneratePasswordResetLink(user); // Generate a reset link
                    return SendPasswordResetEmail(email, resetLink); // Attempt to send email
                }
                else
                {
                    // Email does not exist in the database
                    return false;
                }
            }
        }

        // Method to generate password reset link
        private string GeneratePasswordResetLink(User user)
        {
            // This should generate a token and create a URL for the user to reset their password
            string token = Guid.NewGuid().ToString(); // Simulate token generation
                                                      // In production, consider adding the token to your database with expiration time
            return $"https://example.com/reset-password?token={token}&email={user.Email}"; // Replace with your actual URL
        }

        // Method to send password reset email
                   private bool SendPasswordResetEmail(string email, string resetLink)
        {
            // Simulate email sending. In a real application, you'd deal with actual SMTP sending logic.
            try
            {
                // Instead of using SmtpClient, we will just simulate success.
                Console.WriteLine($"Simulated email sent to: {email}");
                Console.WriteLine($"Reset link: {resetLink}");

                // Simulating a success response for testing purposes
                return true; // Simulate that the email has been sent successfully
            }
            catch (Exception ex)
            {
                // Log the error if it were to occur (though it won't in this simulated scenario)
                Console.WriteLine($"Error in simulated sending: {ex.Message}");
                return false; // Indicate failure, but this won't be hit in this simulation
            }
        }
        

        // Event handler for the Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
}