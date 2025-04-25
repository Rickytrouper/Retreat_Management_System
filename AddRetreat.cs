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
    public partial class AddRetreat: Form
    {
        private EditRetreats.Retreat selectedRetreat;

        public AddRetreat()
        {
            InitializeComponent();
        }

        public AddRetreat(EditRetreats.Retreat selectedRetreat)
        {
            this.selectedRetreat = selectedRetreat;
        }

        private void lbRetreatName_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRetreatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select Retreat Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Handle the selected file here
                string selectedFile = openFileDialog.FileName;
                // You might want to display the selected file name or preview the image
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
