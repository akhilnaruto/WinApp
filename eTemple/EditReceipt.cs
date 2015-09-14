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
using System.Drawing.Printing;

namespace eTemple.UI
{
    public partial class EditReceipt : Form
    {
        public long recieptId;

        private Token tkn;

        public EditReceipt()
        {
            InitializeComponent();
        }

        private void EditReceipt_Load(object sender, EventArgs e)
        {
            tkn = new TokenDao().GetTokenWithDevoteeDetails(recieptId);

            label16.Text = tkn.TotalCost.ToString();
            label17.Text = tkn.Quantity.ToString();
            txtTokenId.Text = tkn.Id.ToString();
            txtPrefixId.Text = tkn.PrefixId.ToString();
            txtServiceId.Text = tkn.ServiceId.ToString();
            txtServiceName.Text = tkn.ServiceName;
            dtpPerformDate.Text = tkn.ServicePerformDate.ToString();
            txtPhoneNumber.Text = tkn.PhoneNumber;
            txtEmail.Text = tkn.EmailId;
            txtAdditionalNames.Text = tkn.AdditionalNames;
            txtAdditionalGothrams.Text = tkn.AdditionalGothrams;
            txtCreatedBy.Text = tkn.CreatedBy.ToString();
            txtTotalAmount.Text = tkn.TotalCost.ToString();
            cmbQty.Text = tkn.Quantity.ToString();
            txtDevoteeId.Text = tkn.DevoteeId.ToString();
            txtDevoteeName.Text = tkn.DevoteeName;
            txtGothram.Text = tkn.Gothram;
            txtDoorNumber.Text = tkn.DoorNumber;
            txtAreaName.Text = tkn.AreaName;
            txtCity.Text = tkn.City;
            txtMandalName.Text = tkn.MandalName;
            txtDistrictName.Text = tkn.DistrictName;
            txtStateName.Text = tkn.StateName;
            txtOtherDetails.Text = tkn.OtherDetails;
            txtStatus.Text = tkn.Status.ToString();
            txtCreatedOn.Text = tkn.CreatedOn.ToString();
            txtServiceDailyNumber.Text = tkn.ServiceDailyNumber.ToString();
            txtGovtNumber.Text = tkn.GovtNumber.ToString();
            txtTrNumber.Text = tkn.TrNumber;
            txtDailyNumber.Text = tkn.DailyNumber.ToString();
            txtAmountDescription.Text = tkn.AmountDescription;
            txtTimeId.Text = tkn.TimeId.ToString();

            var statusCodeDao = new StatusCodeDao();
            cmbTokenStatus.DataSource = statusCodeDao.GetAllStatusCode();

            cmbTokenStatus.Text = tkn.TokenStatus;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            var devoteeObj = new Devotee
            {
                Id = Convert.ToInt32(txtDevoteeId.Text),
                DevoteeName = txtDevoteeName.Text,
                Prefix = Convert.ToInt32(txtPrefixId.Text),
                Gothram = txtGothram.Text,
                PhoneNumber = txtPhoneNumber.Text,
                EmailId = txtEmail.Text,
                DoorNumber = txtDoorNumber.Text,
                AreaName = txtAreaName.Text,
                City = txtCity.Text,
                MandalName = txtMandalName.Text,
                DistrictName = txtDistrictName.Text,
                StateName = txtStateName.Text,
                OtherDetails = txtOtherDetails.Text
            };
            var devoteeDao = new DevoteesDao();
            int devoteeId = devoteeDao.Update(devoteeObj);
            var tokenDAO = new TokenDao();
            tkn.ServicePerformDate = Convert.ToDateTime(dtpPerformDate.Value);
            tkn.TokenStatus = cmbTokenStatus.Text;
            tokenDAO.UpdateToken(tkn);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
