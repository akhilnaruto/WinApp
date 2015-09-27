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
    public partial class AddressForm : Form
    {
        public DataTable DonorRecs = null;
        public DataTable DonorRecsCount = null;
        public AddressForm(DataTable oDonorRecs)
        {
            InitializeComponent();
            DonorRecs = oDonorRecs;
            DonorRecsCount = new DataTable();
            DonorRecsCount.Columns.Add("Count");
            DataRow dr = DonorRecsCount.NewRow();
            dr["Count"] = DonorRecs.Rows.Count;
            DonorRecsCount.Rows.Add(dr);
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DonorAddresses", DonorRecs);
            ReportDataSource rds_count = new ReportDataSource("DataAddress", DonorRecsCount);
            PageSettings pg = new PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.Legal;
            pg.PaperSize = size;
            reportViewer1.SetPageSettings(pg);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds_count);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
