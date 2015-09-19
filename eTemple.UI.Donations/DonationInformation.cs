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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {            
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
                Convert.ToInt32(txtAmount.Text),Convert.ToInt32(txtMRNo.Text), txtRemarks.Text, txtPhone, 1, selectedServiceType.Id,
                selectedServiceName.Id, selectedDateType.Id, date, txtEmailId.Text, "paksha", selectedMonth.Id,1);
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
            ModifyPopup popup = new ModifyPopup();
            
            popup.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
