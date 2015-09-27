namespace eTemple.UI.Donations
{
    partial class DonationRecording
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessionToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.enquiryToolStripMenuItem,
            this.eitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.sessionToolStripMenuItem.Text = "Donation Entry";
            this.sessionToolStripMenuItem.Click += new System.EventHandler(this.sessionToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.masterToolStripMenuItem.Text = "Donation Reporting";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // enquiryToolStripMenuItem
            // 
            this.enquiryToolStripMenuItem.Name = "enquiryToolStripMenuItem";
            this.enquiryToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.enquiryToolStripMenuItem.Text = "Enquiry";
            this.enquiryToolStripMenuItem.Click += new System.EventHandler(this.enquiryToolStripMenuItem_Click);
            // 
            // eitToolStripMenuItem
            // 
            this.eitToolStripMenuItem.Name = "eitToolStripMenuItem";
            this.eitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.eitToolStripMenuItem.Text = "Exit";
            this.eitToolStripMenuItem.Click += new System.EventHandler(this.eitToolStripMenuItem_Click);
            // 
            // DonationRecording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 517);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DonationRecording";
            this.Text = "DonationRecording";
            this.Load += new System.EventHandler(this.DonationRecording_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eitToolStripMenuItem;
    }
}