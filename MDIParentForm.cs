using System;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class MDIParentForm : Form
    {
        private readonly int currentUserID;
        private readonly string currentUserRole;
        private readonly int currentAdminID;

        public MDIParentForm(int userID, string userRole)
        {
            InitializeComponent();
            currentUserID = userID;
            currentUserRole = userRole;

            // Based on the userRole, show the appropriate initial content
            if (currentUserRole == "Admin")
            {
                // Create and show the AdminDash as an MDI child
                AdminDash adminDash = new AdminDash(currentUserID);
                adminDash.MdiParent = this;
                adminDash.Show();
            }
            else if (currentUserRole == "Organizer")
            {
                // Create and show the OrganizerDash as an MDI child
                OrganizerDash organizerDash = new OrganizerDash(currentUserID);
                organizerDash.MdiParent = this;
                organizerDash.Show();
            }
            else if (currentUserRole == "User")
            {
                // Create and show the UserDash as an MDI child
                UserDash userDash = new UserDash(currentUserID);
                userDash.MdiParent = this;
                userDash.Show();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tileHorizontalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open UserManagementForm
            UserManagementForm userManagementForm = new UserManagementForm(currentAdminID); // Assuming currentAdminID is accessible in this scope
            userManagementForm.MdiParent = this; // Set the MDI parent
            userManagementForm.Show();
        }

        private void retreatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open EditRetreatsForm (assuming this is the name of your form)
            EditRetreats editRetreatsForm = new EditRetreats(currentAdminID); // Instantiate the form
            editRetreatsForm.MdiParent = this; // Set the MDI parent
            editRetreatsForm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open ReportsForm (assuming this is the name of your form)
            Reports reportsForm = new Reports(currentAdminID); // Instantiate the form
            reportsForm.MdiParent = this; // Set the MDI parent
            reportsForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open AboutPage
            AboutPage aboutPage = new AboutPage(currentAdminID); // Assuming currentAdminID is needed
            aboutPage.MdiParent = this; // Set the MDI parent
            aboutPage.Show();
        }
    }
}