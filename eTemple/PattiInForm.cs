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
    public partial class PattiInForm : Form
    {
        public PattiInForm()
        {
            InitializeComponent();
        }

        private void ShowPattiIn()
        {
            var piDao = new PattiInDao();
            dgvPattiIn.AutoGenerateColumns = false;
            dgvPattiIn.DataSource = piDao.GetAllPattiIn();
        }

        private void ShowPI(PattiIn piObj)
        {
            txtId.Text = piObj.Id.ToString();
            cmbServiceID.SelectedValue = piObj.ServiceId;
            numPattiNumbers.Value = piObj.PattiNumbers;
            dtpInDate.Value = piObj.InDate;
        }

        private void PattiInForm_Load(object sender, EventArgs e)
        {
            var serviceDao = new ServiceDao();
            cmbServiceID.DataSource = serviceDao.GetAllPoojas();
            ShowPattiIn();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPattiIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var piObj = dgvPattiIn.Rows[e.RowIndex].DataBoundItem as PattiIn;
                ShowPI(piObj);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int piId = 0;
            int.TryParse(txtId.Text, out piId);
            var piObj = new PattiIn
            {
                Id = piId,
                ServiceId = (cmbServiceID.SelectedItem as Service).Id,
                PattiNumbers = Convert.ToInt32(numPattiNumbers.Text),
                InDate = Convert.ToDateTime(dtpInDate.Value),
                EnteredOn = DateTime.Now,
                EnteredBy = 1
            };

            var piDao = new PattiInDao();
            piDao.SavePattiIn(piObj);
            ShowPattiIn();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowPattiIn();
        }
    }
}
