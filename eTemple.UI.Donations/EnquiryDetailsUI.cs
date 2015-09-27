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
namespace eTemple.UI.Donations
{
    public partial class EnquiryDetailsUI : Form
    {
        DonorRepository donorRepositoy;
        List<Donors> donors = new List<Donors>();
   
        public EnquiryDetailsUI()
        {
            InitializeComponent();
            donorRepositoy = new DonorRepository();
            donors = donorRepositoy.GetAllAsQuerable().ToList();;
            dataGridView1.AutoGenerateColumns = false;

        }

        private void EnquiryDetailsUI_Load(object sender, EventArgs e)
        {
            LoadDataAndRenderInUI();
        }

        private void LoadDataAndRenderInUI()
        {
         
            var distinctDonors = donors.GroupBy(donor => donor.DonorName).ToList().Select(
                                                 x => new SelectedDonor
                                                 {
                                                     Name = x.Key,
                                                     Id = x.Select(y => y.Id).FirstOrDefault(),
                                                     PhoneNumber = x.Select(y => y.Landline).FirstOrDefault(),
                                                     Mr_Number = x.Select(y => y.MR_No).FirstOrDefault().ToString(),
                                                     City = x.Select(y => y.City).FirstOrDefault(),
                                                 }).ToList();
                         
 
            donorIdComboBox.DataSource = distinctDonors;
            donorNameComboBox.DataSource = distinctDonors;
            phoneNumberComboBox.DataSource = distinctDonors;
            citiComboBox.DataSource = distinctDonors;
            mrNumberComboBox.DataSource = distinctDonors;
            donorIdComboBox.DisplayMember = "Id";
            donorNameComboBox.DisplayMember = "Name";
            phoneNumberComboBox.DisplayMember = "PhoneNumber";
            citiComboBox.DisplayMember = "City";
            mrNumberComboBox.DisplayMember = "Mr_Number";
            RenderDataGrid();

        }

        private void RenderDataGrid()
        {
            var selectedDonor = donorNameComboBox.SelectedItem as SelectedDonor;
            if(selectedDonor != null)
            {
                var matchedDonors = donors.Where(donor => donor.DonorName == selectedDonor.Name);
                AddMatchedDonorsToGrid(matchedDonors.ToList());
            }


        }

        private void AddMatchedDonorsToGrid(List<Donors> matchedDonors)
        {
            dataGridView1.Rows.Clear();
            foreach (var donor in matchedDonors)
            {
                dataGridView1.Rows.Add(donor.Id, donor.Surname, donor.DonorName, donor.Address);
            }
        }
     

        private void donorIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderDataGrid();

        }

        private void donorNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderDataGrid();
        }

        private void phoneNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

      


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }

    internal class SelectedDonor
    {
        public string Id { get; set; }
        public string Mr_Number { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
    }
}
