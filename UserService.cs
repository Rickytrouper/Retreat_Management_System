using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Retreat_Management_System
{
    public static class CurrentUser
    {
        public static int UserId { get; set; }
        public static string Role { get; set; }
        public static string FullName { get; set; } // Optional for full name management
    }

    public class UserService
    {
        private readonly Retreat_Management_DBEntities retreatManagementDbEntities;

        public UserService()
        {
            retreatManagementDbEntities = new Retreat_Management_DBEntities();
        }

        // Method to validate user credentials
        public User ValidateUser(string userName, string password)
        {
            var user = retreatManagementDbEntities.Users
                .FirstOrDefault(u => u.Username.Equals(userName, StringComparison.OrdinalIgnoreCase));

            if (user != null && VerifyPassword(password, user.Password))
            {
                // User authenticated; update the current user
                CurrentUser.UserId = user.UserID;
                CurrentUser.Role = user.Role;
                CurrentUser.FullName = $"{user.FirstName} {user.LastName}"; // Optional full name
                UpdateLastLogin(user.UserID); // Update last login on successful login
                return user;
            }

            return null; // Invalid username/password
        }

        // Method to verify hashed password
        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword; // Compare hashed values
        }

        // Method to get user details by user ID
        public User GetUserDetails(int userId)
        {
            return retreatManagementDbEntities.Users.Find(userId);
        }

        // Method to update LastLogin for a user
        public void UpdateLastLogin(int userId)
        {
            var user = retreatManagementDbEntities.Users.Find(userId);
            if (user != null)
            {
                user.LastLogin = DateTime.Now;
                retreatManagementDbEntities.SaveChanges();
            }
        }

        // Method to hash passwords
        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        // Method to get the current user's ID
        public int GetCurrentUserId()
        {
            return CurrentUser.UserId;
        }
    }
}