namespace eTemple.UI
{
    partial class HundialsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPerformDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPerformDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvHundial = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ServiceDailyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePerformDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tblPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHundial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.tblPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 89);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHundial);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 431);
            this.panel2.TabIndex = 1;
            // 
            // tblPanel1
            // 
            this.tblPanel1.ColumnCount = 5;
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.63732F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.08279F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.40342F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76216F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.98292F));
            this.tblPanel1.Controls.Add(this.lblPerformDate, 0, 0);
            this.tblPanel1.Controls.Add(this.label1, 2, 0);
            this.tblPanel1.Controls.Add(this.dtpPerformDate, 1, 0);
            this.tblPanel1.Controls.Add(this.txtTotalCost, 3, 0);
            this.tblPanel1.Controls.Add(this.flowLayoutPanel1, 4, 0);
            this.tblPanel1.Location = new System.Drawing.Point(174, 25);
            this.tblPanel1.Name = "tblPanel1";
            this.tblPanel1.RowCount = 1;
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel1.Size = new System.Drawing.Size(761, 42);
            this.tblPanel1.TabIndex = 0;
            // 
            // lblPerformDate
            // 
            this.lblPerformDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerformDate.AutoSize = true;
            this.lblPerformDate.Location = new System.Drawing.Point(3, 10);
            this.lblPerformDate.Name = "lblPerformDate";
            this.lblPerformDate.Size = new System.Drawing.Size(113, 21);
            this.lblPerformDate.TabIndex = 0;
            this.lblPerformDate.Text = "Perform Date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // dtpPerformDate
            // 
            this.dtpPerformDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPerformDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPerformDate.Location = new System.Drawing.Point(122, 6);
            this.dtpPerformDate.Name = "dtpPerformDate";
            this.dtpPerformDate.Size = new System.Drawing.Size(124, 29);
            this.dtpPerformDate.TabIndex = 2;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCost.Location = new System.Drawing.Point(354, 6);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(152, 29);
            this.txtTotalCost.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(84, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(165, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(512, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 36);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dgvHundial
            // 
            this.dgvHundial.AllowUserToAddRows = false;
            this.dgvHundial.AllowUserToDeleteRows = false;
            this.dgvHundial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHundial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHundial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceDailyNumber,
            this.ServicePerformDate,
            this.TotalCost,
            this.CreatedBy});
            this.dgvHundial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHundial.Location = new System.Drawing.Point(0, 0);
            this.dgvHundial.Name = "dgvHundial";
            this.dgvHundial.RowHeadersVisible = false;
            this.dgvHundial.Size = new System.Drawing.Size(1065, 431);
            this.dgvHundial.TabIndex = 0;
            this.dgvHundial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHundial_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(31, 29);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // ServiceDailyNumber
            // 
            this.ServiceDailyNumber.DataPropertyName = "ServiceDailyNumber";
            this.ServiceDailyNumber.FillWeight = 15F;
            this.ServiceDailyNumber.HeaderText = "S.No";
            this.ServiceDailyNumber.Name = "ServiceDailyNumber";
            this.ServiceDailyNumber.ReadOnly = true;
            // 
            // ServicePerformDate
            // 
            this.ServicePerformDate.DataPropertyName = "ServicePerformDate";
            this.ServicePerformDate.FillWeight = 25F;
            this.ServicePerformDate.HeaderText = "On Date";
            this.ServicePerformDate.Name = "ServicePerformDate";
            this.ServicePerformDate.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "TotalCost";
            this.TotalCost.FillWeight = 25F;
            this.TotalCost.HeaderText = "Amount";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "Created_By";
            this.CreatedBy.FillWeight = 35F;
            this.CreatedBy.HeaderText = "Entered By";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            // 
            // HundialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1065, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HundialsForm";
            this.Text = "HundialsForm";
            this.Load += new System.EventHandler(this.HundialsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tblPanel1.ResumeLayout(false);
            this.tblPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHundial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblPanel1;
        private System.Windows.Forms.Label lblPerformDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPerformDate;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvHundial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDailyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePerformDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
    }
}