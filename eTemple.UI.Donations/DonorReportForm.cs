using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace eTemple.UI.Donations
{
    public partial class DonorReportForm : Form
    {
        public DataTable DonorRecs = null;
        public DataTable DonorVals = null;
        public DonorReportForm(DataTable oDonorRecs, DataTable oDonorValues)
        {
            InitializeComponent();
            DonorRecs = oDonorRecs;
            DonorVals = oDonorValues;
        }

        private void DonorReportForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Donors", DonorRecs);
            ReportDataSource rds1 = new ReportDataSource("DonorValues", DonorVals);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
