using System;
using System.Collections.Generic;
using Retreat_Management_System;

public partial class Admin
{
    // Primary key (also serves as UserID)
    public int UserID { get; set; } // This is the ID for the admin user

    // Admin username
    public string Username { get; set; }

    // Admin password (consider using a secure method for handling passwords)
    public string Password { get; set; }

    // Additional properties can be added here, for example:
    public string Email { get; set; } // Example of an additional property
    public DateTime CreatedAt { get; set; } // Track when the admin was created
    public bool IsActive { get; set; } // Indicates if the admin account is active

    // Navigation property
    public virtual ICollection<AdminAction> AdminActions { get; set; } // Actions performed by the admin

    // Constructor
    public Admin()
    {
        AdminActions = new HashSet<AdminAction>(); // Initialize the collection
        CreatedAt = DateTime.Now; // Initialize CreatedAt to the current date/time
        IsActive = true; // Default value for IsActive
    }
}