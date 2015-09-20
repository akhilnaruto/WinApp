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
        DonorRepository donorRepositoy;
        List<Donors> donors = new List<Donors>();
       

        public ModifyPopup()
        {
            InitializeComponent();
            donorRepositoy = new DonorRepository();
            donors = donorRepositoy.GetAllAsQuerable().ToList();
            lblDonorID.Visible = true;
            lblDonorName.Visible = false;
            lblMRNO.Visible = false;
        }

        private void rbdDonorId_CheckedChanged(object sender, EventArgs e)
        {
            lblDonorID.Visible = true;
            lblDonorName.Visible = false;
            lblMRNO.Visible = false;
        }

        private void rbdDonorName_CheckedChanged(object sender, EventArgs e)
        {
            lblDonorID.Visible = false;
            lblDonorName.Visible = true;
            lblMRNO.Visible = false;
        }

        private void rbdMRNO_CheckedChanged(object sender, EventArgs e)
        {
            lblDonorID.Visible = false;
            lblDonorName.Visible = false;
            lblMRNO.Visible = true;
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

            var distinctDonors = donors.GroupBy(donor => donor.Name).ToList().Select(
                                                 x => new SelectedDonorOptions
                                                 {
                                                     Name = x.Key,
                                                     Id = x.Select(y => y.Id).FirstOrDefault()
                                                 }).ToList();
            cmbDonorID.DataSource = distinctDonors;
            cmbDonorID.DisplayMember = "Id";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            DonationInformation parent = (DonationInformation)this.Owner;
            var donorId = cmbDonorID.SelectedItem as SelectedDonorOptions;
            var selectedDonor = donors.Where(donor => donor.Id == donorId.Id).FirstOrDefault();
            parent.getDataFromChildWindow(selectedDonor);
            this.Close();
        }

        private void cmbDonorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var donorId = cmbDonorID.SelectedItem as SelectedDonorOptions;
        }
    }
}
