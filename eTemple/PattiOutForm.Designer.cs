namespace eTemple.UI
{
    partial class PattiOutForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPattiOut = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PattiNumbers = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ActualPackets = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IssuedDate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Entered_By = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Informed_By = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.currentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblPattiNumbers = new System.Windows.Forms.Label();
            this.lblActualPackets = new System.Windows.Forms.Label();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.cmbServiceID = new System.Windows.Forms.ComboBox();
            this.numPattiNumbers = new System.Windows.Forms.NumericUpDown();
            this.numActualPackets = new System.Windows.Forms.NumericUpDown();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPattiOut)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPattiNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActualPackets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1055, 585);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvPattiOut);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 304);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1055, 281);
            this.panel6.TabIndex = 0;
            // 
            // dgvPattiOut
            // 
            this.dgvPattiOut.AllowUserToAddRows = false;
            this.dgvPattiOut.AllowUserToDeleteRows = false;
            this.dgvPattiOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPattiOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPattiOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ServiceName,
            this.PattiNumbers,
            this.ActualPackets,
            this.IssuedDate,
            this.Entered_By,
            this.Informed_By});
            this.dgvPattiOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPattiOut.Location = new System.Drawing.Point(0, 0);
            this.dgvPattiOut.Name = "dgvPattiOut";
            this.dgvPattiOut.ReadOnly = true;
            this.dgvPattiOut.Size = new System.Drawing.Size(1055, 281);
            this.dgvPattiOut.TabIndex = 0;
            this.dgvPattiOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPattiOut_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "S.No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.FillWeight = 20F;
            this.ServiceName.HeaderText = "ServiceName";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // PattiNumbers
            // 
            this.PattiNumbers.DataPropertyName = "PattiNumbers";
            this.PattiNumbers.FillWeight = 12F;
            this.PattiNumbers.HeaderText = "PattiNumbers";
            this.PattiNumbers.Name = "PattiNumbers";
            this.PattiNumbers.ReadOnly = true;
            // 
            // ActualPackets
            // 
            this.ActualPackets.DataPropertyName = "ActualPackets";
            this.ActualPackets.FillWeight = 13F;
            this.ActualPackets.HeaderText = "ActualPackets";
            this.ActualPackets.Name = "ActualPackets";
            this.ActualPackets.ReadOnly = true;
            // 
            // IssuedDate
            // 
            this.IssuedDate.DataPropertyName = "IssuedDate";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.IssuedDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.IssuedDate.FillWeight = 20F;
            this.IssuedDate.HeaderText = "Issued Date";
            this.IssuedDate.Name = "IssuedDate";
            this.IssuedDate.ReadOnly = true;
            // 
            // Entered_By
            // 
            this.Entered_By.DataPropertyName = "Entered_By";
            this.Entered_By.FillWeight = 15F;
            this.Entered_By.HeaderText = "Issued By";
            this.Entered_By.Name = "Entered_By";
            this.Entered_By.ReadOnly = true;
            // 
            // Informed_By
            // 
            this.Informed_By.DataPropertyName = "Informed_By";
            this.Informed_By.FillWeight = 15F;
            this.Informed_By.HeaderText = "Informed By";
            this.Informed_By.Name = "Informed_By";
            this.Informed_By.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add / Update Patti Out Details";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.45614F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.54386F));
            this.tableLayoutPanel4.Controls.Add(this.currentDateTimePicker, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnShow, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(281, 245);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(239, 37);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // currentDateTimePicker
            // 
            this.currentDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.currentDateTimePicker.Location = new System.Drawing.Point(3, 3);
            this.currentDateTimePicker.Name = "currentDateTimePicker";
            this.currentDateTimePicker.Size = new System.Drawing.Size(143, 29);
            this.currentDateTimePicker.TabIndex = 0;
            this.currentDateTimePicker.ValueChanged += new System.EventHandler(this.currentDateTimePicker_ValueChanged);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(152, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 31);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(281, 194);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(418, 45);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(412, 39);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(86, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(196, 34);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "&Add / Update Details";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(288, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRefresh.Size = new System.Drawing.Size(75, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Remarks, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(281, 161);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(418, 33);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remarks";
            // 
            // Remarks
            // 
            this.Remarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Remarks.Location = new System.Drawing.Point(188, 3);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(227, 29);
            this.Remarks.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lblServiceName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPattiNumbers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblActualPackets, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIssuedDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbServiceID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numPattiNumbers, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numActualPackets, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpInDate, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(281, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblServiceName
            // 
            this.lblServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(3, 7);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(149, 21);
            this.lblServiceName.TabIndex = 2;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblPattiNumbers
            // 
            this.lblPattiNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPattiNumbers.AutoSize = true;
            this.lblPattiNumbers.Location = new System.Drawing.Point(3, 42);
            this.lblPattiNumbers.Name = "lblPattiNumbers";
            this.lblPattiNumbers.Size = new System.Drawing.Size(149, 21);
            this.lblPattiNumbers.TabIndex = 3;
            this.lblPattiNumbers.Text = "No. of Patti";
            // 
            // lblActualPackets
            // 
            this.lblActualPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActualPackets.AutoSize = true;
            this.lblActualPackets.Location = new System.Drawing.Point(3, 77);
            this.lblActualPackets.Name = "lblActualPackets";
            this.lblActualPackets.Size = new System.Drawing.Size(149, 21);
            this.lblActualPackets.TabIndex = 4;
            this.lblActualPackets.Text = "Actual Packets";
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Location = new System.Drawing.Point(3, 113);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(149, 21);
            this.lblIssuedDate.TabIndex = 5;
            this.lblIssuedDate.Text = "Issued Date";
            // 
            // cmbServiceID
            // 
            this.cmbServiceID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbServiceID.DisplayMember = "Name";
            this.cmbServiceID.FormattingEnabled = true;
            this.cmbServiceID.Location = new System.Drawing.Point(188, 3);
            this.cmbServiceID.Name = "cmbServiceID";
            this.cmbServiceID.Size = new System.Drawing.Size(227, 29);
            this.cmbServiceID.TabIndex = 6;
            this.cmbServiceID.ValueMember = "Id";
            // 
            // numPattiNumbers
            // 
            this.numPattiNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPattiNumbers.Location = new System.Drawing.Point(188, 38);
            this.numPattiNumbers.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPattiNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPattiNumbers.Name = "numPattiNumbers";
            this.numPattiNumbers.Size = new System.Drawing.Size(227, 29);
            this.numPattiNumbers.TabIndex = 7;
            this.numPattiNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numActualPackets
            // 
            this.numActualPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numActualPackets.Location = new System.Drawing.Point(188, 73);
            this.numActualPackets.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numActualPackets.Name = "numActualPackets";
            this.numActualPackets.Size = new System.Drawing.Size(227, 29);
            this.numActualPackets.TabIndex = 8;
            this.numActualPackets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpInDate
            // 
            this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInDate.Location = new System.Drawing.Point(188, 108);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(227, 29);
            this.dtpInDate.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(158, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(24, 29);
            this.txtId.TabIndex = 10;
            this.txtId.Visible = false;
            // 
            // PattiOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1075, 605);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PattiOutForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "PattiOutForm";
            this.Load += new System.EventHandler(this.PattiOutForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPattiOut)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPattiNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActualPackets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvPattiOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblPattiNumbers;
        private System.Windows.Forms.Label lblActualPackets;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbServiceID;
        private System.Windows.Forms.NumericUpDown numPattiNumbers;
        private System.Windows.Forms.NumericUpDown numActualPackets;
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Remarks;
        private System.Windows.Forms.DataGridViewLinkColumn Id;
        private System.Windows.Forms.DataGridViewLinkColumn ServiceName;
        private System.Windows.Forms.DataGridViewLinkColumn PattiNumbers;
        private System.Windows.Forms.DataGridViewLinkColumn ActualPackets;
        private System.Windows.Forms.DataGridViewLinkColumn IssuedDate;
        private System.Windows.Forms.DataGridViewLinkColumn Entered_By;
        private System.Windows.Forms.DataGridViewLinkColumn Informed_By;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker currentDateTimePicker;
        private System.Windows.Forms.Button btnShow;
    }
}