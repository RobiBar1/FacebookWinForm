
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormBasicDetails
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBasicDetails));
            this.button_Albums = new System.Windows.Forms.Button();
            this.ListBox_Album = new System.Windows.Forms.ListBox();
            this.button_Events = new System.Windows.Forms.Button();
            this.ListBox_Events = new System.Windows.Forms.ListBox();
            this.LikedPages = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonViewPosts = new System.Windows.Forms.Button();
            this.listBoxViewPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Albums
            // 
            this.button_Albums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Albums.Location = new System.Drawing.Point(3, 22);
            this.button_Albums.Name = "button_Albums";
            this.button_Albums.Size = new System.Drawing.Size(142, 23);
            this.button_Albums.TabIndex = 56;
            this.button_Albums.Text = "View albums";
            this.button_Albums.UseVisualStyleBackColor = true;
            this.button_Albums.Click += new System.EventHandler(this.button_Albums_Click);
            // 
            // ListBox_Album
            // 
            this.ListBox_Album.FormattingEnabled = true;
            this.ListBox_Album.Location = new System.Drawing.Point(3, 60);
            this.ListBox_Album.Name = "ListBox_Album";
            this.ListBox_Album.Size = new System.Drawing.Size(142, 108);
            this.ListBox_Album.TabIndex = 57;
            // 
            // button_Events
            // 
            this.button_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Events.Location = new System.Drawing.Point(204, 22);
            this.button_Events.Name = "button_Events";
            this.button_Events.Size = new System.Drawing.Size(151, 23);
            this.button_Events.TabIndex = 58;
            this.button_Events.Text = "View events";
            this.button_Events.UseVisualStyleBackColor = true;
            this.button_Events.Click += new System.EventHandler(this.button_Events_Click);
            // 
            // ListBox_Events
            // 
            this.ListBox_Events.FormattingEnabled = true;
            this.ListBox_Events.Location = new System.Drawing.Point(204, 60);
            this.ListBox_Events.Name = "ListBox_Events";
            this.ListBox_Events.Size = new System.Drawing.Size(151, 108);
            this.ListBox_Events.TabIndex = 59;
            // 
            // LikedPages
            // 
            this.LikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LikedPages.Location = new System.Drawing.Point(3, 199);
            this.LikedPages.Name = "LikedPages";
            this.LikedPages.Size = new System.Drawing.Size(141, 31);
            this.LikedPages.TabIndex = 60;
            this.LikedPages.Text = "View Liked Pages";
            this.LikedPages.UseVisualStyleBackColor = true;
            this.LikedPages.Click += new System.EventHandler(this.likedPages_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(3, 250);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(143, 108);
            this.listBoxLikedPages.TabIndex = 61;
            // 
            // buttonViewPosts
            // 
            this.buttonViewPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonViewPosts.Location = new System.Drawing.Point(204, 207);
            this.buttonViewPosts.Name = "buttonViewPosts";
            this.buttonViewPosts.Size = new System.Drawing.Size(151, 23);
            this.buttonViewPosts.TabIndex = 68;
            this.buttonViewPosts.Text = "View posts";
            this.buttonViewPosts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonViewPosts.UseVisualStyleBackColor = true;
            this.buttonViewPosts.Click += new System.EventHandler(this.buttonViewPosts_Click);
            // 
            // listBoxViewPosts
            // 
            this.listBoxViewPosts.DataSource = this.postBindingSource;
            this.listBoxViewPosts.DisplayMember = "Name";
            this.listBoxViewPosts.FormattingEnabled = true;
            this.listBoxViewPosts.Location = new System.Drawing.Point(204, 250);
            this.listBoxViewPosts.Name = "listBoxViewPosts";
            this.listBoxViewPosts.Size = new System.Drawing.Size(151, 108);
            this.listBoxViewPosts.TabIndex = 69;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeLabel1);
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(361, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 113);
            this.panel1.TabIndex = 70;
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(32, 21);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(111, 21);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 1;
            this.createdTimeLabel1.Text = "label1";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(32, 50);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 13);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(111, 47);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(100, 20);
            this.messageTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(32, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(111, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // FormBasicDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxViewPosts);
            this.Controls.Add(this.buttonViewPosts);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.LikedPages);
            this.Controls.Add(this.ListBox_Events);
            this.Controls.Add(this.button_Events);
            this.Controls.Add(this.ListBox_Album);
            this.Controls.Add(this.button_Albums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBasicDetails";
            this.Text = "Basic User Details";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Albums;
        private System.Windows.Forms.ListBox ListBox_Album;
        private System.Windows.Forms.Button button_Events;
        private System.Windows.Forms.ListBox ListBox_Events;
        private System.Windows.Forms.Button LikedPages;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonViewPosts;
        private System.Windows.Forms.ListBox listBoxViewPosts;
        private BindingSource postBindingSource;
        private Panel panel1;
        private Label createdTimeLabel1;
        private TextBox messageTextBox;
        private TextBox nameTextBox;
    }
}