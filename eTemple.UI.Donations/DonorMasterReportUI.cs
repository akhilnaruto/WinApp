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
        public List<DateType> lstDateType = null;
        public List<SpecialDay> lstSpecialDay = null;
        public List<Months> lstMonths = null;
        public List<Thidhi> lstThidhi = null;
        public DonorRepository oDonorRepository = null;
        public DateTypeRepository oDateTypeRepository = null;
        public SpecialDayRepository oSpecialDayRepository = null;
        public MonthsRepository oMonthsRepository = null;
        public ThidhiRepository oThidhiRepository = null;
        public DonorMasterReportUI()
        {
            InitializeComponent();
            oServiceTypeRep = new ServiceTypeRepository();
            oServiceNameRep = new ServiceNameRepository();
            oDateTypeRepository = new DateTypeRepository();
            oDonorRepository = new DonorRepository();
            oSpecialDayRepository = new SpecialDayRepository();
            oMonthsRepository = new MonthsRepository();
            oThidhiRepository = new ThidhiRepository();
            lstServiceType = oServiceTypeRep.GetAllAsQuerable().ToList();
            lstMonths = oMonthsRepository.GetAllAsQuerable().ToList();
            lstThidhi = oThidhiRepository.GetAllAsQuerable().ToList();
            lstDateType = oDateTypeRepository.GetAllAsQuerable().ToList();
            lstSpecialDay = oSpecialDayRepository.GetAllAsQuerable().ToList();
        }

        private void DonorMasterReportUI_Load(object sender, EventArgs e)
        {
            cmbDateType.DataSource = lstDateType;
            cmbDateType.DisplayMember = "Name";
            cmbSpecialDay.DataSource = lstSpecialDay;
            cmbSpecialDay.DisplayMember = "Name";
            cmbMonth.DataSource = lstMonths;
            cmbMonth.DisplayMember = "Telugu";
            cmbThidhi.DataSource = lstThidhi;
            cmbThidhi.DisplayMember = "Name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbServiceWseDonors.Checked)
            {
                lblServiceType.Visible = true;
                cmbServiceType.Visible = true;
                cmbServiceType.DataSource = lstServiceType;
                cmbServiceType.DisplayMember = "Name";
               // cmbServiceType.SelectedIndex = -1;
                lblServicePerfmdt.Visible = true;
                dtPicker.Visible = true;
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
          //  cmbServiceName.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (cmbServiceName.SelectedIndex >= 0)
          //  {
                DataTable dt = new DataTable();
                var ServiceName = cmbServiceName.SelectedItem as ServiceName;
                var ServiceTypes = cmbServiceType.SelectedItem as ServiceTypes;
                string performDate = dtPicker.Value.ToString("yyyy-MM-dd");
                // performDate = string.Format(performDate, "yyyy-mm-dd");
                var DonorList = oDonorRepository.GetAllasDataTable().Select(GetFilterstring());
                if (DonorList.Count() != 0)
                {
                    //string performDate = DonorList[0]["PerformDate"].ToString();
                    DataView view = new DataView(DonorList.CopyToDataTable());
                    dt = view.ToTable(false, "Id", "NameOn", "Gothram", "MR_No");
                    DonorReportDataSet drs = new DonorReportDataSet();
                    drs.Tables.Add(dt);
                    DataTable DonorVals = new DataTable();
                    DonorVals.Columns.Add("ServiceType");
                    DonorVals.Columns.Add("ServiceName");
                    DonorVals.Columns.Add("PerformDate");
                    DataRow dr = DonorVals.NewRow();
                    if (rdbAlldonors.Checked)
                    {
                        dr["ServiceType"] = "All Donors";
                        dr["ServiceName"] = "All Donors";
                    }
                    else
                    {
                        dr["ServiceType"] = ServiceTypes.Name;
                        dr["ServiceName"] = ServiceName.Name;
                    }
                    dr["PerformDate"] = performDate;
                    DonorVals.Rows.Add(dr);
                    DonorReportForm donorreportForm = new DonorReportForm(dt, DonorVals);
                    donorreportForm.Show();
                }
                //report
         //   }
        }


        public string GetFilterstring()
        {
        //    var ServiceName = cmbServiceName.SelectedItem as ServiceName;
        //    var ServiceTypes = cmbServiceType.SelectedItem as ServiceTypes;
        //    string performDate = dtPicker.Value.ToString("yyyy-MM-dd");
        ////    if(rd)
            string FilterString = string.Empty;
            var dtType = cmbDateType.SelectedItem as DateType;
            var month = cmbMonth.SelectedItem as Months;
           // var paksha=cmbPaksha.SelectedItem as;
            var thidhi=cmbThidhi.SelectedItem as Thidhi;
            var specialDayId = cmbSpecialDay.SelectedItem as SpecialDay;
            switch (dtType.Id)
            {
                case 1:
                    FilterString = "Month=" + month.Id + "AND Thidhi=" + thidhi.Id;
                    break;
                case 2:
                    string performDate = dtPicker.Value.ToString("yyyy-MM-dd");
                    FilterString = "PerformDate='#" + performDate + "#'";
                    break;
                case 3:
                    FilterString = "SpecialDayId=" + specialDayId.Id;
                    break;
            }
            return FilterString;
        }
        private void cmbDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDateType.SelectedIndex != -1)
            {
                var dtType = cmbDateType.SelectedItem as DateType;
                switch (dtType.Id)
                {
                    case 1:
                        lblPaksha.Visible = true;
                        cmbPaksha.Visible = true;
                        lblMonth.Visible = true;
                        cmbMonth.Visible = true;
                        lblThidhi.Visible = true;
                        cmbThidhi.Visible = true;
                        lblServicePerfmdt.Visible = false;
                        dtPicker.Visible = false;
                        lblSpecialDay.Visible = false;
                        cmbSpecialDay.Visible = false;
                        break;
                    case 2:
                        lblServicePerfmdt.Visible = true;
                        dtPicker.Visible = true;
                        lblPaksha.Visible = false;
                        cmbPaksha.Visible = false;
                        lblMonth.Visible = false;
                        cmbMonth.Visible = false;
                        lblThidhi.Visible = false;
                        cmbThidhi.Visible = false;
                        lblSpecialDay.Visible = false;
                        cmbSpecialDay.Visible = false;
                        break;
                    case 3:
                        lblSpecialDay.Visible = true;
                        cmbSpecialDay.Visible = true;
                        lblPaksha.Visible = false;
                        cmbPaksha.Visible = false;
                        lblMonth.Visible = false;
                        cmbMonth.Visible = false;
                        lblThidhi.Visible = false;
                        cmbThidhi.Visible = false;
                        lblServicePerfmdt.Visible = false;
                        dtPicker.Visible = false;
                        break;

                }
            }
        }
    }
}
