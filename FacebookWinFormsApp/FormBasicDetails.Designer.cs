
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBasicDetails));
            this.button_Albums = new System.Windows.Forms.Button();
            this.ListBox_Album = new System.Windows.Forms.ListBox();
            this.button_Events = new System.Windows.Forms.Button();
            this.ListBox_Events = new System.Windows.Forms.ListBox();
            this.LikedPages = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonViewPosts = new System.Windows.Forms.Button();
            this.listBoxViewPosts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Albums
            // 
            this.button_Albums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
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
            this.button_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
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
            this.LikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LikedPages.Location = new System.Drawing.Point(3, 199);
            this.LikedPages.Name = "LikedPages";
            this.LikedPages.Size = new System.Drawing.Size(151, 31);
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
            this.listBoxLikedPages.Size = new System.Drawing.Size(151, 108);
            this.listBoxLikedPages.TabIndex = 61;
            // 
            // buttonViewPosts
            // 
            this.buttonViewPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
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
            this.listBoxViewPosts.FormattingEnabled = true;
            this.listBoxViewPosts.Location = new System.Drawing.Point(204, 250);
            this.listBoxViewPosts.Name = "listBoxViewPosts";
            this.listBoxViewPosts.Size = new System.Drawing.Size(151, 108);
            this.listBoxViewPosts.TabIndex = 69;
            // 
            // FormBasicDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 389);
            this.Controls.Add(this.listBoxViewPosts);
            this.Controls.Add(this.buttonViewPosts);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.LikedPages);
            this.Controls.Add(this.ListBox_Events);
            this.Controls.Add(this.button_Events);
            this.Controls.Add(this.ListBox_Album);
            this.Controls.Add(this.button_Albums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBasicDetails";
            this.Text = "Basic User Details";
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
    }
}