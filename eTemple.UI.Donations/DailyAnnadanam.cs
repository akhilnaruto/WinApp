using eTemple.Data.Models;
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

namespace eTemple.UI.Donations
{
    public partial class DailyAnnadanam : Form
    {
        private DailyAnnaDanamRepository dailyAnnaRepo;
        public DailyAnnadanam()
        {
            this.MaximizeBox = false;
            dailyAnnaRepo = new DailyAnnaDanamRepository();
            InitializeComponent();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            bool checkvalidate = validation();
            if (checkvalidate == false)
                return;

            DailyAnnaDanamModel dailyAnna = new DailyAnnaDanamModel
            {
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Gothram = txtGothram.Text,
                VillageName = txtVillageName.Text
            };

            string strInsertStatus = dailyAnnaRepo.insertDonorInformation(dailyAnna);

            if (strInsertStatus == "Success")
            {
                MessageBox.Show("Data inserted successfully.");
                CleareAllcontrolsRecursive();
                this.Close();
            }
        }

        public void CleareAllcontrolsRecursive()
        {
            txtName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtGothram.Text = string.Empty;
            txtVillageName.Text = string.Empty;  
        }
        
        public bool validation()
        {
            bool needValidate = true;

            if (txtName.Text == "" || txtName.Text == string.Empty)
            {
                errorProvider1.SetError(txtName, "Need to Name to continue");
                needValidate = false;
                return needValidate;
            }

            return needValidate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
