﻿using System;
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
    public partial class ReviewPage : Form
    {
        private readonly int _currentUserId;
        private readonly int _retreatId;

        public ReviewPage(int currentUserId, int retreatId = -1) // -1 indicates no retreat
        {
            InitializeComponent();
            _currentUserId = currentUserId;
            _retreatId = retreatId;

            LoadFeedback();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void LoadFeedback()
        {
            try
            {
                using (var context = new Retreat_Management_DBEntities())
                {
                    // Check if feedback already exists for this user (for any retreat)
                    var existingFeedback = context.Feedbacks
                        .Where(f => f.UserID == _currentUserId)
                        .OrderByDescending(f => f.DateSubmitted) // Order by date, newest first
                        .FirstOrDefault(); // Get the most recent

                    if (existingFeedback != null)
                    {
                        // Populate the controls with the existing feedback
                        cbRatingSlection.Text = existingFeedback.Rating.ToString(); // Use Text property for ComboBox
                        rtbComment.Text = existingFeedback.Comments;
                    }
                    else
                    {
                        // Clear the controls if no feedback exists
                        cbRatingSlection.SelectedIndex = -1; // Clear selection
                        rtbComment.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}