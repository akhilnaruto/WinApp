namespace eTemple.UI.Donations
{
    partial class DailyAnnadanam
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
            this.txtGothram = new System.Windows.Forms.TextBox();
            this.lblGothram = new System.Windows.Forms.Label();
            this.txtNameOn = new System.Windows.Forms.TextBox();
            this.lblNameOn = new System.Windows.Forms.Label();
            this.txtOccassion = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGothram
            // 
            this.txtGothram.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtGothram.Location = new System.Drawing.Point(443, 169);
            this.txtGothram.Name = "txtGothram";
            this.txtGothram.Size = new System.Drawing.Size(200, 27);
            this.txtGothram.TabIndex = 26;
            // 
            // lblGothram
            // 
            this.lblGothram.AutoSize = true;
            this.lblGothram.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblGothram.Location = new System.Drawing.Point(12, 169);
            this.lblGothram.Name = "lblGothram";
            this.lblGothram.Size = new System.Drawing.Size(67, 20);
            this.lblGothram.TabIndex = 28;
            this.lblGothram.Text = "Gothram";
            // 
            // txtNameOn
            // 
            this.txtNameOn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNameOn.Location = new System.Drawing.Point(443, 129);
            this.txtNameOn.Name = "txtNameOn";
            this.txtNameOn.Size = new System.Drawing.Size(200, 27);
            this.txtNameOn.TabIndex = 24;
            // 
            // lblNameOn
            // 
            this.lblNameOn.AutoSize = true;
            this.lblNameOn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblNameOn.Location = new System.Drawing.Point(335, 129);
            this.lblNameOn.Name = "lblNameOn";
            this.lblNameOn.Size = new System.Drawing.Size(74, 20);
            this.lblNameOn.TabIndex = 27;
            this.lblNameOn.Text = "Phone No";
            // 
            // txtOccassion
            // 
            this.txtOccassion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtOccassion.Location = new System.Drawing.Point(99, 169);
            this.txtOccassion.Name = "txtOccassion";
            this.txtOccassion.Size = new System.Drawing.Size(200, 27);
            this.txtOccassion.TabIndex = 25;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCountry.Location = new System.Drawing.Point(99, 129);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 27);
            this.txtCountry.TabIndex = 23;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblName.Location = new System.Drawing.Point(12, 129);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(335, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Village Name";
            // 
            // btnAddData
            // 
            this.btnAddData.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddData.Location = new System.Drawing.Point(298, 250);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(96, 27);
            this.btnAddData.TabIndex = 51;
            this.btnAddData.Text = "Add Data";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // DailyAnnadanam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 338);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGothram);
            this.Controls.Add(this.lblGothram);
            this.Controls.Add(this.txtNameOn);
            this.Controls.Add(this.lblNameOn);
            this.Controls.Add(this.txtOccassion);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblName);
            this.Name = "DailyAnnadanam";
            this.Text = "Daily Annadanam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGothram;
        private System.Windows.Forms.Label lblGothram;
        private System.Windows.Forms.TextBox txtNameOn;
        private System.Windows.Forms.Label lblNameOn;
        private System.Windows.Forms.TextBox txtOccassion;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddData;
    }
}