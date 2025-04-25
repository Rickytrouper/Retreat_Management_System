using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public class AdminActionService
    {
        private readonly Retreat_Management_DBEntities context;
        private readonly List<string> validActionTypes;

        public AdminActionService()
        {
            context = new Retreat_Management_DBEntities();
            validActionTypes = new List<string>
            {                
                "Change User Status",
                "Edit User",
                "Add User",
                "Edit Retreat",
                "Add Retreat",
                "Add",
                "Edit",
                "Delete",
                "Open User Management"
            };
        }

        public bool IsValidActionType(string actionType)
        {
            return validActionTypes.Contains(actionType);
        }

        public void LogAdminAction(int adminId, string actionType, string targetEntity, string description)
        {
            try
            {
                using (var context = new Retreat_Management_DBEntities())
                {
                    var adminAction = new AdminAction
                    {
                        AdminID = adminId,
                        ActionType = actionType,
                        TargetEntity = targetEntity,
                        Description = description,
                        ActionDate = DateTime.Now
                    };

                    context.AdminActions.Add(adminAction);
                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(e => e.ValidationErrors)
                    .Select(v => v.ErrorMessage);
                var fullErrorMessage = string.Join(", ", errorMessages);
                MessageBox.Show($"Validation errors: {fullErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database update error: {dbEx.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateUserRole(int adminID, int userId, string newRole)
        {
            var user = context.Users.SingleOrDefault(u => u.UserID == userId);
            if (user != null)
            {
                user.Role = newRole;
                context.SaveChanges();
                // Log the action
                LogAdminAction(adminID, "Edit User", "User", $"User {user.Username} role changed to {newRole}");
            }
            else
            {
                throw new Exception("User not found.");
            }
        }

        public void ToggleUserStatus(int adminID, int userId)
        {
            var user = context.Users.SingleOrDefault(u => u.UserID == userId);
            if (user != null)
            {
                user.AccountStatus = user.AccountStatus == "Active" ? "Suspended" : "Active";
                context.SaveChanges();
                // Log the action
                LogAdminAction(adminID, "Change User Status", "User", $"User {user.Username} status changed to {user.AccountStatus}");
            }
            else
            {
                throw new Exception("User not found.");
            }
        }
    }
}