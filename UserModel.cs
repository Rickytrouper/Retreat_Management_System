using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Retreat_Management_System
{
    public class UserModel
    {
        [Key] // Indicates the property is the primary key
        public int UserID { get; set; } // Primary Key

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        public string UserName { get; set; } // Username

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        public string Password { get; set; } // Password (hashed in production)

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } // User's email

        [StringLength(20, ErrorMessage = "Role cannot exceed 20 characters.")]
        public string Role { get; set; } // User Role (e.g., Admin, User, Organizer)

        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        public string FirstName { get; set; } // First Name

        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        public string LastName { get; set; } // Last Name

        public string ProfilePicture { get; set; } // Path to Profile Picture

        [StringLength(12, ErrorMessage = "Contact information cannot exceed 12 characters.")]
        public string ContactInfo { get; set; } // Contact Information

        public DateTime DateCreated { get; set; } // Timestamp for when the user was created

        public DateTime? LastLogin { get; set; } // Nullable timestamp for last login (can be null if never logged in)
        
        public bool IsActive { get; set; } // Indicates if the user is active or inactive

    }
}