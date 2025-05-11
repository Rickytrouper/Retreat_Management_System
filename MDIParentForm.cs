using System;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class MDIParentForm : Form
    {
        private readonly int currentUserID;
        private readonly string currentUserRole;

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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open AboutPage
            AboutPage aboutPage = new AboutPage(currentUserID); // Use currentUserID
            aboutPage.MdiParent = this; // Set the MDI parent
            aboutPage.Show();
        }

        
    }
}