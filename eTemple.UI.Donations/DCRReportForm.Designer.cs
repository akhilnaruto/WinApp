namespace eTemple.UI.Donations
{
    partial class DCRReportForm
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
            this.DonorTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorReportDataSet = new eTemple.UI.Donations.DonorReportDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.donorReportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DCR_ValuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DonorTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCR_ValuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DonorTableBindingSource
            // 
            this.DonorTableBindingSource.DataMember = "DonorTable";
            this.DonorTableBindingSource.DataSource = this.donorReportDataSet;
            // 
            // donorReportDataSet
            // 
            this.donorReportDataSet.DataSetName = "DonorReportDataSet";
            this.donorReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DCRDataSet";
            reportDataSource1.Value = this.DCR_ValuesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eTemple.UI.Donations.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(820, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // donorReportDataSetBindingSource
            // 
            this.donorReportDataSetBindingSource.DataSource = this.donorReportDataSet;
            this.donorReportDataSetBindingSource.Position = 0;
            // 
            // DCR_ValuesBindingSource
            // 
            this.DCR_ValuesBindingSource.DataMember = "DCR Values";
            this.DCR_ValuesBindingSource.DataSource = this.donorReportDataSet;
            // 
            // DonorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(820, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DonorReportForm";
            this.Text = "DonorReportForm";
            this.Load += new System.EventHandler(this.DonorReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonorTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCR_ValuesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource donorReportDataSetBindingSource;
        private DonorReportDataSet donorReportDataSet;
        private System.Windows.Forms.BindingSource DonorTableBindingSource;
        private System.Windows.Forms.BindingSource DCR_ValuesBindingSource;
    }
}