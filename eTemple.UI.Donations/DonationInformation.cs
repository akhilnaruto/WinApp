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
            bindData();
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
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

            DateTime date = Convert.ToDateTime(dtpDate.Text);

            string txtPhone = string.Empty;

            if (txtLandline != null)
            {
                txtPhone = txtLandline.Text;
                txtMobile.Enabled = false;
            }
            else
            {
                txtPhone = txtLandline.Text;
                txtMobile.Enabled = true;
            }

            var selectedDateType = cmbDateType.SelectedItem as DateType;
            var selectedServiceType = cmbServiceType.SelectedItem as ServiceTypes;
            var selectedServiceName = cmbServiceName.SelectedItem as ServiceName;
            var selectedMonth = cmbMonth.SelectedItem as Months;
            var selectedStar = cmbStar.SelectedItem as Stars;
            var selectedSpecialDay = cmbSpecialDay.SelectedItem as SpecialDay;
            var selectedThithi = cmbThithi.SelectedItem as Thidhi;


            //var donar = CreateDonorFactory.CreateDonor
            //    (Convert.ToInt32(txtAmount.Text), Convert.ToInt32(txtMRNo.Text), selectedServiceType.Id,
            //        selectedServiceName.Id, selectedDateType.Id, date, selectedMonth.Name,
            //        txtAddress.Text, txtName.Text, txtCity.Text,txtName.Text, txtCity.Text, txtSurname.Text,
            //        Convert.ToInt32(txtPin.Text), txtDistrict.Text, txtNameOn.Text,
            //        selectedStar.Id, txtOccassion.Text, txtGothram.Text, txtRemarks.Text, txtPhone,
            //        selectedSpecialDay.Id, txtEmailId.Text, "564654", Convert.ToString(cmbThithi.SelectedItem));

            //var donar = CreateDonorFactory.CreateDonor
            //    (Convert.ToInt32(txtAmount.Text), Convert.ToInt32(txtMRNo.Text), selectedServiceType.Id, selectedServiceName.Id
            //        , selectedDateType.Id, date, selectedMonth.Id,
            //        txtAddress.Text, txtName.Text, txtCity.Text, txtName.Text, txtCity.Text, txtSurname.Text,
            //        Convert.ToInt32(txtPin.Text), txtDistrict.Text, txtNameOn.Text,
            //        selectedStar.Id, txtOccassion.Text, txtGothram.Text, txtRemarks.Text, txtPhone,
            //        3, txtEmailId.Text, "564654", Convert.ToString("thithi"));

            var donar = CreateDonorFactory.CreateDonor1
                (date, txtAddress.Text, txtSurname.Text, txtName.Text, txtDistrict.Text, txtCity.Text, Convert.ToInt32(txtPin.Text),
                txtState.Text, txtCountry.Text, txtNameOn.Text, selectedStar.Id, txtOccassion.Text, txtGothram.Text,
                Convert.ToInt32(txtAmount.Text), Convert.ToInt32(txtMRNo.Text), txtRemarks.Text, txtPhone, 1, selectedServiceType.Id,
                selectedServiceName.Id, selectedDateType.Id, date, txtEmailId.Text, "paksha", selectedMonth.Id, 1);
            donorRepo.Add(donar);
        }


        public void bindData()
        {

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

            #region Bind ServiceName values
            var bindServiceName = serviceNameRepo.GetAllAsQuerable();
            cmbServiceName.DataSource = bindServiceName;
            cmbServiceName.DisplayMember = "Name";
            #endregion
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
                #region Bind Month values
                var bindMonth = monthsRepo.GetAllAsQuerable();
                cmbMonth.DataSource = bindMonth;
                cmbMonth.DisplayMember = "Telugu";
                #endregion
            }

            else if (selectedDateType.Name == "English")
            {
                #region Bind Month values
                var bindMonth = monthsRepo.GetAllAsQuerable();
                cmbMonth.DataSource = bindMonth;
                cmbMonth.DisplayMember = "English";
                #endregion
            }

            else if (selectedDateType.Name == "SpecialDay")
            {
                #region Bind SpecialDay values
                var bindSpecialDay = monthsRepo.GetAllAsQuerable();
                cmbSpecialDay.DataSource = bindSpecialDay;
                cmbSpecialDay.DisplayMember = "SpecialDay";
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

            if (txtAddress.Text == "" || txtAddress.Text == string.Empty)
            {
                errorProvider1.SetError(txtAddress, "Need to enter Address");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtSurname.Text == "" || txtSurname.Text == string.Empty)
            {
                errorProvider1.SetError(txtSurname, "Need to enter Surname");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtName.Text == "" || txtName.Text == string.Empty)
            {
                errorProvider1.SetError(txtName, "Need to enter Name");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtDistrict.Text == "" || txtDistrict.Text == string.Empty)
            {
                errorProvider1.SetError(txtDistrict, "Need to enter District");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtCity.Text == "" || txtCity.Text == string.Empty)
            {
                errorProvider1.SetError(txtCity, "Need to enter City");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtPin.Text == "" || txtPin.Text == string.Empty)
            {
                errorProvider1.SetError(txtPin, "Need to enter PIN Code");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtState.Text == "" || txtState.Text == string.Empty)
            {
                errorProvider1.SetError(txtState, "Need to enter State");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtCountry.Text == "" || txtCountry.Text == string.Empty)
            {
                errorProvider1.SetError(txtCountry, "Need to enter Country");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
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
            if (txtOccassion.Text == "" || txtOccassion.Text == string.Empty)
            {
                errorProvider1.SetError(txtOccassion, "Need to enter Occassion");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtGothram.Text == "" || txtGothram.Text == string.Empty)
            {
                errorProvider1.SetError(txtGothram, "Need to enter Gothram");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
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
            if (txtRemarks.Text == "" || txtRemarks.Text == string.Empty)
            {
                errorProvider1.SetError(txtRemarks, "Need to enter the Remarks");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtLandline.Text == "" || txtLandline.Text == string.Empty)
            {
                errorProvider1.SetError(txtLandline, "Need to enter Landline Number");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtMobile.Text == "" || txtMobile.Text == string.Empty)
            {
                errorProvider1.SetError(txtMobile, "Need to enter Mobile Number");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (txtEmailId.Text == "" || txtEmailId.Text == string.Empty)
            {
                errorProvider1.SetError(txtEmailId, "Need to enter Email ID");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (cmbServiceType.Text == "" || cmbServiceType.Text == string.Empty)
            {
                errorProvider1.SetError(cmbServiceType, "Need to select Service Type");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (cmbServiceName.Text == "" || cmbServiceName.Text == string.Empty)
            {
                errorProvider1.SetError(cmbServiceName, "Need to select Service Name");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (cmbDateType.Text == "" || cmbDateType.Text == string.Empty)
            {
                errorProvider1.SetError(cmbDateType, "Need to select Date Type");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (cmbSpecialDay.Text == "" || cmbSpecialDay.Text == string.Empty)
            {
                errorProvider1.SetError(cmbSpecialDay, "Need to select Special Day");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (cmbMonth.Text == "" || cmbMonth.Text == string.Empty)
            {
                errorProvider1.SetError(cmbMonth, "Need to select Month");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            if (cmbThithi.Text == "" || cmbThithi.Text == string.Empty)
            {
                errorProvider1.SetError(cmbThithi, "Need to select Thithi");
                needValidate = false;
                return needValidate;
            }
            else
                errorProvider1.Clear();
            return needValidate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
                e.Handled = true;
            //if (!(Char.IsDigit(e.KeyChar) && (e.KeyChar == (char)Keys.Back)))
            //{
            //    e.Handled = true;
            //    errorProvider1.SetError(txtPin, "Only Numbers allowed e.g.,560050");
            //}
            //else
            //    errorProvider1.Clear();
        }
    }
}

