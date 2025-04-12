using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retreat_Management_System
{
    public partial class AboutPage: Form
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {
            // open in parent form
            this.Owner = this.Owner;
            this.StartPosition = FormStartPosition.CenterParent; // Center the form
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Make the form non-resizable
            this.MaximizeBox = false; // Disable maximize button
            this.MinimizeBox = false; // Disable minimize button
            this.ControlBox = false; // Disable close button
            this.ShowInTaskbar = false; // Hide from taskbar
            this.BackColor = Color.LightBlue; // Set background color
            this.Text = "About Us"; // Set form title
            //this.label1.Text = "Retreat Management System"; // Set label text
           // this.label2.Text = "Version 1.0"; // Set version text
           // this.label3.Text = "Developed by: Your Name"; // Set developer name

        }
    }
}
