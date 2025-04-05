using System;
using System.Linq;
using System.Data.Entity;


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
    }
}
