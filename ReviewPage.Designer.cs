namespace Retreat_Management_System
{
    partial class ReviewPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbReview = new System.Windows.Forms.Label();
            this.cbRatingSlection = new System.Windows.Forms.ComboBox();
            this.lbRatings = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbcomment = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbReview
            // 
            this.lbReview.AutoSize = true;
            this.lbReview.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReview.Location = new System.Drawing.Point(374, 91);
            this.lbReview.Name = "lbReview";
            this.lbReview.Size = new System.Drawing.Size(199, 32);
            this.lbReview.TabIndex = 0;
            this.lbReview.Text = "Client\'s Review";
            // 
            // cbRatingSlection
            // 
            this.cbRatingSlection.FormattingEnabled = true;
            this.cbRatingSlection.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRatingSlection.Location = new System.Drawing.Point(210, 205);
            this.cbRatingSlection.Name = "cbRatingSlection";
            this.cbRatingSlection.Size = new System.Drawing.Size(61, 21);
            this.cbRatingSlection.TabIndex = 1;
            // 
            // lbRatings
            // 
            this.lbRatings.AutoSize = true;
            this.lbRatings.Location = new System.Drawing.Point(207, 189);
            this.lbRatings.Name = "lbRatings";
            this.lbRatings.Size = new System.Drawing.Size(43, 13);
            this.lbRatings.TabIndex = 2;
            this.lbRatings.Text = "Ratings";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(210, 310);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(546, 168);
            this.rtbComment.TabIndex = 3;
            this.rtbComment.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Select  ratings 1 been lowest , been highest";         
            // 
            // lbcomment
            // 
            this.lbcomment.AutoSize = true;
            this.lbcomment.Location = new System.Drawing.Point(207, 294);
            this.lbcomment.Name = "lbcomment";
            this.lbcomment.Size = new System.Drawing.Size(51, 13);
            this.lbcomment.TabIndex = 5;
            this.lbcomment.Text = "Comment";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(681, 532);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ReviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbcomment);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.lbRatings);
            this.Controls.Add(this.cbRatingSlection);
            this.Controls.Add(this.lbReview);
            this.Name = "ReviewPage";
            this.Text = "ReviewPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReview;
        private System.Windows.Forms.ComboBox cbRatingSlection;
        private System.Windows.Forms.Label lbRatings;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbcomment;
        private System.Windows.Forms.Button btnSubmit;
    }
}