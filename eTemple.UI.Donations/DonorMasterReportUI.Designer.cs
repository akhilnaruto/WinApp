namespace eTemple.UI.Donations
{
    partial class DonorMasterReportUI
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
            this.rdbAlldonors = new System.Windows.Forms.RadioButton();
            this.rdbServiceWseDonors = new System.Windows.Forms.RadioButton();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.cmbServiceName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.lblServicePerfmdt = new System.Windows.Forms.Label();
            this.cmbDateType = new System.Windows.Forms.ComboBox();
            this.lblDateType = new System.Windows.Forms.Label();
            this.chkNonPerformSvc = new System.Windows.Forms.CheckBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbThidhi = new System.Windows.Forms.ComboBox();
            this.lblThidhi = new System.Windows.Forms.Label();
            this.cmbSpecialDay = new System.Windows.Forms.ComboBox();
            this.lblSpecialDay = new System.Windows.Forms.Label();
            this.btnGenerateAdress = new System.Windows.Forms.Button();
            this.gpMasterReport = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // rdbAlldonors
            // 
            this.rdbAlldonors.AutoSize = true;
            this.rdbAlldonors.BackColor = System.Drawing.Color.Transparent;
            this.rdbAlldonors.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlldonors.Location = new System.Drawing.Point(65, 36);
            this.rdbAlldonors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbAlldonors.Name = "rdbAlldonors";
            this.rdbAlldonors.Size = new System.Drawing.Size(99, 22);
            this.rdbAlldonors.TabIndex = 0;
            this.rdbAlldonors.TabStop = true;
            this.rdbAlldonors.Text = "All Donors";
            this.rdbAlldonors.UseVisualStyleBackColor = false;
            this.rdbAlldonors.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbServiceWseDonors
            // 
            this.rdbServiceWseDonors.AutoSize = true;
            this.rdbServiceWseDonors.BackColor = System.Drawing.Color.Transparent;
            this.rdbServiceWseDonors.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbServiceWseDonors.Location = new System.Drawing.Point(316, 36);
            this.rdbServiceWseDonors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbServiceWseDonors.Name = "rdbServiceWseDonors";
            this.rdbServiceWseDonors.Size = new System.Drawing.Size(169, 22);
            this.rdbServiceWseDonors.TabIndex = 1;
            this.rdbServiceWseDonors.TabStop = true;
            this.rdbServiceWseDonors.Text = "Servicewise Donors";
            this.rdbServiceWseDonors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbServiceWseDonors.UseVisualStyleBackColor = false;
            this.rdbServiceWseDonors.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(72, 87);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(92, 17);
            this.lblServiceType.TabIndex = 2;
            this.lblServiceType.Text = "Service Type";
            this.lblServiceType.Visible = false;
            this.lblServiceType.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(72, 126);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(100, 17);
            this.lblServiceName.TabIndex = 3;
            this.lblServiceName.Text = "Service Name";
            this.lblServiceName.Visible = false;
            this.lblServiceName.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Location = new System.Drawing.Point(172, 82);
            this.cmbServiceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(224, 25);
            this.cmbServiceType.TabIndex = 4;
            this.cmbServiceType.Visible = false;
            this.cmbServiceType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbServiceName
            // 
            this.cmbServiceName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiceName.FormattingEnabled = true;
            this.cmbServiceName.Items.AddRange(new object[] {
            "        "});
            this.cmbServiceName.Location = new System.Drawing.Point(173, 121);
            this.cmbServiceName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbServiceName.Name = "cmbServiceName";
            this.cmbServiceName.Size = new System.Drawing.Size(224, 25);
            this.cmbServiceName.TabIndex = 5;
            this.cmbServiceName.Visible = false;
            this.cmbServiceName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(377, 338);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(214, 254);
            this.dtPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(182, 25);
            this.dtPicker.TabIndex = 8;
            this.dtPicker.Visible = false;
            // 
            // lblServicePerfmdt
            // 
            this.lblServicePerfmdt.AutoSize = true;
            this.lblServicePerfmdt.BackColor = System.Drawing.Color.Transparent;
            this.lblServicePerfmdt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePerfmdt.Location = new System.Drawing.Point(72, 255);
            this.lblServicePerfmdt.Name = "lblServicePerfmdt";
            this.lblServicePerfmdt.Size = new System.Drawing.Size(141, 17);
            this.lblServicePerfmdt.TabIndex = 9;
            this.lblServicePerfmdt.Text = "Select Perform Date";
            this.lblServicePerfmdt.Visible = false;
            // 
            // cmbDateType
            // 
            this.cmbDateType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateType.FormattingEnabled = true;
            this.cmbDateType.Items.AddRange(new object[] {
            "        "});
            this.cmbDateType.Location = new System.Drawing.Point(172, 164);
            this.cmbDateType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDateType.Name = "cmbDateType";
            this.cmbDateType.Size = new System.Drawing.Size(226, 25);
            this.cmbDateType.TabIndex = 11;
            this.cmbDateType.SelectedIndexChanged += new System.EventHandler(this.cmbDateType_SelectedIndexChanged);
            // 
            // lblDateType
            // 
            this.lblDateType.AutoSize = true;
            this.lblDateType.BackColor = System.Drawing.Color.Transparent;
            this.lblDateType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateType.Location = new System.Drawing.Point(75, 169);
            this.lblDateType.Name = "lblDateType";
            this.lblDateType.Size = new System.Drawing.Size(74, 17);
            this.lblDateType.TabIndex = 10;
            this.lblDateType.Text = "Date Type";
            // 
            // chkNonPerformSvc
            // 
            this.chkNonPerformSvc.AutoSize = true;
            this.chkNonPerformSvc.BackColor = System.Drawing.Color.Transparent;
            this.chkNonPerformSvc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNonPerformSvc.Location = new System.Drawing.Point(151, 290);
            this.chkNonPerformSvc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNonPerformSvc.Name = "chkNonPerformSvc";
            this.chkNonPerformSvc.Size = new System.Drawing.Size(232, 21);
            this.chkNonPerformSvc.TabIndex = 12;
            this.chkNonPerformSvc.Text = "Non performance Service types";
            this.chkNonPerformSvc.UseVisualStyleBackColor = false;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "        "});
            this.cmbMonth.Location = new System.Drawing.Point(141, 204);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(126, 25);
            this.cmbMonth.TabIndex = 16;
            this.cmbMonth.Visible = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(78, 207);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(47, 17);
            this.lblMonth.TabIndex = 15;
            this.lblMonth.Text = "Month";
            this.lblMonth.Visible = false;
            // 
            // cmbThidhi
            // 
            this.cmbThidhi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThidhi.FormattingEnabled = true;
            this.cmbThidhi.Items.AddRange(new object[] {
            "        "});
            this.cmbThidhi.Location = new System.Drawing.Point(350, 204);
            this.cmbThidhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbThidhi.Name = "cmbThidhi";
            this.cmbThidhi.Size = new System.Drawing.Size(126, 25);
            this.cmbThidhi.TabIndex = 18;
            this.cmbThidhi.Visible = false;
            // 
            // lblThidhi
            // 
            this.lblThidhi.AutoSize = true;
            this.lblThidhi.BackColor = System.Drawing.Color.Transparent;
            this.lblThidhi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThidhi.Location = new System.Drawing.Point(282, 207);
            this.lblThidhi.Name = "lblThidhi";
            this.lblThidhi.Size = new System.Drawing.Size(47, 17);
            this.lblThidhi.TabIndex = 17;
            this.lblThidhi.Text = "Thidhi";
            this.lblThidhi.Visible = false;
            // 
            // cmbSpecialDay
            // 
            this.cmbSpecialDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecialDay.FormattingEnabled = true;
            this.cmbSpecialDay.Items.AddRange(new object[] {
            "        "});
            this.cmbSpecialDay.Location = new System.Drawing.Point(172, 208);
            this.cmbSpecialDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSpecialDay.Name = "cmbSpecialDay";
            this.cmbSpecialDay.Size = new System.Drawing.Size(224, 25);
            this.cmbSpecialDay.TabIndex = 20;
            this.cmbSpecialDay.Visible = false;
            // 
            // lblSpecialDay
            // 
            this.lblSpecialDay.AutoSize = true;
            this.lblSpecialDay.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecialDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialDay.Location = new System.Drawing.Point(74, 209);
            this.lblSpecialDay.Name = "lblSpecialDay";
            this.lblSpecialDay.Size = new System.Drawing.Size(83, 17);
            this.lblSpecialDay.TabIndex = 19;
            this.lblSpecialDay.Text = "Special Day";
            this.lblSpecialDay.Visible = false;
            // 
            // btnGenerateAdress
            // 
            this.btnGenerateAdress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAdress.Location = new System.Drawing.Point(31, 338);
            this.btnGenerateAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateAdress.Name = "btnGenerateAdress";
            this.btnGenerateAdress.Size = new System.Drawing.Size(150, 31);
            this.btnGenerateAdress.TabIndex = 21;
            this.btnGenerateAdress.Text = "Generate Addresses";
            this.btnGenerateAdress.UseVisualStyleBackColor = true;
            this.btnGenerateAdress.Click += new System.EventHandler(this.button3_Click);
            // 
            // gpMasterReport
            // 
            this.gpMasterReport.BackColor = System.Drawing.Color.Transparent;
            this.gpMasterReport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpMasterReport.Location = new System.Drawing.Point(22, 12);
            this.gpMasterReport.Name = "gpMasterReport";
            this.gpMasterReport.Size = new System.Drawing.Size(516, 388);
            this.gpMasterReport.TabIndex = 22;
            this.gpMasterReport.TabStop = false;
            this.gpMasterReport.Text = "Donor Master Report";
            // 
            // DonorMasterReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eTemple.UI.Donations.Properties.Resources.wood4_Border;
            this.ClientSize = new System.Drawing.Size(557, 422);
            this.Controls.Add(this.btnGenerateAdress);
            this.Controls.Add(this.cmbThidhi);
            this.Controls.Add(this.lblThidhi);
            this.Controls.Add(this.chkNonPerformSvc);
            this.Controls.Add(this.cmbDateType);
            this.Controls.Add(this.lblDateType);
            this.Controls.Add(this.lblServicePerfmdt);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbServiceName);
            this.Controls.Add(this.cmbServiceType);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.rdbServiceWseDonors);
            this.Controls.Add(this.rdbAlldonors);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbSpecialDay);
            this.Controls.Add(this.lblSpecialDay);
            this.Controls.Add(this.gpMasterReport);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DonorMasterReportUI";
            this.Text = "Donor Master Report";
            this.Load += new System.EventHandler(this.DonorMasterReportUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAlldonors;
        private System.Windows.Forms.RadioButton rdbServiceWseDonors;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.ComboBox cmbServiceName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label lblServicePerfmdt;
        private System.Windows.Forms.ComboBox cmbDateType;
        private System.Windows.Forms.Label lblDateType;
        private System.Windows.Forms.CheckBox chkNonPerformSvc;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbThidhi;
        private System.Windows.Forms.Label lblThidhi;
        private System.Windows.Forms.ComboBox cmbSpecialDay;
        private System.Windows.Forms.Label lblSpecialDay;
        private System.Windows.Forms.Button btnGenerateAdress;
        private System.Windows.Forms.GroupBox gpMasterReport;
    }
}