namespace eTemple.UI
{
    public partial class TokensForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.gvTokens = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.mtxtServiceNumber = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAmountGiven = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReturnChange = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDevoteeNames = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dgvDevotees = new System.Windows.Forms.DataGridView();
            this.TokenIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefix = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DevoteeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevoteeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gothram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindDevotees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoorNo = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMandal = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.formValidator = new eTemple.Components.Validator(this.components);
            this.btnClearAndNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTokens)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevotees)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(540, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tokens Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.cmbServices, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCost, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddService, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.gvTokens, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalCost, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalQuantity, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.mtxtServiceNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbServices
            // 
            this.cmbServices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbServices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(68, 32);
            this.cmbServices.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(261, 29);
            this.cmbServices.TabIndex = 1;
            this.cmbServices.TabStop = false;
            this.cmbServices.SelectedIndexChanged += new System.EventHandler(this.cmbServices_SelectedIndexChanged);
            this.cmbServices.SelectionChangeCommitted += new System.EventHandler(this.cmbServices_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.formValidator.SetCompareOperator(this.txtQuantity, eTemple.Components.ValidationCompareOperator.GreaterThanEqual);
            this.formValidator.SetDataType(this.txtQuantity, eTemple.Components.ValidationDataType.Integer);
            this.txtQuantity.Location = new System.Drawing.Point(334, 32);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.formValidator.SetRangeOfLowerBound(this.txtQuantity, "1");
            this.txtQuantity.Size = new System.Drawing.Size(62, 29);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "1";
            this.formValidator.SetType(this.txtQuantity, eTemple.Components.ValidationType.Required);
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(400, 32);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(62, 29);
            this.txtCost.TabIndex = 3;
            this.txtCost.Enter += new System.EventHandler(this.txtCost_Enter);
            this.txtCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyUp);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(466, 32);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(62, 28);
            this.btnAddService.TabIndex = 4;
            this.btnAddService.Text = "&Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // gvTokens
            // 
            this.gvTokens.AllowUserToAddRows = false;
            this.gvTokens.AllowUserToDeleteRows = false;
            this.gvTokens.AllowUserToResizeColumns = false;
            this.gvTokens.AllowUserToResizeRows = false;
            this.gvTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTokens.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTokens.ColumnHeadersVisible = false;
            this.gvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.tableLayoutPanel1.SetColumnSpan(this.gvTokens, 5);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTokens.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvTokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTokens.GridColor = System.Drawing.SystemColors.Control;
            this.gvTokens.Location = new System.Drawing.Point(4, 67);
            this.gvTokens.Margin = new System.Windows.Forms.Padding(4);
            this.gvTokens.MultiSelect = false;
            this.gvTokens.Name = "gvTokens";
            this.gvTokens.ReadOnly = true;
            this.gvTokens.RowHeadersVisible = false;
            this.gvTokens.RowHeadersWidth = 40;
            this.gvTokens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvTokens.RowTemplate.DividerHeight = 1;
            this.gvTokens.RowTemplate.Height = 40;
            this.gvTokens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvTokens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTokens.Size = new System.Drawing.Size(524, 246);
            this.gvTokens.TabIndex = 5;
            this.gvTokens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTokens_CellContentClick);
            this.gvTokens.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvTokens_DataBindingComplete);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ServiceName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Service";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.FillWeight = 16.67F;
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TotalCost";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.FillWeight = 16.67F;
            this.Column4.HeaderText = "Cost";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.FillWeight = 16.67F;
            this.Column5.HeaderText = "Action";
            this.Column5.MinimumWidth = 100;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "Delete";
            this.Column5.ToolTipText = "Delete item !";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cost";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(400, 323);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(62, 29);
            this.txtTotalCost.TabIndex = 21;
            this.txtTotalCost.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "S&ervice";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.formValidator.SetCompareOperator(this.txtTotalQuantity, eTemple.Components.ValidationCompareOperator.GreaterThanEqual);
            this.formValidator.SetDataType(this.txtTotalQuantity, eTemple.Components.ValidationDataType.Integer);
            this.txtTotalQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQuantity.Location = new System.Drawing.Point(334, 323);
            this.txtTotalQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.formValidator.SetRangeOfLowerBound(this.txtTotalQuantity, "1");
            this.txtTotalQuantity.Size = new System.Drawing.Size(62, 29);
            this.txtTotalQuantity.TabIndex = 20;
            this.txtTotalQuantity.TabStop = false;
            this.formValidator.SetType(this.txtTotalQuantity, eTemple.Components.ValidationType.Required);
            // 
            // mtxtServiceNumber
            // 
            this.mtxtServiceNumber.HidePromptOnLeave = true;
            this.mtxtServiceNumber.Location = new System.Drawing.Point(2, 32);
            this.mtxtServiceNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtxtServiceNumber.Mask = "000";
            this.mtxtServiceNumber.Name = "mtxtServiceNumber";
            this.mtxtServiceNumber.Size = new System.Drawing.Size(62, 29);
            this.mtxtServiceNumber.TabIndex = 0;
            this.mtxtServiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtServiceNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtServiceNumber.Enter += new System.EventHandler(this.mtxtServiceNumber_Enter);
            this.mtxtServiceNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxtServiceNumber_KeyUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 5);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel3.Controls.Add(this.txtAmountGiven, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtReturnChange, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSubmit, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 362);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(526, 44);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // txtAmountGiven
            // 
            this.txtAmountGiven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formValidator.SetDataType(this.txtAmountGiven, eTemple.Components.ValidationDataType.Double);
            this.txtAmountGiven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountGiven.Location = new System.Drawing.Point(104, 7);
            this.txtAmountGiven.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAmountGiven.Name = "txtAmountGiven";
            this.txtAmountGiven.Size = new System.Drawing.Size(72, 29);
            this.txtAmountGiven.TabIndex = 16;
            this.txtAmountGiven.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmountGiven_KeyUp);
            this.txtAmountGiven.Leave += new System.EventHandler(this.txtAmountGiven_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 44);
            this.label11.TabIndex = 14;
            this.label11.Text = "Amount &Given";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(200, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 44);
            this.label12.TabIndex = 16;
            this.label12.Text = "Change";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReturnChange
            // 
            this.txtReturnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formValidator.SetCompareOperator(this.txtReturnChange, eTemple.Components.ValidationCompareOperator.GreaterThanEqual);
            this.formValidator.SetDataType(this.txtReturnChange, eTemple.Components.ValidationDataType.Integer);
            this.txtReturnChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnChange.Location = new System.Drawing.Point(276, 7);
            this.txtReturnChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtReturnChange.Name = "txtReturnChange";
            this.formValidator.SetRangeOfLowerBound(this.txtReturnChange, "1");
            this.txtReturnChange.ReadOnly = true;
            this.txtReturnChange.Size = new System.Drawing.Size(72, 29);
            this.txtReturnChange.TabIndex = 17;
            this.txtReturnChange.TabStop = false;
            this.formValidator.SetType(this.txtReturnChange, eTemple.Components.ValidationType.Required);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Location = new System.Drawing.Point(373, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 38);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "&Submit / Print";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(571, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(731, 441);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Devotee Details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblDevoteeNames, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtCity, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblCity, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblPhoneNumber, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPhoneNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvDevotees, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnFindDevotees, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDoorNo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtArea, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtEmail, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtMandal, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDistrict, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtState, 4, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 27);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(723, 409);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblDevoteeNames
            // 
            this.lblDevoteeNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDevoteeNames.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblDevoteeNames, 2);
            this.lblDevoteeNames.Location = new System.Drawing.Point(2, 176);
            this.lblDevoteeNames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevoteeNames.Name = "lblDevoteeNames";
            this.lblDevoteeNames.Size = new System.Drawing.Size(346, 21);
            this.lblDevoteeNames.TabIndex = 17;
            this.lblDevoteeNames.Text = "&Devotee Names";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Location = new System.Drawing.Point(177, 105);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(171, 29);
            this.txtCity.TabIndex = 10;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(2, 108);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(171, 21);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(2, 6);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(171, 21);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "P&hone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(177, 3);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(171, 29);
            this.txtPhoneNumber.TabIndex = 6;
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhoneNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyUp);
            // 
            // dgvDevotees
            // 
            this.dgvDevotees.AllowUserToAddRows = false;
            this.dgvDevotees.AllowUserToDeleteRows = false;
            this.dgvDevotees.AllowUserToResizeColumns = false;
            this.dgvDevotees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevotees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDevotees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevotees.ColumnHeadersVisible = false;
            this.dgvDevotees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TokenIndex,
            this.ServiceName,
            this.Prefix,
            this.DevoteeId,
            this.DevoteeName,
            this.Gothram});
            this.tableLayoutPanel2.SetColumnSpan(this.dgvDevotees, 5);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevotees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevotees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevotees.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDevotees.Location = new System.Drawing.Point(2, 207);
            this.dgvDevotees.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDevotees.Name = "dgvDevotees";
            this.dgvDevotees.RowHeadersVisible = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.dgvDevotees.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevotees.RowTemplate.Height = 40;
            this.dgvDevotees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDevotees.Size = new System.Drawing.Size(719, 199);
            this.dgvDevotees.TabIndex = 15;
            this.dgvDevotees.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevotees_CellEndEdit);
            this.dgvDevotees.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDevotees_DataError);
            this.dgvDevotees.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDevotees_EditingControlShowing);
            this.dgvDevotees.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevotees_RowLeave);
            // 
            // TokenIndex
            // 
            this.TokenIndex.DataPropertyName = "TokenIndex";
            this.TokenIndex.FillWeight = 5F;
            this.TokenIndex.HeaderText = "#";
            this.TokenIndex.MinimumWidth = 20;
            this.TokenIndex.Name = "TokenIndex";
            this.TokenIndex.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.FillWeight = 20F;
            this.ServiceName.HeaderText = "ServiceName";
            this.ServiceName.MinimumWidth = 50;
            this.ServiceName.Name = "ServiceName";
            // 
            // Prefix
            // 
            this.Prefix.DataPropertyName = "Prefix";
            this.Prefix.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Prefix.FillWeight = 15F;
            this.Prefix.HeaderText = "Prefix";
            this.Prefix.MinimumWidth = 50;
            this.Prefix.Name = "Prefix";
            this.Prefix.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Prefix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DevoteeId
            // 
            this.DevoteeId.DataPropertyName = "Id";
            this.DevoteeId.FillWeight = 10F;
            this.DevoteeId.HeaderText = "Id";
            this.DevoteeId.MinimumWidth = 2;
            this.DevoteeId.Name = "DevoteeId";
            this.DevoteeId.ReadOnly = true;
            this.DevoteeId.Visible = false;
            // 
            // DevoteeName
            // 
            this.DevoteeName.DataPropertyName = "DevoteeName";
            this.DevoteeName.FillWeight = 35F;
            this.DevoteeName.HeaderText = "Devotee Name";
            this.DevoteeName.MinimumWidth = 100;
            this.DevoteeName.Name = "DevoteeName";
            this.DevoteeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Gothram
            // 
            this.Gothram.DataPropertyName = "Gothram";
            this.Gothram.FillWeight = 20F;
            this.Gothram.HeaderText = "Gothram";
            this.Gothram.MinimumWidth = 100;
            this.Gothram.Name = "Gothram";
            this.Gothram.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnFindDevotees
            // 
            this.btnFindDevotees.Location = new System.Drawing.Point(373, 3);
            this.btnFindDevotees.Name = "btnFindDevotees";
            this.btnFindDevotees.Size = new System.Drawing.Size(75, 28);
            this.btnFindDevotees.TabIndex = 7;
            this.btnFindDevotees.Text = "&Find";
            this.btnFindDevotees.UseVisualStyleBackColor = true;
            this.btnFindDevotees.Click += new System.EventHandler(this.btnFindDevotees_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Door No";
            // 
            // txtDoorNo
            // 
            this.txtDoorNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoorNo.Location = new System.Drawing.Point(177, 37);
            this.txtDoorNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDoorNo.Name = "txtDoorNo";
            this.txtDoorNo.Size = new System.Drawing.Size(171, 29);
            this.txtDoorNo.TabIndex = 8;
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Location = new System.Drawing.Point(177, 71);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(171, 29);
            this.txtArea.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Area";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mandal";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "District";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtEmail, 4);
            this.txtEmail.Location = new System.Drawing.Point(177, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(544, 29);
            this.txtEmail.TabIndex = 14;
            // 
            // txtMandal
            // 
            this.txtMandal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMandal.Location = new System.Drawing.Point(547, 37);
            this.txtMandal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMandal.Name = "txtMandal";
            this.txtMandal.Size = new System.Drawing.Size(174, 29);
            this.txtMandal.TabIndex = 11;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDistrict.Location = new System.Drawing.Point(547, 71);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(174, 29);
            this.txtDistrict.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtState.Location = new System.Drawing.Point(547, 105);
            this.txtState.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(174, 29);
            this.txtState.TabIndex = 13;
            // 
            // formValidator
            // 
            this.formValidator.Form = this;
            // 
            // btnClearAndNew
            // 
            this.btnClearAndNew.Location = new System.Drawing.Point(17, 6);
            this.btnClearAndNew.Name = "btnClearAndNew";
            this.btnClearAndNew.Size = new System.Drawing.Size(129, 35);
            this.btnClearAndNew.TabIndex = 31;
            this.btnClearAndNew.Text = "&Clear and New";
            this.btnClearAndNew.UseVisualStyleBackColor = true;
            this.btnClearAndNew.Click += new System.EventHandler(this.btnClearAndNew_Click);
            // 
            // TokensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 629);
            this.Controls.Add(this.btnClearAndNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TokensForm";
            this.Text = "Service Tokens";
            this.Load += new System.EventHandler(this.TokensForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTokens)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevotees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnAddService;
        private Components.Validator formValidator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.DataGridView gvTokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.MaskedTextBox mtxtServiceNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DataGridView dgvDevotees;
        private System.Windows.Forms.Button btnFindDevotees;
        private System.Windows.Forms.TextBox txtDoorNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMandal;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtAmountGiven;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReturnChange;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TokenIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevoteeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevoteeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gothram;
        private System.Windows.Forms.Label lblDevoteeNames;
        private System.Windows.Forms.Button btnClearAndNew;
    }
}