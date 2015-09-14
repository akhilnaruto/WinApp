namespace eTemple.UI
{
    partial class Designations
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
            this.gpbDesignations = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDesignationID = new System.Windows.Forms.Label();
            this.lblDesignationName = new System.Windows.Forms.Label();
            this.txtDesignationID = new System.Windows.Forms.TextBox();
            this.txtDesignationName = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDesignation = new System.Windows.Forms.DataGridView();
            this.DesignationID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DesignationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbDesignations.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDesignations
            // 
            this.gpbDesignations.Controls.Add(this.tableLayoutPanel1);
            this.gpbDesignations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbDesignations.Location = new System.Drawing.Point(0, 0);
            this.gpbDesignations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDesignations.Name = "gpbDesignations";
            this.gpbDesignations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbDesignations.Size = new System.Drawing.Size(875, 172);
            this.gpbDesignations.TabIndex = 0;
            this.gpbDesignations.TabStop = false;
            this.gpbDesignations.Text = "Add / Update Designations";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.31124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.68876F));
            this.tableLayoutPanel1.Controls.Add(this.lblDesignationID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDesignationName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDesignationID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDesignationName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(209, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDesignationID
            // 
            this.lblDesignationID.AutoSize = true;
            this.lblDesignationID.Location = new System.Drawing.Point(4, 0);
            this.lblDesignationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignationID.Name = "lblDesignationID";
            this.lblDesignationID.Size = new System.Drawing.Size(108, 20);
            this.lblDesignationID.TabIndex = 0;
            this.lblDesignationID.Text = "Designation ID";
            // 
            // lblDesignationName
            // 
            this.lblDesignationName.AutoSize = true;
            this.lblDesignationName.Location = new System.Drawing.Point(4, 37);
            this.lblDesignationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignationName.Name = "lblDesignationName";
            this.lblDesignationName.Size = new System.Drawing.Size(133, 20);
            this.lblDesignationName.TabIndex = 1;
            this.lblDesignationName.Text = "Designation Name";
            // 
            // txtDesignationID
            // 
            this.txtDesignationID.Enabled = false;
            this.txtDesignationID.Location = new System.Drawing.Point(172, 5);
            this.txtDesignationID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesignationID.Name = "txtDesignationID";
            this.txtDesignationID.Size = new System.Drawing.Size(232, 27);
            this.txtDesignationID.TabIndex = 2;
            // 
            // txtDesignationName
            // 
            this.txtDesignationName.Location = new System.Drawing.Point(172, 42);
            this.txtDesignationName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesignationName.Name = "txtDesignationName";
            this.txtDesignationName.Size = new System.Drawing.Size(232, 27);
            this.txtDesignationName.TabIndex = 3;
            // 
            // panel8
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel8, 2);
            this.panel8.Controls.Add(this.btnCancel);
            this.panel8.Controls.Add(this.btnRefresh);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Location = new System.Drawing.Point(4, 79);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(455, 46);
            this.panel8.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(14, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(363, 7);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 34);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Add / Update Designations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDesignation
            // 
            this.dgvDesignation.AllowUserToAddRows = false;
            this.dgvDesignation.AllowUserToDeleteRows = false;
            this.dgvDesignation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesignation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesignationID,
            this.DesignationName});
            this.dgvDesignation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDesignation.Location = new System.Drawing.Point(0, 0);
            this.dgvDesignation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDesignation.Name = "dgvDesignation";
            this.dgvDesignation.ReadOnly = true;
            this.dgvDesignation.Size = new System.Drawing.Size(875, 549);
            this.dgvDesignation.TabIndex = 0;
            this.dgvDesignation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesignation_CellContentClick);
            // 
            // DesignationID
            // 
            this.DesignationID.DataPropertyName = "Id";
            this.DesignationID.FillWeight = 15F;
            this.DesignationID.HeaderText = "Designation ID";
            this.DesignationID.Name = "DesignationID";
            this.DesignationID.ReadOnly = true;
            this.DesignationID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DesignationID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DesignationName
            // 
            this.DesignationName.DataPropertyName = "Name";
            this.DesignationName.FillWeight = 85F;
            this.DesignationName.HeaderText = "Designation Name";
            this.DesignationName.Name = "DesignationName";
            this.DesignationName.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(875, 721);
            this.panel5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDesignation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 549);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpbDesignations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 172);
            this.panel1.TabIndex = 1;
            // 
            // Designations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(895, 741);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Designations";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Designations";
            this.Load += new System.EventHandler(this.Designations_Load);
            this.gpbDesignations.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDesignations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDesignationID;
        private System.Windows.Forms.Label lblDesignationName;
        private System.Windows.Forms.TextBox txtDesignationID;
        private System.Windows.Forms.TextBox txtDesignationName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDesignation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewLinkColumn DesignationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;


    }
}