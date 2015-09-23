namespace eTemple.UI.Donations
{
    partial class AddressForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DonorAddressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DonorReportDataSet = new eTemple.UI.Donations.DonorReportDataSet();
            this.donorReportDataSet1 = new eTemple.UI.Donations.DonorReportDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.donorAddressesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DonorAddressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorAddressesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DonorAddressesBindingSource
            // 
            this.DonorAddressesBindingSource.DataMember = "DonorAddresses";
            this.DonorAddressesBindingSource.DataSource = this.DonorReportDataSet;
            // 
            // DonorReportDataSet
            // 
            this.DonorReportDataSet.DataSetName = "DonorReportDataSet";
            this.DonorReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorReportDataSet1
            // 
            this.donorReportDataSet1.DataSetName = "DonorReportDataSet";
            this.donorReportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.donorAddressesBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eTemple.UI.Donations.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(822, 226);
            this.reportViewer1.TabIndex = 0;
            // 
            // donorAddressesBindingSource1
            // 
            this.donorAddressesBindingSource1.DataMember = "DonorAddresses";
            this.donorAddressesBindingSource1.DataSource = this.DonorReportDataSet;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 226);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonorAddressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonorReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorAddressesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DonorAddressesBindingSource;
        private DonorReportDataSet DonorReportDataSet;
        private DonorReportDataSet donorReportDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource donorAddressesBindingSource1;
    }
}