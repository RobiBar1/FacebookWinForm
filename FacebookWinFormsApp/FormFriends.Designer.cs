using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriends));
            this.buttonFavoritePhoto = new System.Windows.Forms.Button();
            this.buttonLeastFavoritePhoto = new System.Windows.Forms.Button();
            this.buttonAveragePhoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFavoritePhoto
            // 
            this.buttonFavoritePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFavoritePhoto.Location = new System.Drawing.Point(8, 28);
            this.buttonFavoritePhoto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonFavoritePhoto.Name = "buttonFavoritePhoto";
            this.buttonFavoritePhoto.Size = new System.Drawing.Size(101, 29);
            this.buttonFavoritePhoto.TabIndex = 0;
            this.buttonFavoritePhoto.Text = "Favorite Photo";
            this.buttonFavoritePhoto.UseVisualStyleBackColor = true;
            this.buttonFavoritePhoto.Click += new System.EventHandler(this.buttonFavoritePhoto_Click);
            // 
            // buttonLeastFavoritePhoto
            // 
            this.buttonLeastFavoritePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLeastFavoritePhoto.Location = new System.Drawing.Point(8, 157);
            this.buttonLeastFavoritePhoto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonLeastFavoritePhoto.Name = "buttonLeastFavoritePhoto";
            this.buttonLeastFavoritePhoto.Size = new System.Drawing.Size(101, 45);
            this.buttonLeastFavoritePhoto.TabIndex = 1;
            this.buttonLeastFavoritePhoto.Text = "Least favorite photo";
            this.buttonLeastFavoritePhoto.UseVisualStyleBackColor = true;
            this.buttonLeastFavoritePhoto.Click += new System.EventHandler(this.buttonLeastFavoritePhoto_Click);
            // 
            // buttonAveragePhoto
            // 
            this.buttonAveragePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAveragePhoto.Location = new System.Drawing.Point(8, 96);
            this.buttonAveragePhoto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAveragePhoto.Name = "buttonAveragePhoto";
            this.buttonAveragePhoto.Size = new System.Drawing.Size(101, 27);
            this.buttonAveragePhoto.TabIndex = 2;
            this.buttonAveragePhoto.Text = "Average Photo";
            this.buttonAveragePhoto.UseVisualStyleBackColor = true;
            this.buttonAveragePhoto.Click += new System.EventHandler(this.buttonAveragePhoto_Click);
            // 
            // FormFriends
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 274);
            this.Controls.Add(this.buttonAveragePhoto);
            this.Controls.Add(this.buttonLeastFavoritePhoto);
            this.Controls.Add(this.buttonFavoritePhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormFriends";
            this.Text = "Popularity Analysis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFavoritePhoto;
        private System.Windows.Forms.Button buttonLeastFavoritePhoto;
        private System.Windows.Forms.Button buttonAveragePhoto;
    }
}