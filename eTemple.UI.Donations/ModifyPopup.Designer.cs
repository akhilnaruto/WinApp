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
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbdDonorId
            // 
            this.rbdDonorId.AutoSize = true;
            this.rbdDonorId.BackColor = System.Drawing.Color.Transparent;
            this.rbdDonorId.Checked = true;
            this.rbdDonorId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdDonorId.Location = new System.Drawing.Point(100, 51);
            this.rbdDonorId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbdDonorId.Name = "rbdDonorId";
            this.rbdDonorId.Size = new System.Drawing.Size(80, 21);
            this.rbdDonorId.TabIndex = 0;
            this.rbdDonorId.TabStop = true;
            this.rbdDonorId.Text = "DonorID";
            this.rbdDonorId.UseVisualStyleBackColor = false;
            this.rbdDonorId.CheckedChanged += new System.EventHandler(this.rbdDonorId_CheckedChanged);
            // 
            // rbdDonorName
            // 
            this.rbdDonorName.AutoSize = true;
            this.rbdDonorName.BackColor = System.Drawing.Color.Transparent;
            this.rbdDonorName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdDonorName.Location = new System.Drawing.Point(252, 51);
            this.rbdDonorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbdDonorName.Name = "rbdDonorName";
            this.rbdDonorName.Size = new System.Drawing.Size(109, 21);
            this.rbdDonorName.TabIndex = 1;
            this.rbdDonorName.Text = "Donor Name";
            this.rbdDonorName.UseVisualStyleBackColor = false;
            this.rbdDonorName.CheckedChanged += new System.EventHandler(this.rbdDonorName_CheckedChanged);
            // 
            // rbdMRNO
            // 
            this.rbdMRNO.AutoSize = true;
            this.rbdMRNO.BackColor = System.Drawing.Color.Transparent;
            this.rbdMRNO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdMRNO.Location = new System.Drawing.Point(414, 51);
            this.rbdMRNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbdMRNO.Name = "rbdMRNO";
            this.rbdMRNO.Size = new System.Drawing.Size(74, 21);
            this.rbdMRNO.TabIndex = 2;
            this.rbdMRNO.Text = "MR NO";
            this.rbdMRNO.UseVisualStyleBackColor = false;
            this.rbdMRNO.CheckedChanged += new System.EventHandler(this.rbdMRNO_CheckedChanged);
            // 
            // lblDonorID
            // 
            this.lblDonorID.AutoSize = true;
            this.lblDonorID.BackColor = System.Drawing.Color.Transparent;
            this.lblDonorID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorID.Location = new System.Drawing.Point(93, 131);
            this.lblDonorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonorID.Name = "lblDonorID";
            this.lblDonorID.Size = new System.Drawing.Size(66, 17);
            this.lblDonorID.TabIndex = 3;
            this.lblDonorID.Text = "Donor ID";
            // 
            // lblDonorName
            // 
            this.lblDonorName.AutoSize = true;
            this.lblDonorName.BackColor = System.Drawing.Color.Transparent;
            this.lblDonorName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorName.Location = new System.Drawing.Point(93, 131);
            this.lblDonorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonorName.Name = "lblDonorName";
            this.lblDonorName.Size = new System.Drawing.Size(91, 17);
            this.lblDonorName.TabIndex = 4;
            this.lblDonorName.Text = "Donor Name";
            // 
            // lblMRNO
            // 
            this.lblMRNO.AutoSize = true;
            this.lblMRNO.BackColor = System.Drawing.Color.Transparent;
            this.lblMRNO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNO.Location = new System.Drawing.Point(94, 131);
            this.lblMRNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMRNO.Name = "lblMRNO";
            this.lblMRNO.Size = new System.Drawing.Size(56, 17);
            this.lblMRNO.TabIndex = 5;
            this.lblMRNO.Text = "MR NO";
            // 
            // txtDonorID
            // 
            this.txtDonorID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorID.Location = new System.Drawing.Point(218, 131);
            this.txtDonorID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.Size = new System.Drawing.Size(215, 25);
            this.txtDonorID.TabIndex = 6;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(218, 166);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(81, 27);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Search";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtDonorName
            // 
            this.txtDonorName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorName.Location = new System.Drawing.Point(218, 131);
            this.txtDonorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonorName.Name = "txtDonorName";
            this.txtDonorName.Size = new System.Drawing.Size(215, 25);
            this.txtDonorName.TabIndex = 9;
            // 
            // txtMRNO
            // 
            this.txtMRNO.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNO.Location = new System.Drawing.Point(218, 131);
            this.txtMRNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMRNO.Name = "txtMRNO";
            this.txtMRNO.Size = new System.Drawing.Size(215, 25);
            this.txtMRNO.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 166);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ModifyPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eTemple.UI.Donations.Properties.Resources.wood4;
            this.ClientSize = new System.Drawing.Size(590, 216);
            this.Controls.Add(this.btnClose);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Button btnClose;
    }
}