using eTemple.Data;
using eTemple.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using eTemple.UI.Donations;
using eTemple.Data.Models;
using System.Net.Http;
using System.Configuration;

namespace eTemple.UI
{
    public partial class DonationInformation : Form
    {
        private DonorRepository donorRepo;
        private DateTypeRepository datetypeRepo;
        private DesignationRepository desigRepo;
        private EmployeeRepository employeeRepo;
        private PrefixesRepository prefixRepo;
        private RoleRepository roleRepo;
        private ServiceNameRepository serviceNameRepo;
        private ServiceTypeRepository serviceTypeRepo;
        private SpecialDayRepository specialDayRepo;
        private StarsRepository starRepo;
        private MonthsRepository monthsRepo;
        private PakshaRepository pakshaRepo;
        private ThidhiRepository thithiRepo;
        private MonthlyAnnaRepository monthlyAnnaRepo;
        public GothramsRepository gothramRepo;
        public List<Gothrams> lstGothrams = null;
        public DonationInformation()
        {
            //dtpDate.MinDate = DateTime.Now;
            this.MaximizeBox = false;
            InitializeComponent();
            donorRepo = new DonorRepository();
            datetypeRepo = new DateTypeRepository();
            desigRepo = new DesignationRepository();
            employeeRepo = new EmployeeRepository();
            prefixRepo = new PrefixesRepository();
            roleRepo = new RoleRepository();
            serviceNameRepo = new ServiceNameRepository();
            serviceTypeRepo = new ServiceTypeRepository();
            specialDayRepo = new SpecialDayRepository();
            starRepo = new StarsRepository();
            monthsRepo = new MonthsRepository();
            pakshaRepo = new PakshaRepository();
            thithiRepo = new ThidhiRepository();
            monthlyAnnaRepo = new MonthlyAnnaRepository();
            gothramRepo = new GothramsRepository();

            bindData();
            btnUpdate.Visible = false;
            btnCancel.Visible = false;

            lblSpecialDay.Visible = false;
            cmbSpecialDay.Visible = false;
            lblMonth.Visible = false;
            cmbMonth.Visible = false;
            lblThithi.Visible = false;
            cmbThithi.Visible = false;
            lblMonthlyAnna.Visible = false;
            cmbMonthlyAnna.Visible = false;
            lblEnglishDatetype.Visible = false;
            dtpEnglishDateType.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool checkvalidate = validation();
            if (checkvalidate == false)
                return;

            DateTime donorDate = Convert.ToDateTime(dtpDate.Text);
            //DateTime performDate = Convert.ToDateTime(dtpEnglishDateType.Text);

            //if (dtpDate.Text != "" || dtpDate.Text != null)
            //    donorDate = Convert.ToDateTime(dtpDate.Text);
            //else
            //    donorDate = DateTime.Today;

            DateTime performDate = DateTime.Today;

            int selectedServiceTypeId;
            int selectedServiceNameId;
            int selectedMonthId;
            int selectedStarId;
            int selectedSpecialDayId;
            int selectedThithiId;
            int selectedDayId;
            var selectedDateTypeId = SelectedDateTypeId(out selectedServiceTypeId, out selectedServiceNameId, out selectedMonthId, out selectedStarId, out selectedSpecialDayId, out selectedThithiId, out selectedDayId);

            #region AutoGenerate Id
            var maxDonorId = donorRepo.getMaxIdFromDonor();
            int maxId = 0;
            //date = date.ToString("yyyy/mm/dd");
            if (maxDonorId.Tables[0].Rows.Count > 0)
            {
                string Id = maxDonorId.Tables[0].Rows[0]["donroId"].ToString();

                string[] s = Id.Split(' ');
                if (s[0] != "0")
                    maxId = Convert.ToInt32(s[1]);

                maxId = maxId + 1;
            }
            else
                maxId = 1;

            string uniqueDonorId = DateForId(donorDate) + " " + maxId;

            #endregion

            Donors donorInfo = new Donors
            {
                Id = uniqueDonorId,
                Donordate = donorDate,
                Address = txtAddress.Text,
                Surname = txtSurname.Text,
                DonorName = txtName.Text,
                DistrictName = txtDistrict.Text,
                City = txtCity.Text,
                Pin = Convert.ToInt32(txtPin.Text),
                State = txtState.Text,
                Country = txtCountry.Text,
                NameOn = txtNameOn.Text,
                Star = selectedStarId,
                Occassion = txtOccassion.Text,
                Gothram = txtGothram.Text,
                Amount = Convert.ToInt32(txtAmount.Text),
                MR_No = Convert.ToInt32(txtMRNo.Text),
                Remarks = txtRemarks.Text,
                Landline = txtLandline.Text,
                SpecialDayId = selectedSpecialDayId,
                ServiceTypeId = selectedServiceTypeId,
                ServiceNameId = selectedServiceNameId,
                DateTypeId = selectedDateTypeId,
                PerformDate = performDate,
                EmailId = txtEmailId.Text,
                DonorMonth = selectedMonthId,
                Thidhi = selectedThithiId,
                DonorDay = selectedDayId,
                Mobile = txtMobile.Text
            };

            string strInsertStatus = donorRepo.insertDonorInformation(donorInfo);

            if (strInsertStatus == "Success")
            {
                MessageBox.Show("Data inserted successfully.");
                sendSMS("91" + donorInfo.Mobile);
                CleareAllcontrolsRecursive();                
            }    
            else
                MessageBox.Show("There was a problem inserting data, kindly try again to save the record");
        }


        public void sendSMS(string phone)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["SvcpvdrAPI"]);
            // Usage
            HttpResponseMessage response = client.GetAsync("?User=" + ConfigurationManager.AppSettings["User"] +
                "&passwd=" + ConfigurationManager.AppSettings["passwd"] + "&mobilenumber=" + phone + "&message=" +
                ConfigurationManager.AppSettings["message"] + "&sid=" + ConfigurationManager.AppSettings["sid"] +
                "&mtype=" + ConfigurationManager.AppSettings["mtype"] + "&DR=" + ConfigurationManager.AppSettings["DR"] + "").Result;
        }

        private int SelectedDateTypeId(out int selectedServiceTypeId, out int selectedServiceNameId,
            out int selectedMonthId, out int selectedStarId, out int selectedSpecialDayId, out int selectedThithiId,
            out int selectedDayId)
        {
            int selectedDateTypeId = 0;
            selectedServiceTypeId = 0;
            selectedServiceNameId = 0;
            selectedMonthId = 0;
            selectedStarId = 0;
            selectedSpecialDayId = 0;
            selectedThithiId = 0;
            string selectedPakshaName = "";
            selectedDayId = 0;

            var selectedDateType = cmbDateType.SelectedItem as DateType;
            if (selectedDateType == null)
                selectedDateTypeId = 0;
            else
                selectedDateTypeId = selectedDateType.Id;

            var selectedServiceType = cmbServiceType.SelectedItem as ServiceTypes;
            if (selectedServiceType == null)
                selectedServiceTypeId = 0;
            else
                selectedServiceTypeId = selectedServiceType.Id;


            var selectedServiceName = cmbServiceName.SelectedItem as ServiceName;
            if (selectedServiceName == null)
                selectedServiceNameId = 0;
            else
                selectedServiceNameId = selectedServiceName.Id;

            var selectedMonth = cmbMonth.SelectedItem as Months;
            if (selectedMonth == null)
                selectedMonthId = 0;
            else
                selectedMonthId = selectedMonth.Id;

            var selectedStar = cmbStar.SelectedItem as Stars;
            if (selectedStar == null)
                selectedStarId = 0;
            else
                selectedStarId = selectedStar.Id;

            var selectedSpecialDay = cmbSpecialDay.SelectedItem as SpecialDay;
            if (selectedSpecialDay == null)
                selectedSpecialDayId = 0;
            else
                selectedSpecialDayId = selectedSpecialDay.Id;

            var selectedThithi = cmbThithi.SelectedItem as Thidhi;
            if (selectedThithi == null)
                selectedThithiId = 0;
            else
                selectedThithiId = selectedThithi.Id;

            var selectedDay = cmbMonthlyAnna.SelectedItem as MonthlyAnnaDanam;
            if (selectedDay == null)
                selectedDayId = 0;
            else
                selectedDayId = selectedDay.Id;

            if (txtPin.Text == "")
                txtPin.Text = "0";
            return selectedDateTypeId;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private string DateForId(DateTime date)
        {
            String dy = date.Day.ToString();
            String mn = date.Month.ToString();
            String yy = date.Year.ToString();

            string s3 = yy + mn + dy;

            return s3;

        }

        public void bindData()
        {
            lblServiceName.Enabled = true;
            cmbServiceName.Enabled = true;

            #region Default Date Type Values
            //cmbDateType.Items.Insert(0, "--Select--");
            //cmbDateType.Items.Insert(1, "Telugu");
            //cmbDateType.Items.Insert(2, "English");

            //cmbDateType.SelectedIndex = 0;
            var bindDateType = datetypeRepo.GetAllAsQuerable();
            var cmbListDateType = bindDateType.ToList();
            cmbDateType.DataSource = cmbListDateType;
            cmbDateType.DisplayMember = "Name";
            #endregion


            #region Bind Stars values
            var bindStars = starRepo.GetAllAsQuerable();
            cmbStar.DataSource = bindStars;
            cmbStar.DisplayMember = "Name";
            #endregion

            #region Bind ServiceType values
            var bindServiceType = serviceTypeRepo.GetAllAsQuerable();
            cmbServiceType.DataSource = bindServiceType;
            cmbServiceType.DisplayMember = "Name";
            #endregion

            //#region Bind ServiceName values
            //var bindServiceName = serviceNameRepo.GetAllAsQuerable();
            //cmbServiceName.DataSource = bindServiceName;
            //cmbServiceName.DisplayMember = "Name";
            //#endregion

            var serviceType = cmbServiceType.SelectedItem as ServiceTypes;
            if (serviceType != null)
            {
                cmbServiceName.DataSource = serviceNameRepo.GetAllAsQuerable().Where(sType => sType.ServiceTypeId == serviceType.Id).ToList();
                cmbServiceName.DisplayMember = "Name";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDateType = cmbDateType.SelectedItem as DateType;

            if (selectedDateType.Name == "Telugu")
            {                
                lblSpecialDay.Visible = false;
                cmbSpecialDay.Visible = false;
                lblEnglishDatetype.Visible = false;
                dtpEnglishDateType.Visible = false;
                lblMonth.Visible = true;
                cmbMonth.Visible = true;
                lblThithi.Visible = true;
                cmbThithi.Visible = true;
                lblMonthlyAnna.Visible = false;
                cmbMonthlyAnna.Visible = false;
                
                #region Bind Month values
                var bindMonth = monthsRepo.GetAllAsQuerable();
                cmbMonth.DataSource = bindMonth;
                cmbMonth.DisplayMember = "Name";
                #endregion

                #region Thithi
                var bindThithi = thithiRepo.GetAllAsQuerable();
                cmbThithi.DataSource = bindThithi;
                cmbThithi.DisplayMember = "Name";
                #endregion
            }

            else if (selectedDateType.Name == "English")
            {
                lblSpecialDay.Visible = false;
                cmbSpecialDay.Visible = false;
                lblEnglishDatetype.Visible = true;
                dtpEnglishDateType.Visible = true;
                lblMonth.Visible = false;
                cmbMonth.Visible = false;
                lblThithi.Visible = false;
                cmbThithi.Visible = false;
                lblMonthlyAnna.Visible = false;
                cmbMonthlyAnna.Visible = false;
                lblEnglishDatetype.Visible = true;
                dtpEnglishDateType.Visible = true;
            }

            else if (selectedDateType.Name == "Special")
            {                
                lblSpecialDay.Visible = true;
                cmbSpecialDay.Visible = true;
                lblEnglishDatetype.Visible = false;
                dtpEnglishDateType.Visible = false;
                lblMonth.Visible = false;
                cmbMonth.Visible = false;
                lblThithi.Visible = false;
                cmbThithi.Visible = false;
                lblMonthlyAnna.Visible = false;
                cmbMonthlyAnna.Visible = false;

                #region Bind SpecialDay values
                var bindSpecialDay = specialDayRepo.GetAllAsQuerable();
                cmbSpecialDay.DataSource = bindSpecialDay;
                cmbSpecialDay.DisplayMember = "Name";
                #endregion
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
            btnAdd.Visible = false;
            btnModify.Visible = false;
            using (ModifyPopup formOptions = new ModifyPopup())
            {
                // passing this in ShowDialog will set the .Owner 
                // property of the child form
                formOptions.ShowDialog(this);
                formOptions.Dispose();
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
            btnAdd.Visible = false;
            btnModify.Visible = false;

            DateTime donorDate;
            DateTime performDate;

            if (dtpDate.Text != "" || dtpDate.Text != null)
                donorDate = Convert.ToDateTime(dtpDate.Text);
            else
                donorDate = DateTime.Today;
            
                performDate = DateTime.Today;

            int selectedServiceTypeId;
            int selectedServiceNameId;
            int selectedMonthId;
            int selectedStarId;
            int selectedSpecialDayId;
            int selectedThithiId;
            int selectedDayId;
            var selectedDateTypeId = SelectedDateTypeId(out selectedServiceTypeId, out selectedServiceNameId, out selectedMonthId, out selectedStarId, out selectedSpecialDayId, out selectedThithiId, out selectedDayId);

            Donors donorUpdateInfo = new Donors
            {
                Id = txtDonorId.Text,
                Donordate = donorDate,
                Address = txtAddress.Text,
                Surname = txtSurname.Text,
                DonorName = txtName.Text,
                DistrictName = txtDistrict.Text,
                City = txtCity.Text,
                Pin = Convert.ToInt32(txtPin.Text),
                State = txtState.Text,
                Country = txtCountry.Text,
                NameOn = txtNameOn.Text,
                Star = selectedStarId,
                Occassion = txtOccassion.Text,
                Gothram = txtGothram.Text,
                Amount = Convert.ToInt32(txtAmount.Text),
                MR_No = Convert.ToInt32(txtMRNo.Text),
                Remarks = txtRemarks.Text,
                Landline = txtLandline.Text,
                SpecialDayId = selectedSpecialDayId,
                ServiceTypeId = selectedServiceTypeId,
                ServiceNameId = selectedServiceNameId,
                DateTypeId = selectedDateTypeId,
                PerformDate = performDate,
                EmailId = txtEmailId.Text,
                DonorMonth = selectedMonthId,
                Thidhi = selectedThithiId,
                DonorDay = selectedDayId,
                Mobile = txtMobile.Text
            };

            string updateStatus = donorRepo.updateDonorInformation(donorUpdateInfo);

            if (updateStatus == "Success")
            {
                MessageBox.Show("Data updated successfully.");
                CleareAllcontrolsRecursive();
                btnAdd.Visible = true;
                btnModify.Visible = true;
            }
            else
                MessageBox.Show("There was a problem in updating your data, kindly try again.");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            btnAdd.Visible = true;
            btnModify.Visible = true;

            CleareAllcontrolsRecursive();
            CleareAllcontrolsRecursive();
            CleareAllcontrolsRecursive();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void getDataFromChildWindow(Donors donor)
        {
            DateTime dt;
            txtDonorId.Text = donor.Id.ToString();
            if (!DateTime.TryParse(donor.Donordate.ToString(), out dt))
            {
                dtpDate.Value = dt;
            }

            txtAddress.Text = donor.Address;
            txtSurname.Text = donor.Surname;
            txtName.Text = donor.DonorName;
            txtDistrict.Text = donor.DistrictName;
            txtCity.Text = donor.City;
            txtPin.Text = donor.Pin.ToString();
            txtState.Text = donor.State;
            txtCountry.Text = donor.Country;

            txtNameOn.Text = donor.NameOn;
            txtNameOn.Enabled = false;

            //Get Star Info
            var bindStarName = starRepo.GetAllAsQuerable(donor.Star);
            string[] starNameValue = bindStarName.Select(p => p.Name).ToArray();
            cmbStar.SelectedIndex = cmbStar.FindString(starNameValue[0]);

            txtOccassion.Text = donor.Occassion;
            txtGothram.Text = donor.Gothram;

            txtAmount.Text = donor.Amount.ToString();
            txtAmount.Enabled = false;
            txtMRNo.Text = donor.MR_No.ToString();
            txtMRNo.Enabled = false;

            txtRemarks.Text = donor.Remarks;
            txtLandline.Text = donor.Landline;
            txtMobile.Text = donor.Mobile;
            txtEmailId.Text = donor.EmailId;

            //Get ServiceType
            var bindServiceType = serviceTypeRepo.GetAllAsQuerable(donor.ServiceTypeId);
            string[] starTypeValue = bindServiceType.Select(p => p.Name).ToArray();
            cmbServiceType.SelectedIndex = cmbServiceType.FindString(starTypeValue[0]);

            //Get ServiceName
            var bindServiceName = serviceNameRepo.GetAllAsQuerable(donor.ServiceNameId);
            string[] serviceNameValue = bindServiceName.Select(p => p.Name).ToArray();
            cmbServiceName.SelectedIndex = cmbServiceName.FindString(serviceNameValue[0]);

            //Get DateType
            var bindDatetype = datetypeRepo.GetAllAsQuerable(donor.DateTypeId);
            string[] dateTypeValue = bindDatetype.Select(p => p.Name).ToArray();
            cmbDateType.SelectedIndex = cmbDateType.FindString(dateTypeValue[0]);

            //Get SpecialDay
            var bindSpecialDay = specialDayRepo.GetAllAsQuerable(donor.SpecialDayId);
            string[] specialDayValue = bindSpecialDay.Select(p => p.Name).ToArray();
            cmbSpecialDay.SelectedIndex = cmbSpecialDay.FindString(specialDayValue[0]);

            //Get Month
            var bindMonth = monthsRepo.GetAllAsQuerable(donor.DonorMonth);
            string[] monthValue = bindMonth.Select(p => p.Name).ToArray();
            cmbMonth.SelectedIndex = cmbMonth.FindString(monthValue[0]);

            //Get Thithi
            var bindThithi = thithiRepo.GetAllAsQuerable(donor.Thidhi);
            string[] thithiValue = bindThithi.Select(p => p.Name).ToArray();
            cmbThithi.SelectedIndex = cmbThithi.FindString(monthValue[0]);

            //Perform Date
            DateTime dt1;            
            if (!DateTime.TryParse(donor.PerformDate.ToString(), out dt1))
                dtpEnglishDateType.Value = dt1;

            //Monthly AnnaDanam
            var bindDonorDay = monthlyAnnaRepo.GetAllAsQuerable(donor.DonorDay);
            string[] donorDayValue = bindDonorDay.Select(p => p.Day).ToArray();
            cmbMonthlyAnna.SelectedIndex = cmbMonthlyAnna.FindString(donorDayValue[0]);

        }

        public bool validation()
        {
            bool needValidate = true;

            if (dtpDate.Text == "" || dtpDate.Text == string.Empty)
                { 
                errorProvider1.SetError(dtpDate, "Need to select Date to continue");
                needValidate = false;
                return needValidate;                
            }
            else
                errorProvider1.Clear();

            //if (txtAddress.Text == "" || txtAddress.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtAddress, "Need to enter Address");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtSurname.Text == "" || txtSurname.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtSurname, "Need to enter Surname");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtName.Text == "" || txtName.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtName, "Need to enter Name");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtDistrict.Text == "" || txtDistrict.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtDistrict, "Need to enter District");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtCity.Text == "" || txtCity.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtCity, "Need to enter City");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtPin.Text == "" || txtPin.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtPin, "Need to enter PIN Code");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtState.Text == "" || txtState.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtState, "Need to enter State");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtCountry.Text == "" || txtCountry.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtCountry, "Need to enter Country");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            if (txtNameOn.Text == "" || txtNameOn.Text == string.Empty)
            {
                errorProvider1.SetError(txtNameOn, "Need to have Name On");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (cmbStar.Text == "" || cmbStar.Text == string.Empty)
            {
                errorProvider1.SetError(cmbStar, "Need to Select Star");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            //if (txtOccassion.Text == "" || txtOccassion.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtOccassion, "Need to enter Occassion");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtGothram.Text == "" || txtGothram.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtGothram, "Need to enter Gothram");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            if (txtAmount.Text == "" || txtAmount.Text == string.Empty)
            {
                errorProvider1.SetError(txtAmount, "Need to enter the Amount");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtMRNo.Text == "" || txtMRNo.Text == string.Empty)
            {
                errorProvider1.SetError(txtMRNo, "Need to enter the MR Number");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            //if (txtRemarks.Text == "" || txtRemarks.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtRemarks, "Need to enter the Remarks");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtLandline.Text == "" || txtLandline.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtLandline, "Need to enter Landline Number");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtMobile.Text == "" || txtMobile.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtMobile, "Need to enter Mobile Number");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (txtEmailId.Text == "" || txtEmailId.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtEmailId, "Need to enter Email ID");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (cmbServiceType.Text == "" || cmbServiceType.Text == string.Empty)
            //{
            //    errorProvider1.SetError(cmbServiceType, "Need to select Service Type");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (cmbServiceName.Text == "" || cmbServiceName.Text == string.Empty)
            //{
            //    errorProvider1.SetError(cmbServiceName, "Need to select Service Name");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (cmbDateType.Text == "" || cmbDateType.Text == string.Empty)
            //{
            //    errorProvider1.SetError(cmbDateType, "Need to select Date Type");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (cmbSpecialDay.Text == "" || cmbSpecialDay.Text == string.Empty)
            //{
            //    errorProvider1.SetError(cmbSpecialDay, "Need to select Special Day");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (cmbMonth.Text == "" || cmbMonth.Text == string.Empty)
            //{
            //    errorProvider1.SetError(cmbMonth, "Need to select Month");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            //if (cmbThithi.Text == "" || cmbThithi.Text == string.Empty)
            //{
            //    errorProvider1.SetError(cmbThithi, "Need to select Thithi");
            //    needValidate = false;
            //    return needValidate;
            //}
            //else
            //    errorProvider1.Clear();
            return needValidate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(Char.IsDigit(e.KeyChar)))
            //    e.Handled = true;
            //if (!(Char.IsDigit(e.KeyChar) && (e.KeyChar == (char)Keys.Back)))
            //{
            //    e.Handled = true;
            //    errorProvider1.SetError(txtPin, "Only Numbers allowed e.g.,560050");
            //}
            //else
            //    errorProvider1.Clear();
        }

        private void cmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServiceName.DataSource = null;
            lblServiceName.Enabled = false;
            cmbServiceName.Enabled = false;

            var serviceType = cmbServiceType.SelectedItem as ServiceTypes;
            if (serviceType != null)
            {
                var ServiceTypeData = serviceNameRepo.GetAllAsQuerable().Where(sType => sType.ServiceTypeId == serviceType.Id).ToList();
                cmbServiceName.DataSource = ServiceTypeData;
                cmbServiceName.DisplayMember = "Name";
                if (ServiceTypeData.Count > 0)
                {
                    lblServiceName.Enabled = true;
                    cmbServiceName.Enabled = true;

                }
                if (serviceType.IsDateRelated == 1)
                {
                    lblDateType.Visible = true;
                    cmbDateType.Visible = true;
                    lblSpecialDay.Visible = false;
                    cmbSpecialDay.Visible = false;
                    lblEnglishDatetype.Visible = false;
                    dtpEnglishDateType.Visible = false;
                    lblMonth.Visible = false;
                    cmbMonth.Visible = false;
                    lblThithi.Visible = false;
                    cmbThithi.Visible = false;                    
                    lblMonthlyAnna.Visible = false;
                    cmbMonthlyAnna.Visible = false;
                }
                else
                {
                    lblDateType.Visible = false;
                    cmbDateType.Visible = false;
                    lblSpecialDay.Visible = false;
                    cmbSpecialDay.Visible = false;
                    lblEnglishDatetype.Visible = false;
                    dtpEnglishDateType.Visible = false;
                    lblMonth.Visible = false;
                    cmbMonth.Visible = false;
                    lblThithi.Visible = false;
                    cmbThithi.Visible = false;                    
                    lblMonthlyAnna.Visible = false;
                    cmbMonthlyAnna.Visible = false;
                }
            }
            if (serviceType.Name == "Monthly Annadanam")
            {
                #region Show Hide Controls
                lblDateType.Visible = false;
                cmbDateType.Visible = false;
                lblSpecialDay.Visible = false;
                cmbSpecialDay.Visible = false;
                lblEnglishDatetype.Visible = false;
                dtpEnglishDateType.Visible = false;
                lblMonth.Visible = false;
                cmbMonth.Visible = false;
                lblThithi.Visible = false;
                cmbThithi.Visible = false;
                lblServiceName.Enabled = false;
                cmbServiceName.Enabled = false;
                lblMonthlyAnna.Visible = true;
                cmbMonthlyAnna.Visible = true;
                #endregion

                #region Bind MonthlyAnna values
                var bindMonthlyAnna = monthlyAnnaRepo.GetAllAsQuerable();
                cmbMonthlyAnna.DataSource = bindMonthlyAnna;
                cmbMonthlyAnna.DisplayMember = "Day";
                #endregion
            }
            //else
            //{
            //    lblDateType.Visible = true;
            //    cmbDateType.Visible = true;
            //    lblMonthlyAnna.Visible = false;
            //    cmbMonthlyAnna.Visible = false;
            //    lblServiceName.Enabled = true;
            //    cmbServiceName.Enabled = true;
            //}
        }


        public void CleareAllcontrolsRecursive()
        {
            txtDonorId.Enabled = true;
            txtNameOn.Enabled = true;
            txtAmount.Enabled = true;
            txtMRNo.Enabled = true;

            txtDonorId.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDistrict.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPin.Text = string.Empty;
            txtState.Text = string.Empty;
            txtCountry.Text = string.Empty;

            txtNameOn.Text = string.Empty;            
                        
            txtOccassion.Text = string.Empty;
            txtGothram.Text = string.Empty;

            txtAmount.Text = string.Empty;
            
            txtMRNo.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtLandline.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtEmailId.Text = string.Empty;
            
            txtDonorId.Enabled = false;
            bindData();
            btnUpdate.Visible = false;
            btnCancel.Visible = false;

            lblSpecialDay.Visible = false;
            cmbSpecialDay.Visible = false;
            lblMonth.Visible = false;
            cmbMonth.Visible = false;
            lblThithi.Visible = false;
            cmbThithi.Visible = false;
            lblMonthlyAnna.Visible = false;
            cmbMonthlyAnna.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuickDailyAnna_Click(object sender, EventArgs e)
        {
            using (DailyAnnadanam formOptions = new DailyAnnadanam())
            {
                // passing this in ShowDialog will set the .Owner 
                // property of the child form
                formOptions.ShowDialog(this);
                formOptions.Dispose();
            }
        }

        private void DonationInformation_Load(object sender, EventArgs e)
        {
            lstGothrams = gothramRepo.GetAllAsQuerable().ToList();
            AutoCompleteStringCollection strcoll = new AutoCompleteStringCollection();
            foreach (Gothrams gothram in lstGothrams)
            {
                strcoll.Add(gothram.Name);
            }
            txtGothram.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtGothram.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtGothram.AutoCompleteCustomSource = strcoll;
        }
    }
}

