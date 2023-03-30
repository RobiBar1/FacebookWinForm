using BasicFacebookFeatures.Properties;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.postTiming = new System.Windows.Forms.Button();
            this.buttonMyBestFriends = new System.Windows.Forms.Button();
            this.buttonActivityStatics = new System.Windows.Forms.Button();
            this.buttonBasicUserDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(16, 14);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(204, 39);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.Location = new System.Drawing.Point(16, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(204, 50);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 22);
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
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 14);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(107, 121);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 41;
            this.pictureBoxProfile.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBirthday);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Controls.Add(this.labelFirstName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Location = new System.Drawing.Point(311, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 154);
            this.panel1.TabIndex = 58;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthday.Location = new System.Drawing.Point(245, 107);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(59, 20);
            this.labelBirthday.TabIndex = 47;
            this.labelBirthday.Text = "label6";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBirthday.Visible = false;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLastName.Location = new System.Drawing.Point(245, 60);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 20);
            this.labelLastName.TabIndex = 46;
            this.labelLastName.Text = "label5";
            this.labelLastName.Visible = false;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFirstName.Location = new System.Drawing.Point(245, 14);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(59, 20);
            this.labelFirstName.TabIndex = 45;
            this.labelFirstName.Text = "label4";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFirstName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(137, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Birthday :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(135, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(135, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "First Name :";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(16, 112);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(141, 24);
            this.checkBoxRememberMe.TabIndex = 61;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // postTiming
            // 
            this.postTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postTiming.Location = new System.Drawing.Point(16, 370);
            this.postTiming.Margin = new System.Windows.Forms.Padding(4);
            this.postTiming.Name = "postTiming";
            this.postTiming.Size = new System.Drawing.Size(204, 37);
            this.postTiming.TabIndex = 62;
            this.postTiming.Text = "Post timing";
            this.postTiming.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.postTiming.UseVisualStyleBackColor = true;
            this.postTiming.Click += new System.EventHandler(this.postTiming_Click);
            // 
            // buttonMyBestFriends
            // 
            this.buttonMyBestFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMyBestFriends.Location = new System.Drawing.Point(16, 174);
            this.buttonMyBestFriends.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMyBestFriends.Name = "buttonMyBestFriends";
            this.buttonMyBestFriends.Size = new System.Drawing.Size(204, 30);
            this.buttonMyBestFriends.TabIndex = 69;
            this.buttonMyBestFriends.Text = "My Best Friends";
            this.buttonMyBestFriends.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMyBestFriends.UseVisualStyleBackColor = true;
            this.buttonMyBestFriends.Click += new System.EventHandler(this.buttonMyBestFriends_Click);
            // 
            // buttonActivityStatics
            // 
            this.buttonActivityStatics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonActivityStatics.Location = new System.Drawing.Point(20, 229);
            this.buttonActivityStatics.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActivityStatics.Name = "buttonActivityStatics";
            this.buttonActivityStatics.Size = new System.Drawing.Size(200, 28);
            this.buttonActivityStatics.TabIndex = 70;
            this.buttonActivityStatics.Text = "Activity statics";
            this.buttonActivityStatics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonActivityStatics.UseVisualStyleBackColor = true;
            this.buttonActivityStatics.Click += new System.EventHandler(this.buttonActivityStatics_Click);
            // 
            // buttonBasicUserDetails
            // 
            this.buttonBasicUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBasicUserDetails.Location = new System.Drawing.Point(16, 293);
            this.buttonBasicUserDetails.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBasicUserDetails.Name = "buttonBasicUserDetails";
            this.buttonBasicUserDetails.Size = new System.Drawing.Size(204, 28);
            this.buttonBasicUserDetails.TabIndex = 71;
            this.buttonBasicUserDetails.Text = "Basic User Details";
            this.buttonBasicUserDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBasicUserDetails.UseVisualStyleBackColor = true;
            this.buttonBasicUserDetails.Click += new System.EventHandler(this.buttonBasicUserDetails_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 514);
            this.Controls.Add(this.buttonBasicUserDetails);
            this.Controls.Add(this.buttonActivityStatics);
            this.Controls.Add(this.buttonMyBestFriends);
            this.Controls.Add(this.postTiming);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxProfile ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Button postTiming;
        private System.Windows.Forms.Button buttonMyBestFriends;
        private System.Windows.Forms.Button buttonActivityStatics;
        private System.Windows.Forms.Button buttonBasicUserDetails;
    }
}

