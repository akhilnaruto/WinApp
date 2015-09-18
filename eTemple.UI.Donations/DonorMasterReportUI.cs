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
//using System.Data.DataSetExtensions;
namespace eTemple.UI.Donations
{
    public partial class DonorMasterReportUI : Form
    {
        public ServiceTypeRepository oServiceTypeRep = null;
        public ServiceNameRepository oServiceNameRep = null;
        public List<ServiceTypes> lstServiceType = null;
        public DonorRepository oDonorRepository = null;
        public DonorMasterReportUI()
        {
            InitializeComponent();
            oServiceTypeRep = new ServiceTypeRepository();
            oServiceNameRep = new ServiceNameRepository();
            oDonorRepository = new DonorRepository();
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
            if (cmbServiceName.SelectedIndex >= 0)
            {
                DataTable dt = new DataTable();
                var ServiceName = cmbServiceName.SelectedItem as ServiceName;
                var ServiceTypes = cmbServiceType.SelectedItem as ServiceTypes;
                var DonorList = oDonorRepository.GetAllasDataTable().Select("ServiceNameId=" + ServiceName.Id);
                if (DonorList.Count() != 0)
                {
                    string performDate = DonorList[0]["PerformDate"].ToString();
                    DataView view = new DataView(DonorList.CopyToDataTable());
                    dt = view.ToTable(false, "Id", "NameOn", "Gothram", "MR_No");
                    DonorReportDataSet drs = new DonorReportDataSet();
                    drs.Tables.Add(dt);
                    DataTable DonorVals = new DataTable();
                    DonorVals.Columns.Add("ServiceType");
                    DonorVals.Columns.Add("ServiceName");
                    DonorVals.Columns.Add("PerformDate");
                    DataRow dr = DonorVals.NewRow();
                    dr["ServiceType"] = ServiceTypes.Name;
                    dr["ServiceName"] = ServiceName.Name;
                    dr["PerformDate"] = performDate;
                    DonorVals.Rows.Add(dr);
                    DonorReportForm donorreportForm = new DonorReportForm(dt, DonorVals);
                    donorreportForm.Show();
                }
                //report
            }
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
            var serviceType = cmbServiceType.SelectedItem as ServiceTypes;
            if (serviceType != null)
            {
                cmbServiceName.DataSource = oServiceNameRep.GetAllAsQuerable().Where(sType => sType.ServiceTypeId == serviceType.Id).ToList();
                cmbServiceName.DisplayMember = "Name";
            }
            cmbServiceName.SelectedIndex = -1;
        }
    }
}
