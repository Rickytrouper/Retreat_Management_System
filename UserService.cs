using System;
using System.Linq;
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
            // Optionally hash the password here for security
            var user = retreat_Management_DBEntities.Users
                .FirstOrDefault(u => u.Username.Equals(userName, StringComparison.OrdinalIgnoreCase)
                                     && u.Password == password); // Use hashed passwords in production

            return user; // Returns the user if found, otherwise null
        }

        // Method to get user details by user ID
        public User GetUserDetails(int userId)
        {
            return retreat_Management_DBEntities.Users.Find(userId); // Fetch user by ID
        }

        // Login method to validate user and update LastLogin
        public bool Login(string username, string password)
        {
            using (var context = new Retreat_Management_DBEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    // Update LastLogin time
                    user.LastLogin = DateTime.Now;
                    context.SaveChanges(); // Save changes to update LastLogin
                                        
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    return false;
                }
            }
        }
    }
}
