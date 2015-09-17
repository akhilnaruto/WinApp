using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTemple.Data.Repositories;
using eTemple.Data.Models;
namespace eTemple.UI.Donations
{
    public partial class DonorMasterReportUI : Form
    {
        public ServiceTypeRepository oServiceTypeRep = null;
        public ServiceNameRepository oServiceNameRep = null;
        public List<ServiceType> lstServiceType=null;
        public DonorMasterReportUI()
        {
            InitializeComponent();
            oServiceTypeRep = new ServiceTypeRepository();
            oServiceNameRep = new ServiceNameRepository();
            lstServiceType = oServiceTypeRep.GetAllAsQuerable().ToList();

        }

        private void DonorMasterReportUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DonorReportForm donorreportForm = new DonorReportForm();
            //donorreportForm.Show();
            //DonorReportDataSet ds = new DonorReportDataSet();
            //DataTable dt = new DataTable();
            //ds.DataTable1 = (DonorReportDataSet.DataTable1DataTable)dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                lblServiceType.Visible = true;
                cmbServiceType.Visible = true;
                cmbServiceType.DataSource = lstServiceType;
                cmbServiceType.DisplayMember = "Name";
                cmbServiceType.SelectedIndex = -1;
            }
            else
            {
                lblServiceType.Visible = false;
                cmbServiceType.Visible = false;
                lblServiceName.Visible = false;
                cmbServiceName.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblServiceName.Visible = true;
            cmbServiceName.Visible = true;
            var serviceType = cmbServiceType.SelectedItem as ServiceType;
            if(serviceType != null)
            {
                cmbServiceName.DataSource = oServiceNameRep.GetAllAsQuerable().Where(sType => sType.ServiceTypeId == serviceType.Id).ToList();
                cmbServiceName.DisplayMember = "Name";
            }
            cmbServiceName.SelectedIndex = -1;
        }
    }
}
