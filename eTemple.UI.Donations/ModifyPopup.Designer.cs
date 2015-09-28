namespace eTemple.UI.Donations
{
    partial class ModifyPopup
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
            this.rbdDonorId = new System.Windows.Forms.RadioButton();
            this.rbdDonorName = new System.Windows.Forms.RadioButton();
            this.rbdMRNO = new System.Windows.Forms.RadioButton();
            this.lblDonorID = new System.Windows.Forms.Label();
            this.lblDonorName = new System.Windows.Forms.Label();
            this.lblMRNO = new System.Windows.Forms.Label();
            this.txtDonorID = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtDonorName = new System.Windows.Forms.TextBox();
            this.txtMRNO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbdDonorId
            // 
            this.rbdDonorId.AutoSize = true;
            this.rbdDonorId.Checked = true;
            this.rbdDonorId.Location = new System.Drawing.Point(93, 98);
            this.rbdDonorId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbdDonorId.Name = "rbdDonorId";
            this.rbdDonorId.Size = new System.Drawing.Size(84, 24);
            this.rbdDonorId.TabIndex = 0;
            this.rbdDonorId.TabStop = true;
            this.rbdDonorId.Text = "DonorID";
            this.rbdDonorId.UseVisualStyleBackColor = true;
            this.rbdDonorId.CheckedChanged += new System.EventHandler(this.rbdDonorId_CheckedChanged);
            // 
            // rbdDonorName
            // 
            this.rbdDonorName.AutoSize = true;
            this.rbdDonorName.Location = new System.Drawing.Point(245, 98);
            this.rbdDonorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbdDonorName.Name = "rbdDonorName";
            this.rbdDonorName.Size = new System.Drawing.Size(113, 24);
            this.rbdDonorName.TabIndex = 1;
            this.rbdDonorName.Text = "Donor Name";
            this.rbdDonorName.UseVisualStyleBackColor = true;
            this.rbdDonorName.CheckedChanged += new System.EventHandler(this.rbdDonorName_CheckedChanged);
            // 
            // rbdMRNO
            // 
            this.rbdMRNO.AutoSize = true;
            this.rbdMRNO.Location = new System.Drawing.Point(407, 98);
            this.rbdMRNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbdMRNO.Name = "rbdMRNO";
            this.rbdMRNO.Size = new System.Drawing.Size(75, 24);
            this.rbdMRNO.TabIndex = 2;
            this.rbdMRNO.Text = "MR NO";
            this.rbdMRNO.UseVisualStyleBackColor = true;
            this.rbdMRNO.CheckedChanged += new System.EventHandler(this.rbdMRNO_CheckedChanged);
            // 
            // lblDonorID
            // 
            this.lblDonorID.AutoSize = true;
            this.lblDonorID.Location = new System.Drawing.Point(89, 211);
            this.lblDonorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonorID.Name = "lblDonorID";
            this.lblDonorID.Size = new System.Drawing.Size(70, 20);
            this.lblDonorID.TabIndex = 3;
            this.lblDonorID.Text = "Donor ID";
            // 
            // lblDonorName
            // 
            this.lblDonorName.AutoSize = true;
            this.lblDonorName.Location = new System.Drawing.Point(89, 211);
            this.lblDonorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonorName.Name = "lblDonorName";
            this.lblDonorName.Size = new System.Drawing.Size(95, 20);
            this.lblDonorName.TabIndex = 4;
            this.lblDonorName.Text = "Donor Name";
            // 
            // lblMRNO
            // 
            this.lblMRNO.AutoSize = true;
            this.lblMRNO.Location = new System.Drawing.Point(89, 211);
            this.lblMRNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMRNO.Name = "lblMRNO";
            this.lblMRNO.Size = new System.Drawing.Size(57, 20);
            this.lblMRNO.TabIndex = 5;
            this.lblMRNO.Text = "MR NO";
            // 
            // txtDonorID
            // 
            this.txtDonorID.Location = new System.Drawing.Point(214, 211);
            this.txtDonorID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.Size = new System.Drawing.Size(215, 27);
            this.txtDonorID.TabIndex = 6;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(437, 211);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(49, 27);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtDonorName
            // 
            this.txtDonorName.Location = new System.Drawing.Point(214, 211);
            this.txtDonorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonorName.Name = "txtDonorName";
            this.txtDonorName.Size = new System.Drawing.Size(215, 27);
            this.txtDonorName.TabIndex = 9;
            // 
            // txtMRNO
            // 
            this.txtMRNO.Location = new System.Drawing.Point(214, 211);
            this.txtMRNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMRNO.Name = "txtMRNO";
            this.txtMRNO.Size = new System.Drawing.Size(215, 27);
            this.txtMRNO.TabIndex = 10;
            // 
            // ModifyPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 377);
            this.Controls.Add(this.txtMRNO);
            this.Controls.Add(this.txtDonorName);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtDonorID);
            this.Controls.Add(this.lblMRNO);
            this.Controls.Add(this.lblDonorName);
            this.Controls.Add(this.lblDonorID);
            this.Controls.Add(this.rbdMRNO);
            this.Controls.Add(this.rbdDonorName);
            this.Controls.Add(this.rbdDonorId);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModifyPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Parameters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyPopup_FormClosing);
            this.Load += new System.EventHandler(this.ModifyPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbdDonorId;
        private System.Windows.Forms.RadioButton rbdDonorName;
        private System.Windows.Forms.RadioButton rbdMRNO;
        private System.Windows.Forms.Label lblDonorID;
        private System.Windows.Forms.Label lblDonorName;
        private System.Windows.Forms.Label lblMRNO;
        private System.Windows.Forms.TextBox txtDonorID;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtDonorName;
        private System.Windows.Forms.TextBox txtMRNO;
    }
}