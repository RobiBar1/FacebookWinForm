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
            this.buttonFavoritePhoto.Location = new System.Drawing.Point(12, 43);
            this.buttonFavoritePhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFavoritePhoto.Name = "buttonFavoritePhoto";
            this.buttonFavoritePhoto.Size = new System.Drawing.Size(152, 29);
            this.buttonFavoritePhoto.TabIndex = 0;
            this.buttonFavoritePhoto.Text = "Favorite Photo";
            this.buttonFavoritePhoto.UseVisualStyleBackColor = true;
            this.buttonFavoritePhoto.Click += new System.EventHandler(this.buttonFavoritePhoto_Click);
            // 
            // buttonLeastFavoritePhoto
            // 
            this.buttonLeastFavoritePhoto.Location = new System.Drawing.Point(12, 192);
            this.buttonLeastFavoritePhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLeastFavoritePhoto.Name = "buttonLeastFavoritePhoto";
            this.buttonLeastFavoritePhoto.Size = new System.Drawing.Size(152, 52);
            this.buttonLeastFavoritePhoto.TabIndex = 1;
            this.buttonLeastFavoritePhoto.Text = "Least favorite photo";
            this.buttonLeastFavoritePhoto.UseVisualStyleBackColor = true;
            this.buttonLeastFavoritePhoto.Click += new System.EventHandler(this.buttonLeastFavoritePhoto_Click);
            // 
            // buttonAveragePhoto
            // 
            this.buttonAveragePhoto.Location = new System.Drawing.Point(12, 112);
            this.buttonAveragePhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAveragePhoto.Name = "buttonAveragePhoto";
            this.buttonAveragePhoto.Size = new System.Drawing.Size(152, 29);
            this.buttonAveragePhoto.TabIndex = 2;
            this.buttonAveragePhoto.Text = "Average Photo";
            this.buttonAveragePhoto.UseVisualStyleBackColor = true;
            this.buttonAveragePhoto.Click += new System.EventHandler(this.buttonAveragePhoto_Click);
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 421);
            this.Controls.Add(this.buttonAveragePhoto);
            this.Controls.Add(this.buttonLeastFavoritePhoto);
            this.Controls.Add(this.buttonFavoritePhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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