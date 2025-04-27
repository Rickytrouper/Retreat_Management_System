using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Retreat_Management_System
{
    public static class CurrentUser
    {
        public static int UserId { get; set; }
        public static string Role { get; set; } // Optional for role management
    }

    public class UserService
    {
        private readonly Retreat_Management_DBEntities retreat_Management_DBEntities;

        public UserService()
        {
            retreat_Management_DBEntities = new Retreat_Management_DBEntities();
        }

        // Method to validate user credentials
        public User ValidateUser(string userName, string password)
        {
            var user = retreat_Management_DBEntities.Users
                .FirstOrDefault(u => u.Username.Equals(userName, StringComparison.OrdinalIgnoreCase));

            if (user != null)
            {
                if (user.Password == password) // Plain text check
                {
                    user.Password = HashPassword(password); // Hash and update
                    retreat_Management_DBEntities.SaveChanges();
                }
                else if (user.Password != HashPassword(password)) // Hash check
                {
                    return null; // Invalid password
                }

                // Set current user information
                CurrentUser.UserId = user.UserID;
                CurrentUser.Role = user.Role; // Set the user's role
                return user; // Return user if found and valid
            }

            return null; // User not found
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
                    user.LastLogin = DateTime.Now; // Update LastLogin time
                    context.SaveChanges(); // Save changes
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

        // Method to get the current user's ID
        public int GetCurrentUserId()
        {
            return CurrentUser.UserId; // Return the current user's ID
        }
    }
}