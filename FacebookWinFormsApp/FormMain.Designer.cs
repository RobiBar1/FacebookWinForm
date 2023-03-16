namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.ListBox_Album = new System.Windows.Forms.ListBox();
            this.button_Albums = new System.Windows.Forms.Button();
            this.button_Events = new System.Windows.Forms.Button();
            this.ListBox_Events = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 41);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(179, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatus.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(610, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(178, 107);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 41;
            this.pictureBoxProfile.TabStop = false;
            // 
            // ListBox_Album
            // 
            this.ListBox_Album.FormattingEnabled = true;
            this.ListBox_Album.Location = new System.Drawing.Point(12, 168);
            this.ListBox_Album.Name = "ListBox_Album";
            this.ListBox_Album.Size = new System.Drawing.Size(249, 147);
            this.ListBox_Album.TabIndex = 54;
            this.ListBox_Album.SelectedIndexChanged += new System.EventHandler(this.ListBox_Album_Clicked);
            // 
            // button_Albums
            // 
            this.button_Albums.Location = new System.Drawing.Point(12, 138);
            this.button_Albums.Name = "button_Albums";
            this.button_Albums.Size = new System.Drawing.Size(75, 23);
            this.button_Albums.TabIndex = 55;
            this.button_Albums.Text = "View albums";
            this.button_Albums.UseVisualStyleBackColor = true;
            this.button_Albums.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Events
            // 
            this.button_Events.Location = new System.Drawing.Point(315, 137);
            this.button_Events.Name = "button_Events";
            this.button_Events.Size = new System.Drawing.Size(75, 23);
            this.button_Events.TabIndex = 56;
            this.button_Events.Text = "View events";
            this.button_Events.UseVisualStyleBackColor = true;
            this.button_Events.Click += new System.EventHandler(this.button_Events_Click);
            // 
            // ListBox_Events
            // 
            this.ListBox_Events.FormattingEnabled = true;
            this.ListBox_Events.Location = new System.Drawing.Point(315, 168);
            this.ListBox_Events.Name = "ListBox_Events";
            this.ListBox_Events.Size = new System.Drawing.Size(218, 147);
            this.ListBox_Events.TabIndex = 57;
            this.ListBox_Events.SelectedIndexChanged += new System.EventHandler(this.ListBox_Events_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 657);
            this.Controls.Add(this.ListBox_Events);
            this.Controls.Add(this.button_Events);
            this.Controls.Add(this.button_Albums);
            this.Controls.Add(this.ListBox_Album);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxProfile ;
        private System.Windows.Forms.ListBox ListBox_Album;
        private System.Windows.Forms.Button button_Albums;
        private System.Windows.Forms.Button button_Events;
        private System.Windows.Forms.ListBox ListBox_Events;
    }
}

