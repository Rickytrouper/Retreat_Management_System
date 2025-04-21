using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Retreat_Management_System;

public partial class User
{
    public User()
    {
        this.AdminActions = new HashSet<AdminAction>();
        this.Bookings = new HashSet<Booking>();
        this.Feedbacks = new HashSet<Feedback>();
        this.Notifications = new HashSet<Notification>();
        this.Retreats = new HashSet<Retreat>();
    }

    public int UserID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ProfilePicture { get; set; }
    public string ContactInfo { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? LastLogin { get; set; } // Nullable to allow for users who haven't logged in yet
    public string AccountStatus { get; set; }

    public virtual ICollection<AdminAction> AdminActions { get; set; }
    public virtual ICollection<Booking> Bookings { get; set; }
    public virtual ICollection<Feedback> Feedbacks { get; set; }
    public virtual ICollection<Notification> Notifications { get; set; }
    public virtual ICollection<Retreat> Retreats { get; set; }
}
