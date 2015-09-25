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
            
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds_count);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
