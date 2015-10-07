namespace eTemple.UI.Donations
{
    partial class EnquiryDetailsUI
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
            this.donorIdComboBox = new System.Windows.Forms.ComboBox();
            this.donorNameComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.donorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.phoneNumberComboBox = new System.Windows.Forms.ComboBox();
            this.citiComboBox = new System.Windows.Forms.ComboBox();
            this.mrNumberComboBox = new System.Windows.Forms.ComboBox();
            this.gpbEnquiry = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbEnquiry.SuspendLayout();
            this.SuspendLayout();
            // 
            // donorIdComboBox
            // 
            this.donorIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.donorIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.donorIdComboBox.FormattingEnabled = true;
            this.donorIdComboBox.Location = new System.Drawing.Point(88, 35);
            this.donorIdComboBox.Name = "donorIdComboBox";
            this.donorIdComboBox.Size = new System.Drawing.Size(156, 25);
            this.donorIdComboBox.TabIndex = 2;
            this.donorIdComboBox.SelectedIndexChanged += new System.EventHandler(this.donorIdComboBox_SelectedIndexChanged);
            // 
            // donorNameComboBox
            // 
            this.donorNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.donorNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.donorNameComboBox.FormattingEnabled = true;
            this.donorNameComboBox.Location = new System.Drawing.Point(373, 35);
            this.donorNameComboBox.Name = "donorNameComboBox";
            this.donorNameComboBox.Size = new System.Drawing.Size(156, 21);
            this.donorNameComboBox.TabIndex = 3;
            this.donorNameComboBox.SelectedIndexChanged += new System.EventHandler(this.donorNameComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorId,
            this.surname,
            this.Column1,
            this.address});
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(878, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // donorId
            // 
            this.donorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donorId.HeaderText = "DONOR ID";
            this.donorId.Name = "donorId";
            this.donorId.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surname.HeaderText = "SURNAME";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "NAME";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "ADDRESS";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // phoneNumberComboBox
            // 
            this.phoneNumberComboBox.FormattingEnabled = true;
            this.phoneNumberComboBox.Location = new System.Drawing.Point(673, 35);
            this.phoneNumberComboBox.Name = "phoneNumberComboBox";
            this.phoneNumberComboBox.Size = new System.Drawing.Size(156, 21);
            this.phoneNumberComboBox.TabIndex = 8;
            this.phoneNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.phoneNumberComboBox_SelectedIndexChanged);
            // 
            // citiComboBox
            // 
            this.citiComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.citiComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.citiComboBox.FormattingEnabled = true;
            this.citiComboBox.Location = new System.Drawing.Point(88, 85);
            this.citiComboBox.Name = "citiComboBox";
            this.citiComboBox.Size = new System.Drawing.Size(156, 25);
            this.citiComboBox.TabIndex = 10;
            // 
            // mrNumberComboBox
            // 
            this.mrNumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.mrNumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mrNumberComboBox.FormattingEnabled = true;
            this.mrNumberComboBox.Location = new System.Drawing.Point(361, 85);
            this.mrNumberComboBox.Name = "mrNumberComboBox";
            this.mrNumberComboBox.Size = new System.Drawing.Size(156, 25);
            this.mrNumberComboBox.TabIndex = 12;
            // 
            // gpbEnquiry
            // 
            this.gpbEnquiry.BackgroundImage = global::eTemple.UI.Donations.Properties.Resources.wood4;
            this.gpbEnquiry.Controls.Add(this.label4);
            this.gpbEnquiry.Controls.Add(this.label3);
            this.gpbEnquiry.Controls.Add(this.label2);
            this.gpbEnquiry.Controls.Add(this.label1);
            this.gpbEnquiry.Controls.Add(this.lblServiceType);
            this.gpbEnquiry.Controls.Add(this.mrNumberComboBox);
            this.gpbEnquiry.Controls.Add(this.citiComboBox);
            this.gpbEnquiry.Controls.Add(this.button2);
            this.gpbEnquiry.Controls.Add(this.button1);
            this.gpbEnquiry.Controls.Add(this.donorIdComboBox);
            this.gpbEnquiry.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEnquiry.Location = new System.Drawing.Point(12, -1);
            this.gpbEnquiry.Name = "gpbEnquiry";
            this.gpbEnquiry.Size = new System.Drawing.Size(878, 339);
            this.gpbEnquiry.TabIndex = 13;
            this.gpbEnquiry.TabStop = false;
            this.gpbEnquiry.Text = "Enquiry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "MR NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Donor Name";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(3, 35);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(66, 17);
            this.lblServiceType.TabIndex = 7;
            this.lblServiceType.Text = "Donor ID";
            // 
            // EnquiryDetailsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 340);
            this.Controls.Add(this.phoneNumberComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.donorNameComboBox);
            this.Controls.Add(this.gpbEnquiry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnquiryDetailsUI";
            this.Text = "Enquiry Details";
            this.Load += new System.EventHandler(this.EnquiryDetailsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbEnquiry.ResumeLayout(false);
            this.gpbEnquiry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox donorIdComboBox;
        private System.Windows.Forms.ComboBox donorNameComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox phoneNumberComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.ComboBox citiComboBox;
        private System.Windows.Forms.ComboBox mrNumberComboBox;
        private System.Windows.Forms.GroupBox gpbEnquiry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}