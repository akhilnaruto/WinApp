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
    public partial class PattiOutForm : Form
    {
        public int ActualStock { get; set; }

        public PattiOutForm()
        {
            InitializeComponent();
        }
        private void ShowPattiOut()
        {
            var poDao = new PattiOutDao();
            dgvPattiOut.AutoGenerateColumns = false;
            String dt = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(currentDateTimePicker.Value));
            dgvPattiOut.DataSource = poDao.GetAllPattiOut(dt);
            tableLayoutPanel2.Hide();
        }

        private void ShowPO(PattiOut poObj)
        {
            txtId.Text = poObj.Id.ToString();
            cmbServiceID.SelectedValue = poObj.ServiceId;
            numPattiNumbers.Value = poObj.PattiNumbers;
            numActualPackets.Value = poObj.ActualPackets;
            dtpInDate.Value = poObj.IssuedDate;
            ActualStock = poObj.ActualPackets;
            tableLayoutPanel2.Show();
        }

        private void PattiOutForm_Load(object sender, EventArgs e)
        {
            var serviceDao = new ServiceDao();
            cmbServiceID.DataSource = serviceDao.GetAllPoojas();
            ShowPattiOut();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowPattiOut();
        }

        private void dgvPattiOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var poObj = dgvPattiOut.Rows[e.RowIndex].DataBoundItem as PattiOut;
                ShowPO(poObj);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ActualStock.ToString());
            var sdDao = new StockDetailsDao();
            int serviceId = (cmbServiceID.SelectedItem as Service).Id;
            string serviceName = (cmbServiceID.SelectedItem as Service).Name;
            int stockVal = Convert.ToInt32(numActualPackets.Text) - ActualStock;
            stockVal = -(stockVal);
            sdDao.UpdateStockDetail(stockVal, serviceId);
            
            int poId = 0;
            int.TryParse(txtId.Text, out poId);
            var poObj = new PattiOut
            {
                Id = poId,
                ServiceId = (cmbServiceID.SelectedItem as Service).Id,
                PattiNumbers = Convert.ToInt32(numPattiNumbers.Text),
                ActualPackets = Convert.ToInt32(numActualPackets.Text),
                IssuedDate = Convert.ToDateTime(dtpInDate.Value),
                EnteredOn = DateTime.Now,
                EnteredBy = 1
            };

            var poDao = new PattiOutDao();
            poDao.SavePattiOut(poObj);
            ShowPattiOut();
        }

        private void currentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowPattiOut();
        }

      
    }
}
