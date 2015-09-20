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
            this.txtOtherDetails = new System.Windows.Forms.TextBox();
            this.cmbDonorID = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbdDonorId
            // 
            this.rbdDonorId.AutoSize = true;
            this.rbdDonorId.Checked = true;
            this.rbdDonorId.Location = new System.Drawing.Point(70, 64);
            this.rbdDonorId.Name = "rbdDonorId";
            this.rbdDonorId.Size = new System.Drawing.Size(65, 17);
            this.rbdDonorId.TabIndex = 0;
            this.rbdDonorId.TabStop = true;
            this.rbdDonorId.Text = "DonorID";
            this.rbdDonorId.UseVisualStyleBackColor = true;
            this.rbdDonorId.CheckedChanged += new System.EventHandler(this.rbdDonorId_CheckedChanged);
            // 
            // rbdDonorName
            // 
            this.rbdDonorName.AutoSize = true;
            this.rbdDonorName.Location = new System.Drawing.Point(184, 64);
            this.rbdDonorName.Name = "rbdDonorName";
            this.rbdDonorName.Size = new System.Drawing.Size(85, 17);
            this.rbdDonorName.TabIndex = 1;
            this.rbdDonorName.Text = "Donor Name";
            this.rbdDonorName.UseVisualStyleBackColor = true;
            this.rbdDonorName.CheckedChanged += new System.EventHandler(this.rbdDonorName_CheckedChanged);
            // 
            // rbdMRNO
            // 
            this.rbdMRNO.AutoSize = true;
            this.rbdMRNO.Location = new System.Drawing.Point(305, 64);
            this.rbdMRNO.Name = "rbdMRNO";
            this.rbdMRNO.Size = new System.Drawing.Size(61, 17);
            this.rbdMRNO.TabIndex = 2;
            this.rbdMRNO.Text = "MR NO";
            this.rbdMRNO.UseVisualStyleBackColor = true;
            this.rbdMRNO.CheckedChanged += new System.EventHandler(this.rbdMRNO_CheckedChanged);
            // 
            // lblDonorID
            // 
            this.lblDonorID.AutoSize = true;
            this.lblDonorID.Location = new System.Drawing.Point(67, 144);
            this.lblDonorID.Name = "lblDonorID";
            this.lblDonorID.Size = new System.Drawing.Size(50, 13);
            this.lblDonorID.TabIndex = 3;
            this.lblDonorID.Text = "Donor ID";
            // 
            // lblDonorName
            // 
            this.lblDonorName.AutoSize = true;
            this.lblDonorName.Location = new System.Drawing.Point(67, 144);
            this.lblDonorName.Name = "lblDonorName";
            this.lblDonorName.Size = new System.Drawing.Size(67, 13);
            this.lblDonorName.TabIndex = 4;
            this.lblDonorName.Text = "Donor Name";
            // 
            // lblMRNO
            // 
            this.lblMRNO.AutoSize = true;
            this.lblMRNO.Location = new System.Drawing.Point(67, 144);
            this.lblMRNO.Name = "lblMRNO";
            this.lblMRNO.Size = new System.Drawing.Size(43, 13);
            this.lblMRNO.TabIndex = 5;
            this.lblMRNO.Text = "MR NO";
            // 
            // txtOtherDetails
            // 
            this.txtOtherDetails.Location = new System.Drawing.Point(160, 137);
            this.txtOtherDetails.Name = "txtOtherDetails";
            this.txtOtherDetails.Size = new System.Drawing.Size(162, 20);
            this.txtOtherDetails.TabIndex = 6;
            // 
            // cmbDonorID
            // 
            this.cmbDonorID.FormattingEnabled = true;
            this.cmbDonorID.Location = new System.Drawing.Point(160, 137);
            this.cmbDonorID.Name = "cmbDonorID";
            this.cmbDonorID.Size = new System.Drawing.Size(162, 21);
            this.cmbDonorID.TabIndex = 7;
            this.cmbDonorID.SelectedIndexChanged += new System.EventHandler(this.cmbDonorID_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(328, 137);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(37, 23);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // ModifyPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 245);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmbDonorID);
            this.Controls.Add(this.txtOtherDetails);
            this.Controls.Add(this.lblMRNO);
            this.Controls.Add(this.lblDonorName);
            this.Controls.Add(this.lblDonorID);
            this.Controls.Add(this.rbdMRNO);
            this.Controls.Add(this.rbdDonorName);
            this.Controls.Add(this.rbdDonorId);
            this.Name = "ModifyPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Parameters";
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
        private System.Windows.Forms.TextBox txtOtherDetails;
        private System.Windows.Forms.ComboBox cmbDonorID;
        private System.Windows.Forms.Button btnGo;
    }
}