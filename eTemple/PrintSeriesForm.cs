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
    public partial class PrintSeriesForm : Form
    {
        public PrintSeriesForm()
        {
            InitializeComponent();
        }

        private void ShowPrintSeries()
        {
            var psDao = new PrintSeriesDao();
            String dt = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(currentDateTimePicker.Value));
            String dt1 = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(toDateTimePicker.Value));
            int UserId = (cmbUsername.SelectedItem as Employee).Id;
            dgvPrintSeries.AutoGenerateColumns = false;
            //dgvPrintSeries.DataSource = psDao.GetAllPrintSeries(dt);
            dgvPrintSeries.DataSource = psDao.GetAllPrintSeries(dt, dt1, UserId);
        }
        private void ShowPrintSeriesBalance()
        {
            var psDao = new PrintSeriesDao();
            dgvPrintSeriesBalance.AutoGenerateColumns = false;
            dgvPrintSeriesBalance.DataSource = psDao.GetAllPrintSeriesBalance();
        }

        private void ShowPS(PrintSeries psobj)
        {
            txtPrintSeriesId.Text = psobj.Id.ToString();
            cmbGivenTo.SelectedValue = psobj.GivenTo;
            txtStartNumber.Text = psobj.PrintseriesStart.ToString();
            txtEndNumber.Text = psobj.PrintseriesEnd.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowPrintSeries();
            ShowPrintSeriesBalance();
        }

        private void PrintSeries_Load_1(object sender, EventArgs e)
        {
            var empDao = new EmployeeDao();
            cmbGivenTo.DataSource = empDao.GetLoginIds();
            cmbUsername.DataSource = empDao.GetLoginIds();
            ShowPrintSeries();
            ShowPrintSeriesBalance();
        }

        private void brnSubmit_Click(object sender, EventArgs e)
        {
            int psId = 0;
            int.TryParse(txtPrintSeriesId.Text, out psId);
            var psObj = new PrintSeries
            {
                Id = psId,
                GivenTo = (cmbGivenTo.SelectedItem as Employee).Id,
                PrintseriesStart = Convert.ToInt32(txtStartNumber.Text),
                PrintseriesEnd = Convert.ToInt32(txtEndNumber.Text),
                CreatedOn = DateTime.Now,
                CreatedBy = 1
            };

            var psDao = new PrintSeriesDao();
            psDao.SavePrintSeries(psObj);
            ShowPrintSeries();
        }

        private void dgvPrintSeries_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var psobj = dgvPrintSeries.Rows[e.RowIndex].DataBoundItem as PrintSeries;
                ShowPS(psobj);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowPrintSeries();
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGivenTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
