using eTemple.Data;
using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTemple.UI
{
    public partial class ServicesPrintForm : Form
    {
        public int ServiceID { get; set; }
        public String fldNameValue { get; set; }
        public String dtval { get; set; }

        public ServicesPrintForm()
        {
            InitializeComponent();
        }

        private void ServicesPrintForm_Load(object sender, EventArgs e)
        {
            var tokenDao = new TokenDao();
            dgvServiceReport.AutoGenerateColumns = false;
            var data = tokenDao.GetServiceReport(ServiceID, fldNameValue, dtval);
            var totals = new Token();
            totals.DevoteeName = "Totals";
            //totals.SoldQuantity = data.Sum(x => x.SoldQuantity);
            totals.TotalCost = data.Sum(x => x.TotalCost);
            data.Add(totals);
            dgvServiceReport.DataSource = data;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer();
            reportViewer.HeaderWidthPercent = 100;
            reportViewer.ContentWidthPercent = 100;
            reportViewer.RowsPerPage = 30;
            //reportViewer.HeaderContent = string.Format("<h2 style='margin-left:100px'>Daily Collection Report for the Date of {0:dd/MM/yyyy}</h2>", this.dtpFromDate.Value);
            reportViewer.HeaderContent = string.Format("<div style='float: left; width: 350px;'>Date : {0: dd-MM-YYYY} </div>", dtval);
            reportViewer.GenerateFromGridView(this.dgvServiceReport, false);
            reportViewer.Show(this);
        }
    }
}
