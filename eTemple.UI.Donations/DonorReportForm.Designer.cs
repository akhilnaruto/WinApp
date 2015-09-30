namespace eTemple.UI.Donations
{
    partial class DonorReportForm
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
            ((System.ComponentModel.ISupportInitialize)(this.DonorTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSetBindingSource)).BeginInit();
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
            this.reportViewer1.BackgroundImage = global::eTemple.UI.Donations.Properties.Resources.wood4;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Donors";
            reportDataSource1.Value = this.DonorTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eTemple.UI.Donations.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(963, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // donorReportDataSetBindingSource
            // 
            this.donorReportDataSetBindingSource.DataSource = this.donorReportDataSet;
            this.donorReportDataSetBindingSource.Position = 0;
            // 
            // DonorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(963, 261);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonorReportForm";
            this.Text = "DonorReportForm";
            this.Load += new System.EventHandler(this.DonorReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonorTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorReportDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource donorReportDataSetBindingSource;
        private DonorReportDataSet donorReportDataSet;
        private System.Windows.Forms.BindingSource DonorTableBindingSource;
    }
}