﻿using eTemple.Data.Models;
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
using eTemple.Data.Utilities;

namespace eTemple.UI.Donations
{
    public partial class DailyAnnadanam : Form
    {
        private DailyAnnaDanamRepository dailyAnnaRepo;
        public GothramsRepository gothramRepo;
        public List<Gothrams> lstGothrams=null;
        public List<TokenPrint> lstTokenPrint = null;
        public PrintHelper oPrintHelper = null;
        private ServiceTypeRepository serviceTypeRepo;
        public string _PrinterName = string.Empty;
        public bool _ShowPrintPreview = false;
        public DailyAnnadanam(string PrinterName,bool ShowPrintPreview)
        {
            this.MaximizeBox = false;
            dailyAnnaRepo = new DailyAnnaDanamRepository();
            gothramRepo = new GothramsRepository();
            serviceTypeRepo = new ServiceTypeRepository();
            oPrintHelper = new PrintHelper();
            lstTokenPrint = new List<TokenPrint>();
            _PrinterName = PrinterName;
            _ShowPrintPreview = ShowPrintPreview;
            InitializeComponent();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            bool checkvalidate = validation();
            string performDate = DateTime.Now.ToString("yyyy-MM-dd");

            if (checkvalidate == false)
                return;

            DailyAnnaDanamModel dailyAnna = new DailyAnnaDanamModel
            {
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Gothram = txtGothram.Text,
                VillageName = txtVillageName.Text,
                DonatedDate = performDate
            };

            TokenPrint oTokenPrint = new TokenPrint
            {
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Gothram = txtGothram.Text,
                VillageName = txtVillageName.Text,
                DonatedDate = performDate,
                ServiceType="Nithya Annadanam"
            };
            lstTokenPrint.Add(oTokenPrint);

            var checkIfExists = gothramRepo.checkIfGothramExists(txtGothram.Text);

            //If Gothra doesn't exist and if user has entered a Gothram
            if (checkIfExists == null && txtGothram.Text != string.Empty)
            {
                string insrtGothra = gothramRepo.insertNewGothraName(txtGothram.Text);
            }

            string strInsertStatus = dailyAnnaRepo.insertDonorInformation(dailyAnna);

            var bindServiceType = serviceTypeRepo.GetAllAsQuerable(10);
            List<int> serviceTypeValue = bindServiceType.Select(p => p.Cost).ToList();

            string smsMessage = "Thanks " + dailyAnna.Name + " we have recieved an amount of Rs." + serviceTypeValue[0] + "/- towards Daily Annadanam";

            if (strInsertStatus == "Success")
            {
                MessageBox.Show("Data inserted successfully.");
                oPrintHelper.PrintTokens(lstTokenPrint, this, _PrinterName, _ShowPrintPreview);
                CleareAllcontrolsRecursive();
                loadGothramAutoComplete();
                SMSHelper smsHelp = new SMSHelper();
                smsHelp.sendSMS("91" + dailyAnna.PhoneNumber, smsMessage);
                //this.Close();
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
                errorProvider1.SetError(txtName, "Need to enter Name to continue");
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

        private void DailyAnnadanam_Load(object sender, EventArgs e)
        {
            loadGothramAutoComplete();
        }


        private void loadGothramAutoComplete()
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

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
