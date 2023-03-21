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
            this.buttonFavoritePhoto = new System.Windows.Forms.Button();
            this.buttonLeastFavoritePhoto = new System.Windows.Forms.Button();
            this.buttonAvaragePhoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFavoritePhoto
            // 
            this.buttonFavoritePhoto.Location = new System.Drawing.Point(12, 117);
            this.buttonFavoritePhoto.Name = "buttonFavoritePhoto";
            this.buttonFavoritePhoto.Size = new System.Drawing.Size(135, 23);
            this.buttonFavoritePhoto.TabIndex = 0;
            this.buttonFavoritePhoto.Text = "Favorite photo";
            this.buttonFavoritePhoto.UseVisualStyleBackColor = true;
            this.buttonFavoritePhoto.Click += new System.EventHandler(this.buttonFavoritePhoto_Click);
            // 
            // buttonLeastFavoritePhoto
            // 
            this.buttonLeastFavoritePhoto.Location = new System.Drawing.Point(662, 117);
            this.buttonLeastFavoritePhoto.Name = "buttonLeastFavoritePhoto";
            this.buttonLeastFavoritePhoto.Size = new System.Drawing.Size(135, 23);
            this.buttonLeastFavoritePhoto.TabIndex = 1;
            this.buttonLeastFavoritePhoto.Text = "Least favorite photo";
            this.buttonLeastFavoritePhoto.UseVisualStyleBackColor = true;
            this.buttonLeastFavoritePhoto.Click += new System.EventHandler(this.buttonLeastFavoritePhoto_Click);
            // 
            // buttonAvaragePhoto
            // 
            this.buttonAvaragePhoto.Location = new System.Drawing.Point(332, 117);
            this.buttonAvaragePhoto.Name = "buttonAvaragePhoto";
            this.buttonAvaragePhoto.Size = new System.Drawing.Size(135, 23);
            this.buttonAvaragePhoto.TabIndex = 2;
            this.buttonAvaragePhoto.Text = "Avarage photo";
            this.buttonAvaragePhoto.UseVisualStyleBackColor = true;
            this.buttonAvaragePhoto.Click += new System.EventHandler(this.buttonAvaragePhoto_Click);
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAvaragePhoto);
            this.Controls.Add(this.buttonLeastFavoritePhoto);
            this.Controls.Add(this.buttonFavoritePhoto);
            this.Name = "FormFriends";
            this.Text = "FormFriends";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFavoritePhoto;
        private System.Windows.Forms.Button buttonLeastFavoritePhoto;
        private System.Windows.Forms.Button buttonAvaragePhoto;
    }
}