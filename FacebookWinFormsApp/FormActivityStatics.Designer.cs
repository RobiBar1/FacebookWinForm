
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormActivityStatics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActivityStatics));
            this.buttonMaximumActivity = new System.Windows.Forms.Button();
            this.buttonMinimalActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMaximumActivity
            // 
            this.buttonMaximumActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMaximumActivity.Location = new System.Drawing.Point(8, 25);
            this.buttonMaximumActivity.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMaximumActivity.Name = "buttonMaximumActivity";
            this.buttonMaximumActivity.Size = new System.Drawing.Size(117, 56);
            this.buttonMaximumActivity.TabIndex = 0;
            this.buttonMaximumActivity.Text = "Maximum Activity";
            this.buttonMaximumActivity.UseVisualStyleBackColor = true;
            this.buttonMaximumActivity.Click += new System.EventHandler(this.buttonMaximumActivity_Click);
            // 
            // buttonMinimalActivity
            // 
            this.buttonMinimalActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMinimalActivity.Location = new System.Drawing.Point(8, 144);
            this.buttonMinimalActivity.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinimalActivity.Name = "buttonMinimalActivity";
            this.buttonMinimalActivity.Size = new System.Drawing.Size(117, 56);
            this.buttonMinimalActivity.TabIndex = 1;
            this.buttonMinimalActivity.Text = "Minimal Activity";
            this.buttonMinimalActivity.UseVisualStyleBackColor = true;
            this.buttonMinimalActivity.Click += new System.EventHandler(this.buttonMinimalActivity_Click);
            // 
            // FormActivityStatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 292);
            this.Controls.Add(this.buttonMinimalActivity);
            this.Controls.Add(this.buttonMaximumActivity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormActivityStatics";
            this.Text = "User Activity Statics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMaximumActivity;
        private System.Windows.Forms.Button buttonMinimalActivity;
    }
}