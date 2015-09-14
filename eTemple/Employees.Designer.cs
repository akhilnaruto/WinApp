namespace eTemple.UI
{
    partial class Employees
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.cmbDesignations = new System.Windows.Forms.ComboBox();
            this.chkAllowLogin = new System.Windows.Forms.CheckBox();
            this.lblAllowLogin = new System.Windows.Forms.Label();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIsDeleted = new System.Windows.Forms.Label();
            this.chkIsDeleted = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowLogin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formValidator = new eTemple.Components.Validator(this.components);
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1071, 281);
            this.panel5.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmployeeId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbRoles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRole, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDesignation, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbDesignations, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkAllowLogin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAllowLogin, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLoginId, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLoginId, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIsDeleted, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkIsDeleted, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(144, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 236);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(3, 10);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(92, 20);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmployeeId.Enabled = false;
            this.txtEmployeeId.Location = new System.Drawing.Point(101, 6);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(254, 27);
            this.txtEmployeeId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Location = new System.Drawing.Point(506, 6);
            this.txtName.Name = "txtName";
            this.formValidator.SetRequiredMessage(this.txtName, "Please enter Employee Name !");
            this.txtName.Size = new System.Drawing.Size(295, 27);
            this.txtName.TabIndex = 3;
            this.formValidator.SetType(this.txtName, eTemple.Components.ValidationType.Required);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(411, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // cmbRoles
            // 
            this.cmbRoles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbRoles.DisplayMember = "Name";
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(101, 49);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(254, 28);
            this.cmbRoles.TabIndex = 4;
            this.formValidator.SetType(this.cmbRoles, eTemple.Components.ValidationType.Required);
            this.cmbRoles.ValueMember = "Id";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(3, 50);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role";
            // 
            // lblDesignation
            // 
            this.lblDesignation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(411, 50);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(89, 20);
            this.lblDesignation.TabIndex = 6;
            this.lblDesignation.Text = "Designation";
            // 
            // cmbDesignations
            // 
            this.cmbDesignations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDesignations.DisplayMember = "Name";
            this.cmbDesignations.FormattingEnabled = true;
            this.cmbDesignations.Location = new System.Drawing.Point(506, 49);
            this.cmbDesignations.Name = "cmbDesignations";
            this.cmbDesignations.Size = new System.Drawing.Size(295, 28);
            this.cmbDesignations.TabIndex = 7;
            this.formValidator.SetType(this.cmbDesignations, eTemple.Components.ValidationType.Required);
            this.cmbDesignations.ValueMember = "Id";
            // 
            // chkAllowLogin
            // 
            this.chkAllowLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAllowLogin.AutoSize = true;
            this.chkAllowLogin.Location = new System.Drawing.Point(101, 93);
            this.chkAllowLogin.Name = "chkAllowLogin";
            this.chkAllowLogin.Size = new System.Drawing.Size(15, 14);
            this.chkAllowLogin.TabIndex = 9;
            this.chkAllowLogin.UseVisualStyleBackColor = true;
            // 
            // lblAllowLogin
            // 
            this.lblAllowLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAllowLogin.AutoSize = true;
            this.lblAllowLogin.Location = new System.Drawing.Point(3, 90);
            this.lblAllowLogin.Name = "lblAllowLogin";
            this.lblAllowLogin.Size = new System.Drawing.Size(88, 20);
            this.lblAllowLogin.TabIndex = 8;
            this.lblAllowLogin.Text = "Allow Login";
            // 
            // lblLoginId
            // 
            this.lblLoginId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Location = new System.Drawing.Point(3, 130);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(63, 20);
            this.lblLoginId.TabIndex = 10;
            this.lblLoginId.Text = "Login Id";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLoginId.Location = new System.Drawing.Point(101, 126);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(254, 27);
            this.txtLoginId.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(506, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(295, 27);
            this.txtPassword.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(411, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblIsDeleted
            // 
            this.lblIsDeleted.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIsDeleted.AutoSize = true;
            this.lblIsDeleted.Location = new System.Drawing.Point(411, 90);
            this.lblIsDeleted.Name = "lblIsDeleted";
            this.lblIsDeleted.Size = new System.Drawing.Size(76, 20);
            this.lblIsDeleted.TabIndex = 14;
            this.lblIsDeleted.Text = "Is Deleted";
            // 
            // chkIsDeleted
            // 
            this.chkIsDeleted.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIsDeleted.AutoSize = true;
            this.chkIsDeleted.Location = new System.Drawing.Point(506, 93);
            this.chkIsDeleted.Name = "chkIsDeleted";
            this.chkIsDeleted.Size = new System.Drawing.Size(15, 14);
            this.chkIsDeleted.TabIndex = 15;
            this.chkIsDeleted.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.panel7, 5);
            this.panel7.Controls.Add(this.btnRefresh);
            this.panel7.Controls.Add(this.btnCancel);
            this.panel7.Controls.Add(this.btnSubmit);
            this.panel7.Location = new System.Drawing.Point(191, 163);
            this.panel7.Name = "panel7";
            this.tableLayoutPanel1.SetRowSpan(this.panel7, 2);
            this.panel7.Size = new System.Drawing.Size(437, 50);
            this.panel7.TabIndex = 16;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(304, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 36);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(29, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(170, 7);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 36);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "A&dd \\ Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvEmployees);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(10, 291);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1071, 440);
            this.panel6.TabIndex = 5;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeName,
            this.Role,
            this.Designation,
            this.AllowLogin,
            this.IsDeleted,
            this.LoginId});
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(1071, 440);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "Id";
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "Name";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "RoleName";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "DesignationName";
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // AllowLogin
            // 
            this.AllowLogin.DataPropertyName = "AllowLogin";
            this.AllowLogin.HeaderText = "Allow Login";
            this.AllowLogin.Name = "AllowLogin";
            this.AllowLogin.ReadOnly = true;
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "Is Deleted";
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.ReadOnly = true;
            // 
            // LoginId
            // 
            this.LoginId.DataPropertyName = "LoginId";
            this.LoginId.HeaderText = "LoginId";
            this.LoginId.Name = "LoginId";
            this.LoginId.ReadOnly = true;
            // 
            // formValidator
            // 
            this.formValidator.Form = this;
            // 
            // Employees
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1091, 741);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employees";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.ComboBox cmbDesignations;
        private System.Windows.Forms.CheckBox chkAllowLogin;
        private System.Windows.Forms.Label lblAllowLogin;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIsDeleted;
        private System.Windows.Forms.CheckBox chkIsDeleted;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewLinkColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowLogin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginId;
        private System.Windows.Forms.Button btnRefresh;
        private Components.Validator formValidator;

    }
}