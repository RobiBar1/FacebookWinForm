namespace BasicFacebookFeatures
{
    partial class FormPostTiming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostTiming));
            this.userHours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userPost = new System.Windows.Forms.TextBox();
            this.ButtonPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userHours
            // 
            this.userHours.Location = new System.Drawing.Point(296, 109);
            this.userHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userHours.Name = "userHours";
            this.userHours.Size = new System.Drawing.Size(141, 22);
            this.userHours.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(130, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Hours till upload :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(130, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Enter youre post :";
            // 
            // userPost
            // 
            this.userPost.Location = new System.Drawing.Point(296, 55);
            this.userPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPost.Name = "userPost";
            this.userPost.Size = new System.Drawing.Size(141, 22);
            this.userPost.TabIndex = 68;
            // 
            // ButtonPost
            // 
            this.ButtonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonPost.Location = new System.Drawing.Point(170, 175);
            this.ButtonPost.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPost.Name = "ButtonPost";
            this.ButtonPost.Size = new System.Drawing.Size(204, 37);
            this.ButtonPost.TabIndex = 67;
            this.ButtonPost.Text = "Submit your post";
            this.ButtonPost.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonPost.UseVisualStyleBackColor = true;
            this.ButtonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // FormPostTiming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 263);
            this.Controls.Add(this.userHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userPost);
            this.Controls.Add(this.ButtonPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPostTiming";
            this.Text = "FormPostTiming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userPost;
        private System.Windows.Forms.Button ButtonPost;
    }
}