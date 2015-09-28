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
using InternalTools;

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
        public List<Paksha> lstPaksha = null;
        public DonorRepository oDonorRepository = null;
        public DateTypeRepository oDateTypeRepository = null;
        public SpecialDayRepository oSpecialDayRepository = null;
        public MonthsRepository oMonthsRepository = null;
        public ThidhiRepository oThidhiRepository = null;
        public PakshaRepository oPakshaRepository = null;
        public string performDate = string.Empty;
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
            //  oPakshaRepository = new PakshaRepository();
            lstServiceType = oServiceTypeRep.GetAllAsQuerable().ToList();
            lstMonths = oMonthsRepository.GetAllAsQuerable().ToList();
            lstThidhi = oThidhiRepository.GetAllAsQuerable().ToList();
            lstDateType = oDateTypeRepository.GetAllAsQuerable().ToList();
            lstDateType.RemoveAt(0);
            lstSpecialDay = oSpecialDayRepository.GetAllAsQuerable().ToList();
            //  lstPaksha = oPakshaRepository.GetAllAsQuerable().ToList();
        }

        private void DonorMasterReportUI_Load(object sender, EventArgs e)
        {
            cmbDateType.DataSource = lstDateType;
            cmbDateType.DisplayMember = "Name";
            cmbSpecialDay.DataSource = lstSpecialDay;
            cmbSpecialDay.DisplayMember = "Name";
            cmbMonth.DataSource = lstMonths;
            cmbMonth.DisplayMember = "Name";
            cmbThidhi.DataSource = lstThidhi;
            cmbThidhi.DisplayMember = "Name";
            // cmbPaksha.DataSource = lstPaksha;
            //  cmbPaksha.DisplayMember = "Name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serviceName = cmbServiceName.SelectedItem as ServiceName;
            if (serviceName != null)
            {
                if (serviceName.IsDateRelated == 0)
                {
                    showorHideDateType(false);
                }
                else
                {
                    showorHideDateType(true);
                }
            }
        }
        public void showorHideDateType(bool show)
        {
            if (!show)
            {
                cmbDateType.Visible = false;
                lblMonth.Visible = false;
                cmbMonth.Visible = false;
                lblThidhi.Visible = false;
                cmbThidhi.Visible = false;
                lblSpecialDay.Visible = false;
                cmbSpecialDay.Visible = false;
                dtPicker.Visible = false;
                lblDateType.Visible = false;
            }
            else
            {
                cmbDateType.Visible = true;
                lblDateType.Visible = true;
                cmbDateType.DataSource = null;
                cmbDateType.DataSource = lstDateType;
                cmbDateType.DisplayMember = "Name";
                //cmbDateType.SelectedIndex = 0;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAlldonors.Checked)
            {
                showorHideDateType(true);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbServiceWseDonors.Checked)
            {
                //btnGenerateAdress.Visible = false;
                lblServiceType.Visible = true;
                cmbServiceType.Visible = true;
                cmbServiceType.DataSource = lstServiceType;
                cmbServiceType.DisplayMember = "Name";
                cmbDateType.DataSource = lstDateType;
                cmbDateType.DisplayMember = "Name";
            }
            else
            {
                lblServiceType.Visible = false;
                cmbServiceType.Visible = false;
                lblServiceName.Visible = false;
                cmbServiceName.Visible = false;
                btnGenerateAdress.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cmbServiceName.Items.Clear();
            cmbServiceName.DataSource = null;
            lblServiceName.Visible = true;
            cmbServiceName.Visible = true;
            var serviceType = cmbServiceType.SelectedItem as ServiceTypes;
            if (serviceType != null)
            {
                cmbServiceName.DataSource = oServiceNameRep.GetAllAsQuerable().Where(sType => sType.ServiceTypeId == serviceType.Id).ToList();
                if (cmbServiceName.Items.Count == 0)
                {
                    lblServiceName.Visible = false;
                    cmbServiceName.Visible = false;
                    if (serviceType.IsDateRelated == 0)
                    {
                        showorHideDateType(false);
                    }
                    else
                    {
                        showorHideDateType(true);
                    }
                }
                else
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
            var dtType = cmbDateType.SelectedItem as DateType;
            DataTable dt = new DataTable();
            var ServiceName = cmbServiceName.SelectedItem as ServiceName;
            var ServiceTypes = cmbServiceType.SelectedItem as ServiceTypes;
            if (rdbServiceWseDonors.Checked && dtType.Id != 2 && ServiceTypes.Id == 2)
            {
                MessageBox.Show("Please pick English date for Monthly Annadanam...");
                return;
            }
            // performDate = string.Format(performDate, "yyyy-mm-dd");
            string filterstring = string.Empty;
            if (rdbServiceWseDonors.Checked)
                filterstring = GetFilterstring();
            else
                filterstring = GetFilterstring() + " OR (" + GetFilterForMonthlyAnnadanam() + ")";
            var DonorList = oDonorRepository.GetAllasDataTable().Select(filterstring);
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
                    dr["ServiceName"] = (ServiceName == null) ? "" : ServiceName.Name;
                }
                if (!chkNonPerformSvc.Checked)
                    dr["PerformDate"] = performDate;
                else
                {
                    dr["ServiceType"] = "";
                    dr["ServiceName"] = "";
                }
                DonorVals.Rows.Add(dr);
                DonorReportForm donorreportForm = new DonorReportForm(dt, DonorVals);
                donorreportForm.Show();
            }
            else
                MessageBox.Show("Donors were not found for the selected filters");
            //report
            //   }
        }


        public string GetFilterstring()
        {
        
            string FilterString = string.Empty;
            var dtType = cmbDateType.SelectedItem as DateType;
            var month = cmbMonth.SelectedItem as Months;
            // var paksha=cmbPaksha.SelectedItem as;
            var thidhi = cmbThidhi.SelectedItem as Thidhi;
            // var paksha = cmbPaksha.SelectedItem as Paksha;
            var specialDayId = cmbSpecialDay.SelectedItem as SpecialDay;
            var serviceTypeId = cmbServiceType.SelectedItem as ServiceTypes;
            var serviceNameId = cmbServiceName.SelectedItem as ServiceName;

           
            switch (dtType.Id)
            {
                case 1:
                    FilterString = "DateTypeId=1 and DonorMonth=" + month.Id + " AND Thidhi=" + thidhi.Id;
                    performDate = month.Name + "   " + thidhi.Name;
                    break;
                case 2:
                    performDate = dtPicker.Value.ToString("dd-MM");
                    string prvsYeardate = dtPicker.Value.AddYears(-1).ToString("yyyy-MM-dd");
                    FilterString = "DateTypeId=2 and PerformDate='" + performDate + "' AND Donordate <= '#" + prvsYeardate + "#'";
                    performDate = dtPicker.Value.ToString("dd-MM-yyyy");
                    break;
                case 3:
                    FilterString = "DateTypeId=3 and  SpecialDayId=" + specialDayId.Id;
                    performDate = specialDayId.Name;
                    break;
            }
            if (chkNonPerformSvc.Checked)
            {
                FilterString = "DateTypeId=0 and ServiceTypeId>2";
                return FilterString;
            }

            if (rdbServiceWseDonors.Checked)
            {
                if (serviceTypeId.Id == 2)
                {
                    FilterString = GetFilterForMonthlyAnnadanam();
                    return FilterString;
                }
                if (!cmbDateType.Visible)
                {
                    performDate = "";
                    FilterString =  " ServiceTypeId=" + serviceTypeId.Id;
                    if (serviceNameId != null)
                        FilterString = " ServiceNameId=" + serviceNameId.Id;
                }
                else
                {
                    FilterString = FilterString + " AND ServiceTypeId=" + serviceTypeId.Id;
                    if (serviceNameId != null)
                        FilterString = FilterString + " AND ServiceNameId=" + serviceNameId.Id;
                }
            }
            else
            {
                if (dtType.Id == 2)
                    FilterString = FilterString + " and DateTypeId>0 OR (ServiceNameId=1 AND ServiceTypeId=1)";
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
                        //  lblPaksha.Visible = true;
                        //  cmbPaksha.Visible = true;
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
                        //lblPaksha.Visible = false;
                        // cmbPaksha.Visible = false;
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
                        // lblPaksha.Visible = false;
                        // cmbPaksha.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string filterString = GetFilterstring().Replace(" OR (ServiceNameId=1 AND ServiceTypeId=1)", "") + " AND Mobile is null";
            var DonorList = oDonorRepository.GetAllasDataTable().Select(filterString + " OR (" + GetFilterForMonthlyAnnadanam() + " AND Mobile is null)");
            if (DonorList.Count() != 0)
            {
                DataView view = new DataView(DonorList.CopyToDataTable());
                dt = view.ToTable(false, "Address", "Surname", "NameOn", "DistrictName", "City", "Pin", "State", "Country", "ServiceTypeId", "MR_NO");
                dt.Columns.Add("ServiceType");
                foreach (DataRow dr in dt.Rows)
                {
                    dr["ServiceType"] = lstServiceType[Convert.ToInt32(dr["ServiceTypeId"])].Name;
                }
                DonorReportDataSet drs = new DonorReportDataSet();
                drs.Tables.Add(dt);
                AddressForm oAddressForm = new AddressForm(dt);
                oAddressForm.Show();
            }
            else
                MessageBox.Show("Donors were not found for the selected filters");
        }

        public string GetFilterForMonthlyAnnadanam()
        {
            string selDate = dtPicker.Value.ToString("yyyy-MM-dd");
            int day = dtPicker.Value.Day;
            string prvsYeardate = dtPicker.Value.AddYears(-1).ToString("yyyy-MM-dd");
            return "DonorDay=" + day + " AND Donordate >= '#" + prvsYeardate + "#'";
        }
    }
}
