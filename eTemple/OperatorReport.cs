using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTemple.Data;
using eTemple.Data.Models;

namespace eTemple.UI
{
    public partial class OperatorReport : Form
    {
        public OperatorReport()
        {
            InitializeComponent();
        }

        private void OperatorReport_Load(object sender, EventArgs e)
        {
            var empDao = new EmployeeDao();
            cmbUsername.DataSource = empDao.GetLoginIds();
            cmbUsername.DisplayMember = "LoginId";
            cmbUsername.ValueMember = "Id";
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            dgvOperatorReport.AutoGenerateColumns = false;
            int cUser = (cmbUsername.SelectedItem as Employee).Id;
            var data = new ServiceDao().GetOperatorReport(dtpDate.Value, cUser);
            var totals = new Service();
            totals.Name = "Total";
            totals.SoldQuantity = data.Sum(x => x.SoldQuantity);
            totals.TotalCollection = data.Sum(x => x.TotalCollection);
            data.Add(totals);
            dgvOperatorReport.DataSource = data;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer();
            reportViewer.HeaderWidthPercent = 100;
            reportViewer.ContentWidthPercent = 100;
            reportViewer.RowsPerPage = 30;
            var duration = dtpDate.Value;
            var cUser = cmbUsername.Text;
            reportViewer.HeaderContent = string.Format("<center><h2>Daily Collection Report for the Date of {0:dd/MM/yyyy} of {1}</h2></center>", this.dtpDate.Value, cUser);
            reportViewer.GenerateFromGridView(this.dgvOperatorReport, true);
            reportViewer.MdiParent = this.MdiParent;
            reportViewer.Show();
        }
    }
}
