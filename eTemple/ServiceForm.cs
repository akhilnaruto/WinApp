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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int serviceId = 0;
            int.TryParse(txtServiceId.Text, out serviceId);
            var serviceObj = new Service
            {
                Id = serviceId,
                Name = txtName.Text,
                Type = (cmbType.SelectedItem as ServiceType).Id,
                Cost = Convert.ToDouble(txtCost.Text),
                Status = Convert.ToSByte(chkStatus.Checked),
                CreatedOn = DateTime.Now,
                CreeatedBy = App.LoggedInEmployee.Id,
                ModifiedOn = DateTime.Now,
                ModifiedBy = App.LoggedInEmployee.Id,
                AllowMultiple = Convert.ToSByte(chkAllowMultiple.Checked)
            };

            var serviceDao = new ServiceDao();
            int scid = serviceDao.SavePrintSeries(serviceObj);

            if (serviceId == 0)
            {
                var sdDao = new StockDetailsDao();
                var sdObj = new StockDetail
                {
                    ServiceId = scid,
                    Stock = 0
                };
                sdDao.SaveStockDetail(sdObj);
            }
            
            ShowServices();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            var servicetypeDao = new ServiceTypesDao();
            cmbType.DataSource = servicetypeDao.GetAllServiceTypes();
            ShowServices();
        }

        private void ShowServices()
        {
            var serviceDao = new ServiceDao();
            dgvServices.AutoGenerateColumns = false;
            dgvServices.DataSource = serviceDao.GetAllServices();
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var serviceObj = dgvServices.Rows[e.RowIndex].DataBoundItem as Service;
                ShowService(serviceObj);
            }
        }

        private void ShowService(Service serviceObj)
        {
            txtServiceId.Text = serviceObj.Id.ToString();
            cmbType.SelectedValue = serviceObj.Type;
            txtName.Text = serviceObj.Name;
            txtCost.Text = serviceObj.Cost.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowServices();
        }

    }
}
