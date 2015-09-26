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
using System.Drawing.Printing;


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
            PageSettings pg = new PageSettings();
            //pg.Margins.Top = 0;
            //pg.Margins.Bottom = 0;
            //pg.Margins.Left = 0;
            //pg.Margins.Right = 0;
            PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.Legal;
            pg.PaperSize = size;
            reportViewer1.SetPageSettings(pg);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
