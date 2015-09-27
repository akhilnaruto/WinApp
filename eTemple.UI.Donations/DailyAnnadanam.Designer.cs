namespace eTemple.UI.Donations
{
    partial class DailyAnnadanam
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
            this.txtVillageName = new System.Windows.Forms.TextBox();
            this.lblGothram = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblNameOn = new System.Windows.Forms.Label();
            this.txtGothram = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddData = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVillageName
            // 
            this.txtVillageName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtVillageName.Location = new System.Drawing.Point(443, 126);
            this.txtVillageName.Name = "txtVillageName";
            this.txtVillageName.Size = new System.Drawing.Size(200, 27);
            this.txtVillageName.TabIndex = 26;
            // 
            // lblGothram
            // 
            this.lblGothram.AutoSize = true;
            this.lblGothram.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblGothram.Location = new System.Drawing.Point(12, 126);
            this.lblGothram.Name = "lblGothram";
            this.lblGothram.Size = new System.Drawing.Size(67, 20);
            this.lblGothram.TabIndex = 28;
            this.lblGothram.Text = "Gothram";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(443, 86);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 27);
            this.txtPhoneNumber.TabIndex = 24;
            // 
            // lblNameOn
            // 
            this.lblNameOn.AutoSize = true;
            this.lblNameOn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblNameOn.Location = new System.Drawing.Point(335, 86);
            this.lblNameOn.Name = "lblNameOn";
            this.lblNameOn.Size = new System.Drawing.Size(74, 20);
            this.lblNameOn.TabIndex = 27;
            this.lblNameOn.Text = "Phone No";
            // 
            // txtGothram
            // 
            this.txtGothram.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtGothram.Location = new System.Drawing.Point(99, 126);
            this.txtGothram.Name = "txtGothram";
            this.txtGothram.Size = new System.Drawing.Size(200, 27);
            this.txtGothram.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtName.Location = new System.Drawing.Point(99, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 23;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblName.Location = new System.Drawing.Point(12, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(335, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Village Name";
            // 
            // btnAddData
            // 
            this.btnAddData.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddData.Location = new System.Drawing.Point(228, 204);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(96, 27);
            this.btnAddData.TabIndex = 51;
            this.btnAddData.Text = "Save";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnClose.Location = new System.Drawing.Point(348, 204);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 27);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DailyAnnadanam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVillageName);
            this.Controls.Add(this.lblGothram);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblNameOn);
            this.Controls.Add(this.txtGothram);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "DailyAnnadanam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Annadanam";
            this.Load += new System.EventHandler(this.DailyAnnadanam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVillageName;
        private System.Windows.Forms.Label lblGothram;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblNameOn;
        private System.Windows.Forms.TextBox txtGothram;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
    }
}