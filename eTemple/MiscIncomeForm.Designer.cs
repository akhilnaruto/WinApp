namespace eTemple.UI
{
    partial class MiscIncomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpPerformDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmountDescription = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtAmountDescription = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMiscIncomes = new System.Windows.Forms.DataGridView();
            this.ServiceDailyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePerformDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tblPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiscIncomes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 153);
            this.panel1.TabIndex = 0;
            // 
            // tblPanel1
            // 
            this.tblPanel1.ColumnCount = 4;
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.06061F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0303F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.69697F));
            this.tblPanel1.Controls.Add(this.lblDate, 0, 0);
            this.tblPanel1.Controls.Add(this.dtpPerformDate, 1, 0);
            this.tblPanel1.Controls.Add(this.lblAmountDescription, 2, 0);
            this.tblPanel1.Controls.Add(this.lblAmount, 0, 1);
            this.tblPanel1.Controls.Add(this.txtTotalCost, 1, 1);
            this.tblPanel1.Controls.Add(this.txtAmountDescription, 3, 0);
            this.tblPanel1.Controls.Add(this.flowLayoutPanel1, 2, 2);
            this.tblPanel1.Controls.Add(this.txtId, 0, 2);
            this.tblPanel1.Location = new System.Drawing.Point(153, 14);
            this.tblPanel1.Name = "tblPanel1";
            this.tblPanel1.RowCount = 3;
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanel1.Size = new System.Drawing.Size(687, 133);
            this.tblPanel1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 21);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // dtpPerformDate
            // 
            this.dtpPerformDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPerformDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPerformDate.Location = new System.Drawing.Point(77, 7);
            this.dtpPerformDate.Name = "dtpPerformDate";
            this.dtpPerformDate.Size = new System.Drawing.Size(141, 29);
            this.dtpPerformDate.TabIndex = 1;
            // 
            // lblAmountDescription
            // 
            this.lblAmountDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountDescription.AutoSize = true;
            this.lblAmountDescription.Location = new System.Drawing.Point(224, 11);
            this.lblAmountDescription.Name = "lblAmountDescription";
            this.lblAmountDescription.Size = new System.Drawing.Size(182, 21);
            this.lblAmountDescription.TabIndex = 2;
            this.lblAmountDescription.Text = "Amount Description";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(3, 55);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(68, 21);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCost.Location = new System.Drawing.Point(77, 51);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(141, 29);
            this.txtTotalCost.TabIndex = 4;
            // 
            // txtAmountDescription
            // 
            this.txtAmountDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmountDescription.Location = new System.Drawing.Point(412, 3);
            this.txtAmountDescription.Multiline = true;
            this.txtAmountDescription.Name = "txtAmountDescription";
            this.tblPanel1.SetRowSpan(this.txtAmountDescription, 2);
            this.txtAmountDescription.Size = new System.Drawing.Size(272, 82);
            this.txtAmountDescription.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.tblPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(224, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 39);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(123, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 34);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(251, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 91);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(37, 29);
            this.txtId.TabIndex = 7;
            this.txtId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMiscIncomes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 371);
            this.panel2.TabIndex = 1;
            // 
            // dgvMiscIncomes
            // 
            this.dgvMiscIncomes.AllowUserToAddRows = false;
            this.dgvMiscIncomes.AllowUserToDeleteRows = false;
            this.dgvMiscIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMiscIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiscIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceDailyNumber,
            this.ServicePerformDate,
            this.AmountDescription,
            this.TotalCost,
            this.Created_By});
            this.dgvMiscIncomes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMiscIncomes.Location = new System.Drawing.Point(0, 0);
            this.dgvMiscIncomes.Name = "dgvMiscIncomes";
            this.dgvMiscIncomes.Size = new System.Drawing.Size(1047, 371);
            this.dgvMiscIncomes.TabIndex = 0;
            this.dgvMiscIncomes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMiscIncomes_CellContentClick);
            // 
            // ServiceDailyNumber
            // 
            this.ServiceDailyNumber.DataPropertyName = "ServiceDailyNumber";
            this.ServiceDailyNumber.FillWeight = 10F;
            this.ServiceDailyNumber.HeaderText = "S.No";
            this.ServiceDailyNumber.Name = "ServiceDailyNumber";
            // 
            // ServicePerformDate
            // 
            this.ServicePerformDate.DataPropertyName = "ServicePerformDate";
            this.ServicePerformDate.FillWeight = 15F;
            this.ServicePerformDate.HeaderText = "Date";
            this.ServicePerformDate.Name = "ServicePerformDate";
            // 
            // AmountDescription
            // 
            this.AmountDescription.DataPropertyName = "AmountDescription";
            this.AmountDescription.FillWeight = 35F;
            this.AmountDescription.HeaderText = "Description";
            this.AmountDescription.Name = "AmountDescription";
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "TotalCost";
            this.TotalCost.FillWeight = 20F;
            this.TotalCost.HeaderText = "Amount";
            this.TotalCost.Name = "TotalCost";
            // 
            // Created_By
            // 
            this.Created_By.DataPropertyName = "Created_By";
            this.Created_By.FillWeight = 20F;
            this.Created_By.HeaderText = "Entered By";
            this.Created_By.Name = "Created_By";
            // 
            // MiscIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MiscIncomeForm";
            this.Text = "MiscIncomeForm";
            this.Load += new System.EventHandler(this.MiscIncomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.tblPanel1.ResumeLayout(false);
            this.tblPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiscIncomes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblPanel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpPerformDate;
        private System.Windows.Forms.Label lblAmountDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtAmountDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMiscIncomes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDailyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePerformDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By;
    }
}