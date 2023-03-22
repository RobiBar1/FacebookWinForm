
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
            this.buttonMaximumActivity = new System.Windows.Forms.Button();
            this.buttonMinimalActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMaximumActivity
            // 
            this.buttonMaximumActivity.Location = new System.Drawing.Point(12, 38);
            this.buttonMaximumActivity.Name = "buttonMaximumActivity";
            this.buttonMaximumActivity.Size = new System.Drawing.Size(175, 86);
            this.buttonMaximumActivity.TabIndex = 0;
            this.buttonMaximumActivity.Text = "Maximum Activity";
            this.buttonMaximumActivity.UseVisualStyleBackColor = true;
            this.buttonMaximumActivity.Click += new System.EventHandler(this.buttonMaximumActivity_Click);
            // 
            // buttonMinimalActivity
            // 
            this.buttonMinimalActivity.Location = new System.Drawing.Point(12, 222);
            this.buttonMinimalActivity.Name = "buttonMinimalActivity";
            this.buttonMinimalActivity.Size = new System.Drawing.Size(175, 86);
            this.buttonMinimalActivity.TabIndex = 1;
            this.buttonMinimalActivity.Text = "Minimal Activity";
            this.buttonMinimalActivity.UseVisualStyleBackColor = true;
            this.buttonMinimalActivity.Click += new System.EventHandler(this.buttonMinimalActivity_Click);
            // 
            // FormActivityStatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMinimalActivity);
            this.Controls.Add(this.buttonMaximumActivity);
            this.Name = "FormActivityStatics";
            this.Text = "FormActivityStatics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMaximumActivity;
        private System.Windows.Forms.Button buttonMinimalActivity;
    }
}