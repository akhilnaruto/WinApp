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
using System.Drawing.Printing;

namespace eTemple.UI
{
    public partial class PoojaAddressReport : Form
    {
        public PoojaAddressReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PoojaAddressReport_Load(object sender, EventArgs e)
        {
            var serviceDao = new ServiceDao();
            cmbServiceID.DataSource = serviceDao.GetAllPoojasExceptVIPPrasadam();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbServiceID.Text != null && fldName.Text != "" && dtValue.Text != null)
            {
                int ServiceID = (cmbServiceID.SelectedItem as Service).Id;
                String fldNameValue = fldName.Text;
                String dtval = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(dtValue.Text));
                var tokenDao = new TokenDao();
                dgvServiceReport.AutoGenerateColumns = false;
                var data = tokenDao.GetServiceReport(ServiceID, fldNameValue, dtval);

                //var totals = new Token();
                //totals.DevoteeName = "Totals";
                //totals.SoldQuantity = data.Sum(x => x.SoldQuantity);
                //totals.TotalCost = data.Sum(x => x.TotalCost);
                //data.Add(totals);
                dgvServiceReport.DataSource = data;
            }
            else
            {
                if (cmbServiceID.Text != null)
                {
                    MessageBox.Show("Select Service");
                }
                else if (fldName.Text != null)
                {
                    MessageBox.Show("Select CreatedOn / ServicePerformDate");
                }
                else if (dtValue.Text != null)
                {
                    MessageBox.Show("Select Date");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbServiceID.Text != null && fldName.Text != "" && dtValue.Text != null)
            {
                var reportViewer = new ReportViewer();
                reportViewer.HeaderWidthPercent = 100;
                reportViewer.ContentWidthPercent = 100;
                reportViewer.RowsPerPage = 30;
                //reportViewer.HeaderContent = string.Format("<h2 style='margin-left:100px'>Daily Collection Report for the Date of {0:dd/MM/yyyy}</h2>", this.dtpFromDate.Value);
                reportViewer.HeaderContent = string.Format("<div style='float: left; width: 350px;'>Date : {0: dd-MM-YYYY} </div>", dtValue.Text);
                reportViewer.GenerateFromGridView(this.dgvServiceReport, false);
                reportViewer.Show(this);
            }
            else
            {
                if (cmbServiceID.Text != null)
                {
                    MessageBox.Show("Select Service");
                }
                else if (fldName.Text != null)
                {
                    MessageBox.Show("Select CreatedOn / ServicePerformDate");
                }
                else if (dtValue.Text != null)
                {
                    MessageBox.Show("Select Date");
                }
            }
        }

        private void dgvServiceReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
