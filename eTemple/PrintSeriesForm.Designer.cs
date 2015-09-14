namespace eTemple.UI
{
    partial class PrintSeriesForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPrintSeriesBalance = new System.Windows.Forms.DataGridView();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGivenTokens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvPrintSeries = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.GivenTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintseriesStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintseriesEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GivenBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gpbPrintSeries = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShow = new System.Windows.Forms.Button();
            this.currentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblStartNumber = new System.Windows.Forms.Label();
            this.lblEndNumber = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPrintSeriesId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.brnSubmit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbGivenTo = new System.Windows.Forms.ComboBox();
            this.txtStartNumber = new System.Windows.Forms.TextBox();
            this.txtEndNumber = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printSeriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintSeriesBalance)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintSeries)).BeginInit();
            this.panel6.SuspendLayout();
            this.gpbPrintSeries.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printSeriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1038, 531);
            this.panel5.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPrintSeriesBalance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(595, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 269);
            this.panel1.TabIndex = 2;
            // 
            // dgvPrintSeriesBalance
            // 
            this.dgvPrintSeriesBalance.AllowUserToAddRows = false;
            this.dgvPrintSeriesBalance.AllowUserToDeleteRows = false;
            this.dgvPrintSeriesBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrintSeriesBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintSeriesBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpName,
            this.TotalGivenTokens,
            this.Balance});
            this.dgvPrintSeriesBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrintSeriesBalance.Location = new System.Drawing.Point(0, 0);
            this.dgvPrintSeriesBalance.Name = "dgvPrintSeriesBalance";
            this.dgvPrintSeriesBalance.ReadOnly = true;
            this.dgvPrintSeriesBalance.RowHeadersVisible = false;
            this.dgvPrintSeriesBalance.Size = new System.Drawing.Size(443, 269);
            this.dgvPrintSeriesBalance.TabIndex = 0;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmployeeName";
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // TotalGivenTokens
            // 
            this.TotalGivenTokens.DataPropertyName = "TotalGivenTokens";
            this.TotalGivenTokens.HeaderText = "Given Tokens";
            this.TotalGivenTokens.Name = "TotalGivenTokens";
            this.TotalGivenTokens.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvPrintSeries);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 262);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(589, 269);
            this.panel7.TabIndex = 1;
            // 
            // dgvPrintSeries
            // 
            this.dgvPrintSeries.AllowUserToAddRows = false;
            this.dgvPrintSeries.AllowUserToDeleteRows = false;
            this.dgvPrintSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrintSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GivenTo,
            this.PrintseriesStart,
            this.PrintseriesEnd,
            this.CreatedOn,
            this.GivenBy});
            this.dgvPrintSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrintSeries.Location = new System.Drawing.Point(0, 0);
            this.dgvPrintSeries.Name = "dgvPrintSeries";
            this.dgvPrintSeries.ReadOnly = true;
            this.dgvPrintSeries.Size = new System.Drawing.Size(589, 269);
            this.dgvPrintSeries.TabIndex = 0;
            this.dgvPrintSeries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrintSeries_CellContentClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "S.No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GivenTo
            // 
            this.GivenTo.DataPropertyName = "Given_To";
            this.GivenTo.FillWeight = 20F;
            this.GivenTo.HeaderText = "Given To";
            this.GivenTo.Name = "GivenTo";
            this.GivenTo.ReadOnly = true;
            // 
            // PrintseriesStart
            // 
            this.PrintseriesStart.DataPropertyName = "PrintseriesStart";
            this.PrintseriesStart.FillWeight = 12F;
            this.PrintseriesStart.HeaderText = "Start Number";
            this.PrintseriesStart.Name = "PrintseriesStart";
            this.PrintseriesStart.ReadOnly = true;
            // 
            // PrintseriesEnd
            // 
            this.PrintseriesEnd.DataPropertyName = "PrintseriesEnd";
            this.PrintseriesEnd.FillWeight = 13F;
            this.PrintseriesEnd.HeaderText = "End Number";
            this.PrintseriesEnd.Name = "PrintseriesEnd";
            this.PrintseriesEnd.ReadOnly = true;
            // 
            // CreatedOn
            // 
            this.CreatedOn.DataPropertyName = "CreatedOn";
            this.CreatedOn.FillWeight = 25F;
            this.CreatedOn.HeaderText = "Given On";
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.ReadOnly = true;
            // 
            // GivenBy
            // 
            this.GivenBy.DataPropertyName = "Given_By";
            this.GivenBy.FillWeight = 20F;
            this.GivenBy.HeaderText = "Given By";
            this.GivenBy.Name = "GivenBy";
            this.GivenBy.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gpbPrintSeries);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1038, 262);
            this.panel6.TabIndex = 0;
            // 
            // gpbPrintSeries
            // 
            this.gpbPrintSeries.Controls.Add(this.tableLayoutPanel2);
            this.gpbPrintSeries.Controls.Add(this.tableLayoutPanel1);
            this.gpbPrintSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbPrintSeries.Location = new System.Drawing.Point(0, 0);
            this.gpbPrintSeries.Name = "gpbPrintSeries";
            this.gpbPrintSeries.Size = new System.Drawing.Size(1038, 262);
            this.gpbPrintSeries.TabIndex = 0;
            this.gpbPrintSeries.TabStop = false;
            this.gpbPrintSeries.Text = "Add / Update Print Series";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnShow, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.currentDateTimePicker, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.toDateTimePicker, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbUsername, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(82, 214);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(507, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(381, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(123, 28);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // currentDateTimePicker
            // 
            this.currentDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.currentDateTimePicker.Location = new System.Drawing.Point(3, 3);
            this.currentDateTimePicker.Name = "currentDateTimePicker";
            this.currentDateTimePicker.Size = new System.Drawing.Size(120, 27);
            this.currentDateTimePicker.TabIndex = 1;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(129, 3);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(120, 27);
            this.toDateTimePicker.TabIndex = 2;
            // 
            // cmbUsername
            // 
            this.cmbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsername.DisplayMember = "LoginId";
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(255, 3);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(120, 28);
            this.cmbUsername.TabIndex = 3;
            this.cmbUsername.ValueMember = "Id";
            this.cmbUsername.SelectedIndexChanged += new System.EventHandler(this.cmbUsername_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStartNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEndNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbGivenTo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtStartNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEndNumber, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(373, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.3301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.3301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.3301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.00971F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 156);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblStartNumber
            // 
            this.lblStartNumber.AutoSize = true;
            this.lblStartNumber.Location = new System.Drawing.Point(3, 34);
            this.lblStartNumber.Name = "lblStartNumber";
            this.lblStartNumber.Size = new System.Drawing.Size(98, 20);
            this.lblStartNumber.TabIndex = 1;
            this.lblStartNumber.Text = "Start Number";
            // 
            // lblEndNumber
            // 
            this.lblEndNumber.AutoSize = true;
            this.lblEndNumber.Location = new System.Drawing.Point(3, 68);
            this.lblEndNumber.Name = "lblEndNumber";
            this.lblEndNumber.Size = new System.Drawing.Size(92, 20);
            this.lblEndNumber.TabIndex = 2;
            this.lblEndNumber.Text = "End Number";
            // 
            // panel8
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel8, 2);
            this.panel8.Controls.Add(this.txtPrintSeriesId);
            this.panel8.Controls.Add(this.btnCancel);
            this.panel8.Controls.Add(this.brnSubmit);
            this.panel8.Controls.Add(this.btnRefresh);
            this.panel8.Location = new System.Drawing.Point(3, 105);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(378, 47);
            this.panel8.TabIndex = 8;
            // 
            // txtPrintSeriesId
            // 
            this.txtPrintSeriesId.Enabled = false;
            this.txtPrintSeriesId.Location = new System.Drawing.Point(4, 9);
            this.txtPrintSeriesId.Name = "txtPrintSeriesId";
            this.txtPrintSeriesId.Size = new System.Drawing.Size(31, 27);
            this.txtPrintSeriesId.TabIndex = 1;
            this.txtPrintSeriesId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(59, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // brnSubmit
            // 
            this.brnSubmit.Location = new System.Drawing.Point(147, 6);
            this.brnSubmit.Name = "brnSubmit";
            this.brnSubmit.Size = new System.Drawing.Size(123, 38);
            this.brnSubmit.TabIndex = 0;
            this.brnSubmit.Text = "&Add / Update";
            this.brnSubmit.UseVisualStyleBackColor = true;
            this.brnSubmit.Click += new System.EventHandler(this.brnSubmit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(276, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 38);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbGivenTo
            // 
            this.cmbGivenTo.DisplayMember = "LoginId";
            this.cmbGivenTo.FormattingEnabled = true;
            this.cmbGivenTo.Location = new System.Drawing.Point(130, 3);
            this.cmbGivenTo.Name = "cmbGivenTo";
            this.cmbGivenTo.Size = new System.Drawing.Size(195, 28);
            this.cmbGivenTo.TabIndex = 9;
            this.cmbGivenTo.ValueMember = "Id";
            this.cmbGivenTo.SelectedIndexChanged += new System.EventHandler(this.cmbGivenTo_SelectedIndexChanged);
            // 
            // txtStartNumber
            // 
            this.txtStartNumber.Location = new System.Drawing.Point(130, 37);
            this.txtStartNumber.Name = "txtStartNumber";
            this.txtStartNumber.Size = new System.Drawing.Size(195, 27);
            this.txtStartNumber.TabIndex = 10;
            // 
            // txtEndNumber
            // 
            this.txtEndNumber.Location = new System.Drawing.Point(130, 71);
            this.txtEndNumber.Name = "txtEndNumber";
            this.txtEndNumber.Size = new System.Drawing.Size(195, 27);
            this.txtEndNumber.TabIndex = 11;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(eTemple.Data.Models.Employee);
            // 
            // printSeriesBindingSource
            // 
            this.printSeriesBindingSource.DataSource = typeof(eTemple.Data.Models.PrintSeries);
            // 
            // PrintSeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1058, 551);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrintSeriesForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintSeries";
            this.Load += new System.EventHandler(this.PrintSeries_Load_1);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintSeriesBalance)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintSeries)).EndInit();
            this.panel6.ResumeLayout(false);
            this.gpbPrintSeries.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printSeriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvPrintSeries;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox gpbPrintSeries;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblStartNumber;
        private System.Windows.Forms.Label lblEndNumber;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button brnSubmit;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ComboBox cmbGivenTo;
        private System.Windows.Forms.TextBox txtPrintSeriesId;
        private System.Windows.Forms.TextBox txtStartNumber;
        private System.Windows.Forms.TextBox txtEndNumber;
        private System.Windows.Forms.BindingSource printSeriesBindingSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewLinkColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivenTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintseriesStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintseriesEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivenBy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker currentDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPrintSeriesBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGivenTokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.ComboBox cmbUsername;
    }
}