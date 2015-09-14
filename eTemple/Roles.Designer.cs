namespace eTemple.UI
{
    partial class Roles
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gpbRoles = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblRolename = new System.Windows.Forms.Label();
            this.lblRoleID = new System.Windows.Forms.Label();
            this.txtRoleId = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.panel6.SuspendLayout();
            this.gpbRoles.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1362, 741);
            this.panel4.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvRoles);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 228);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1362, 513);
            this.panel7.TabIndex = 1;
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.Location = new System.Drawing.Point(0, 0);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(1362, 513);
            this.dgvRoles.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gpbRoles);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1362, 228);
            this.panel6.TabIndex = 0;
            // 
            // gpbRoles
            // 
            this.gpbRoles.Controls.Add(this.tableLayoutPanel1);
            this.gpbRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbRoles.Location = new System.Drawing.Point(0, 0);
            this.gpbRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbRoles.Name = "gpbRoles";
            this.gpbRoles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbRoles.Size = new System.Drawing.Size(1362, 228);
            this.gpbRoles.TabIndex = 0;
            this.gpbRoles.TabStop = false;
            this.gpbRoles.Text = "Roles Details";
            this.gpbRoles.Enter += new System.EventHandler(this.gpbRoles_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75438F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.24562F));
            this.tableLayoutPanel1.Controls.Add(this.txtRoleName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRolename, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRoleID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRoleId, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(257, 55);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(120, 39);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(199, 27);
            this.txtRoleName.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCancel);
            this.panel8.Controls.Add(this.btnSubmit);
            this.panel8.Controls.Add(this.btnRefresh);
            this.panel8.Location = new System.Drawing.Point(119, 71);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(313, 42);
            this.panel8.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(4, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(92, 0);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 38);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Add / Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(207, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 39);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblRolename
            // 
            this.lblRolename.AutoSize = true;
            this.lblRolename.Location = new System.Drawing.Point(4, 34);
            this.lblRolename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolename.Name = "lblRolename";
            this.lblRolename.Size = new System.Drawing.Size(83, 20);
            this.lblRolename.TabIndex = 0;
            this.lblRolename.Text = "Role Name";
            // 
            // lblRoleID
            // 
            this.lblRoleID.AutoSize = true;
            this.lblRoleID.Location = new System.Drawing.Point(3, 0);
            this.lblRoleID.Name = "lblRoleID";
            this.lblRoleID.Size = new System.Drawing.Size(56, 20);
            this.lblRoleID.TabIndex = 2;
            this.lblRoleID.Text = "Role Id";
            // 
            // txtRoleId
            // 
            this.txtRoleId.Enabled = false;
            this.txtRoleId.Location = new System.Drawing.Point(119, 3);
            this.txtRoleId.Name = "txtRoleId";
            this.txtRoleId.Size = new System.Drawing.Size(200, 27);
            this.txtRoleId.TabIndex = 3;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.panel6.ResumeLayout(false);
            this.gpbRoles.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox gpbRoles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRolename;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRoleID;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCancel;
    }
}