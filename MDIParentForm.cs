using System;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class MDIParentForm : Form
    {
        private readonly int currentUserID;
        private readonly string currentUserRole;

        // Constructor for MDIParentForm with userID, userRole, and full name
        public MDIParentForm(int userID, string userRole, string fullName)
        {
            InitializeComponent(); // Initialize components
            currentUserID = userID;
            currentUserRole = userRole;

            // Based on the userRole, show the appropriate initial content
            CreateDashboards(fullName);
        }

        private void CreateDashboards(string fullName)
        {
            if (currentUserRole == "Admin")
            {
                AdminDash adminDash = new AdminDash(currentUserID, fullName); // Pass full name
                adminDash.MdiParent = this;
                adminDash.Show();
            }
            else if (currentUserRole == "Organizer")
            {
                OrganizerDash organizerDash = new OrganizerDash(currentUserID, fullName); // Pass full name
                organizerDash.MdiParent = this;
                organizerDash.Show();
            }
            else if (currentUserRole == "User")
            {
                UserDash userDash = new UserDash(currentUserID, fullName); // Pass full name
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
            // Optional: add confirmation dialog before exit
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
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