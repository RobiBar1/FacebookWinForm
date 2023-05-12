
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
            System.Windows.Forms.Label captionLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.captionTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            captionLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Location = new System.Drawing.Point(83, 64);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new System.Drawing.Size(68, 20);
            captionLabel.TabIndex = 0;
            captionLabel.Text = "Caption:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(83, 97);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(108, 20);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(83, 128);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(83, 160);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // button_Albums
            // 
            this.button_Albums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Albums.Location = new System.Drawing.Point(4, 34);
            this.button_Albums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Albums.Name = "button_Albums";
            this.button_Albums.Size = new System.Drawing.Size(213, 35);
            this.button_Albums.TabIndex = 56;
            this.button_Albums.Text = "View albums";
            this.button_Albums.UseVisualStyleBackColor = true;
            this.button_Albums.Click += new System.EventHandler(this.button_Albums_Click);
            // 
            // ListBox_Album
            // 
            this.ListBox_Album.FormattingEnabled = true;
            this.ListBox_Album.ItemHeight = 20;
            this.ListBox_Album.Location = new System.Drawing.Point(4, 92);
            this.ListBox_Album.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBox_Album.Name = "ListBox_Album";
            this.ListBox_Album.Size = new System.Drawing.Size(211, 164);
            this.ListBox_Album.TabIndex = 57;
            // 
            // button_Events
            // 
            this.button_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Events.Location = new System.Drawing.Point(306, 34);
            this.button_Events.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Events.Name = "button_Events";
            this.button_Events.Size = new System.Drawing.Size(226, 35);
            this.button_Events.TabIndex = 58;
            this.button_Events.Text = "View events";
            this.button_Events.UseVisualStyleBackColor = true;
            this.button_Events.Click += new System.EventHandler(this.button_Events_Click);
            // 
            // ListBox_Events
            // 
            this.ListBox_Events.FormattingEnabled = true;
            this.ListBox_Events.ItemHeight = 20;
            this.ListBox_Events.Location = new System.Drawing.Point(306, 92);
            this.ListBox_Events.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBox_Events.Name = "ListBox_Events";
            this.ListBox_Events.Size = new System.Drawing.Size(224, 164);
            this.ListBox_Events.TabIndex = 59;
            // 
            // LikedPages
            // 
            this.LikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LikedPages.Location = new System.Drawing.Point(4, 306);
            this.LikedPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LikedPages.Name = "LikedPages";
            this.LikedPages.Size = new System.Drawing.Size(211, 47);
            this.LikedPages.TabIndex = 60;
            this.LikedPages.Text = "View Liked Pages";
            this.LikedPages.UseVisualStyleBackColor = true;
            this.LikedPages.Click += new System.EventHandler(this.likedPages_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 20;
            this.listBoxLikedPages.Location = new System.Drawing.Point(4, 385);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(213, 164);
            this.listBoxLikedPages.TabIndex = 61;
            // 
            // buttonViewPosts
            // 
            this.buttonViewPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonViewPosts.Location = new System.Drawing.Point(306, 318);
            this.buttonViewPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonViewPosts.Name = "buttonViewPosts";
            this.buttonViewPosts.Size = new System.Drawing.Size(226, 35);
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
            this.listBoxViewPosts.ItemHeight = 20;
            this.listBoxViewPosts.Location = new System.Drawing.Point(306, 385);
            this.listBoxViewPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxViewPosts.Name = "listBoxViewPosts";
            this.listBoxViewPosts.Size = new System.Drawing.Size(224, 164);
            this.listBoxViewPosts.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(captionLabel);
            this.panel1.Controls.Add(this.captionTextBox);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(537, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 203);
            this.panel1.TabIndex = 70;
            // 
            // captionTextBox
            // 
            this.captionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Caption", true));
            this.captionTextBox.Location = new System.Drawing.Point(197, 61);
            this.captionTextBox.Name = "captionTextBox";
            this.captionTextBox.Size = new System.Drawing.Size(200, 26);
            this.captionTextBox.TabIndex = 1;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(197, 93);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(197, 125);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 26);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(197, 157);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameTextBox.TabIndex = 7;
            // 
            // FormBasicDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 652);
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
            this.Name = "FormBasicDetails";
            this.Text = "Basic User Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
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
        private Panel panel1;
        private TextBox captionTextBox;
        private BindingSource postBindingSource;
        private DateTimePicker createdTimeDateTimePicker;
        private TextBox descriptionTextBox;
        private TextBox nameTextBox;
    }
}