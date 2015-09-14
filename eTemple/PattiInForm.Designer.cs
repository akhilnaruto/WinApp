namespace eTemple.UI
{
    partial class PattiInForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPattiIn = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PattiNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnteredBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbServiceID = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInDate = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblPattiNumber = new System.Windows.Forms.Label();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.numPattiNumbers = new System.Windows.Forms.NumericUpDown();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPattiIn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPattiNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1213, 476);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvPattiIn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1213, 284);
            this.panel6.TabIndex = 1;
            // 
            // dgvPattiIn
            // 
            this.dgvPattiIn.AllowUserToAddRows = false;
            this.dgvPattiIn.AllowUserToDeleteRows = false;
            this.dgvPattiIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPattiIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPattiIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ServiceName,
            this.PattiNumbers,
            this.InDate,
            this.EnteredBy});
            this.dgvPattiIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPattiIn.Location = new System.Drawing.Point(0, 0);
            this.dgvPattiIn.Name = "dgvPattiIn";
            this.dgvPattiIn.ReadOnly = true;
            this.dgvPattiIn.Size = new System.Drawing.Size(1213, 284);
            this.dgvPattiIn.TabIndex = 0;
            this.dgvPattiIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPattiIn_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "S.No.";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.FillWeight = 40F;
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // PattiNumbers
            // 
            this.PattiNumbers.DataPropertyName = "PattiNumbers";
            this.PattiNumbers.FillWeight = 15F;
            this.PattiNumbers.HeaderText = "No. of Pattis";
            this.PattiNumbers.Name = "PattiNumbers";
            this.PattiNumbers.ReadOnly = true;
            // 
            // InDate
            // 
            this.InDate.DataPropertyName = "InDate";
            this.InDate.FillWeight = 20F;
            this.InDate.HeaderText = "On Date";
            this.InDate.Name = "InDate";
            this.InDate.ReadOnly = true;
            // 
            // EnteredBy
            // 
            this.EnteredBy.DataPropertyName = "EnteredBy";
            this.EnteredBy.FillWeight = 15F;
            this.EnteredBy.HeaderText = "Entered By";
            this.EnteredBy.Name = "EnteredBy";
            this.EnteredBy.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1213, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add / Update Patti In Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmbServiceID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblInDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblServiceID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPattiNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpInDate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numPattiNumbers, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(263, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbServiceID
            // 
            this.cmbServiceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbServiceID.DisplayMember = "Name";
            this.cmbServiceID.FormattingEnabled = true;
            this.cmbServiceID.Location = new System.Drawing.Point(268, 3);
            this.cmbServiceID.Name = "cmbServiceID";
            this.cmbServiceID.Size = new System.Drawing.Size(220, 29);
            this.cmbServiceID.TabIndex = 1;
            this.cmbServiceID.ValueMember = "Id";
            // 
            // panel7
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel7, 3);
            this.panel7.Controls.Add(this.btnRefresh);
            this.panel7.Controls.Add(this.btnSubmit);
            this.panel7.Controls.Add(this.btnCancel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 108);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(485, 47);
            this.panel7.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(310, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 37);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(148, 7);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(156, 37);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "&Add / Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(59, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 37);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInDate
            // 
            this.lblInDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInDate.AutoSize = true;
            this.lblInDate.Location = new System.Drawing.Point(3, 77);
            this.lblInDate.Name = "lblInDate";
            this.lblInDate.Size = new System.Drawing.Size(219, 21);
            this.lblInDate.TabIndex = 1;
            this.lblInDate.Text = "Date";
            // 
            // lblServiceID
            // 
            this.lblServiceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(3, 7);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(219, 21);
            this.lblServiceID.TabIndex = 0;
            this.lblServiceID.Text = "Service Name";
            // 
            // lblPattiNumber
            // 
            this.lblPattiNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPattiNumber.AutoSize = true;
            this.lblPattiNumber.Location = new System.Drawing.Point(3, 42);
            this.lblPattiNumber.Name = "lblPattiNumber";
            this.lblPattiNumber.Size = new System.Drawing.Size(219, 21);
            this.lblPattiNumber.TabIndex = 1;
            this.lblPattiNumber.Text = "No. of Patti";
            // 
            // dtpInDate
            // 
            this.dtpInDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInDate.CustomFormat = "";
            this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInDate.Location = new System.Drawing.Point(268, 73);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(220, 29);
            this.dtpInDate.TabIndex = 4;
            this.dtpInDate.Value = new System.DateTime(2014, 5, 9, 12, 49, 0, 0);
            // 
            // numPattiNumbers
            // 
            this.numPattiNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numPattiNumbers.Location = new System.Drawing.Point(268, 38);
            this.numPattiNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPattiNumbers.Name = "numPattiNumbers";
            this.numPattiNumbers.Size = new System.Drawing.Size(220, 29);
            this.numPattiNumbers.TabIndex = 3;
            this.numPattiNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(228, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(34, 29);
            this.txtId.TabIndex = 5;
            this.txtId.Visible = false;
            // 
            // PattiInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1233, 496);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PattiInForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "PattiInForm";
            this.Load += new System.EventHandler(this.PattiInForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPattiIn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPattiNumbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblInDate;
        private System.Windows.Forms.Label lblPattiNumber;
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private System.Windows.Forms.NumericUpDown numPattiNumbers;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPattiIn;
        private System.Windows.Forms.ComboBox cmbServiceID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewLinkColumn Id;
        private System.Windows.Forms.DataGridViewLinkColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PattiNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn InDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnteredBy;
    }
}