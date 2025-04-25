using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    class UserService
    {
        private readonly Retreat_Management_DBEntities retreat_Management_DBEntities;

        public UserService()
        {
            retreat_Management_DBEntities = new Retreat_Management_DBEntities();
        }

        public User ValidateUser(string userName, string password)
        {
            // Find user by username
            var user = retreat_Management_DBEntities.Users
                .FirstOrDefault(u => u.Username.Equals(userName, StringComparison.OrdinalIgnoreCase));

            // Check if user exists
            if (user != null)
            {
                // Check if the provided password matches the stored password
                if (user.Password == password) // Plain text check
                {
                    // Hash and update the password if it was stored in plain text
                    user.Password = HashPassword(password);
                    retreat_Management_DBEntities.SaveChanges();
                }
                else if (user.Password != HashPassword(password)) // Hash check
                {
                    return null; // Invalid password
                }

                return user; // Return user if found and password is valid
            }

            return null; // Return null if user is not found
        }

        // Method to get user details by user ID
        public User GetUserDetails(int userId)
        {
            return retreat_Management_DBEntities.Users.Find(userId); // Fetch user by ID
        }

        // Method to update LastLogin for a user
        public void UpdateLastLogin(int userId)
        {
            using (var context = new Retreat_Management_DBEntities())
            {
                var user = context.Users.Find(userId);
                if (user != null)
                {
                    user.LastLogin = DateTime.Now; // Update LastLogin to current time
                    context.SaveChanges(); // Save changes to the database
                }
            }
        }

        // Login method to validate user and update LastLogin
        public bool Login(string username, string password)
        {
            using (var context = new Retreat_Management_DBEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
                if (user != null)
                {
                    // Validate password
                    if (user.Password == password) // Plain text check
                    {
                        // Hash and update the password
                        user.Password = HashPassword(password);
                        context.SaveChanges(); // Save changes to update LastLogin and hash password
                    }
                    else if (user.Password != HashPassword(password)) // Hash check
                    {
                        MessageBox.Show("Invalid username or password.");
                        return false; // Invalid login
                    }

                    // Update LastLogin time
                    user.LastLogin = DateTime.Now;
                    context.SaveChanges(); // Save changes to update LastLogin

                    return true; // Successful login
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    return false; // Invalid login
                }
            }
        }

        // Method to hash passwords
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes); // Return hashed password
            }
        }
    }
}