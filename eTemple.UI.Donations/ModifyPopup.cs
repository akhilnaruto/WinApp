using eTemple.Data.Models;
using eTemple.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTemple.UI.Donations
{
    public partial class ModifyPopup : Form
    {
        private DonorRepository donorRepositoy;
        List<Donors> donors = new List<Donors>();
        public int parentWinValue = 0;      

        public ModifyPopup()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            donorRepositoy = new DonorRepository();
            donors = donorRepositoy.GetAllAsQuerable().ToList();
            lblDonorID.Visible = true;
            lblDonorName.Visible = false;
            lblMRNO.Visible = false;
            rbdDonorId_CheckedChanged(null,null);

        }

        private void rbdDonorId_CheckedChanged(object sender, EventArgs e)
        {
            lblDonorID.Visible = true;
            lblDonorName.Visible = false;
            lblMRNO.Visible = false;
            txtDonorID.Visible = true;
            txtDonorName.Visible = false;
            txtMRNO.Visible = false;
            txtDonorName.Text = "";
            txtMRNO.Text = "";
        }

        private void rbdDonorName_CheckedChanged(object sender, EventArgs e)
        {
            lblDonorID.Visible = false;
            lblDonorName.Visible = true;
            lblMRNO.Visible = false;
            txtDonorID.Visible = false;
            txtDonorName.Visible = true;
            txtMRNO.Visible = false;
            txtDonorID.Text = "";
            txtMRNO.Text = "";
        }

        private void rbdMRNO_CheckedChanged(object sender, EventArgs e)
        {
            lblDonorID.Visible = false;
            lblDonorName.Visible = false;
            lblMRNO.Visible = true;
            txtDonorID.Visible = false;
            txtDonorName.Visible = false;
            txtMRNO.Visible = true;
            txtDonorName.Text = "";
            txtDonorID.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyPopup_Load(object sender, EventArgs e)
        {
            LoadDataAndRenderInUI();
        }

        private void LoadDataAndRenderInUI()
        {

            //var distinctDonors = donors.GroupBy(donor => donor.DonorName).ToList().Select(
            //                                     x => new SelectedDonorOptions
            //                                     {
            //                                         Name = x.Key,
            //                                         Id = x.Select(y => y.Id).FirstOrDefault()
            //                                     }).ToList();
            //cmbDonorID.DataSource = distinctDonors;
            //cmbDonorID.DisplayMember = "Id";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtDonorID.Text != string.Empty || txtDonorID.Text != "")
            {
                //DonationInformation parent = (DonationInformation)this.Owner;
                DonationRecording parent = (DonationRecording)this.Owner;
                var donorId = txtDonorID.Text;
                var donorExists = donorRepositoy.checkModifyDonorIDExists(donorId);
                if (donorExists == null)
                {
                    MessageBox.Show("Entered Donor Id dosen't exist, kindly enter again to modify the record");                    
                    return;
                }
                //var selectedDonor = donors.Where(donor => donor.Id == donorId.Id).FirstOrDefault();
                parent.getDataFromChildWindow(donorExists);
                parentWinValue = parentWinValue + 1;
                this.Close();
            }

            else if (txtDonorName.Text != string.Empty || txtDonorName.Text != "")
            {
                //DonationInformation parent = (DonationInformation)this.Owner;
                DonationRecording parent = (DonationRecording)this.Owner;
                var donorName = txtDonorName.Text;
                var donorExists = donorRepositoy.checkModifyDonorNameExists(donorName);
                if (donorExists == null)
                {
                    MessageBox.Show("Entered Donor Name dosen't exist, kindly enter again to modify the record");
                    return;
                }
                //var selectedDonor = donors.Where(donor => donor.Id == donorId.Id).FirstOrDefault();
                parent.getDataFromChildWindow(donorExists);
                parentWinValue = parentWinValue + 1;
                this.Close();
            }

            else if (txtMRNO.Text != string.Empty || txtMRNO.Text != "")
            {
                //DonationInformation parent = (DonationInformation)this.Owner;
                DonationRecording parent = (DonationRecording)this.Owner;
                var donorName = txtMRNO.Text;
                var donorExists = donorRepositoy.checkModifyMRNoExists(donorName);
                if (donorExists == null)
                {
                    MessageBox.Show("Entered MR Nnumber dosen't exist, kindly enter again to modify the record");
                    return;
                }
                //var selectedDonor = donors.Where(donor => donor.Id == donorId.Id).FirstOrDefault();
                parent.getDataFromChildWindow(donorExists);
                parentWinValue = parentWinValue + 1;
                this.Close();                
            }
            else
            {
                MessageBox.Show("Kindly enter data to modify the data");
                return;
            }
        }

        private void cmbDonorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var donorId = cmbDonorID.SelectedItem as SelectedDonorOptions;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            DonationRecording parent = (DonationRecording)this.Owner;
            //DonationInformation parent = (DonationInformation)this.Owner;            
            parent.getDataFromChildWindow(parentWinValue);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
