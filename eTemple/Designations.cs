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

namespace eTemple.UI
{
    public partial class Designations : Form
    {
        public Designations()
        {
            InitializeComponent();
            //ShowDesignations();
        }

        private void ShowDesignations()
        {
            var designationDao = new DesignationDao();
            dgvDesignation.DataSource = designationDao.GetAllDesignations();
        }

        private void Designations_Load(object sender, EventArgs e)
        {
            ShowDesignations();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ShowDesignation(Designation designationobj)
        {
            txtDesignationID.Text = designationobj.Id.ToString();
            txtDesignationName.Text = designationobj.Name;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowDesignations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DesignationId = 0;
            int.TryParse(txtDesignationID.Text, out DesignationId);
            var designation_obj = new Designation
            {
                Id = DesignationId,
                Name = txtDesignationName.Text
            };
            var designationDao = new DesignationDao();
            designationDao.SaveDesignation(designation_obj);
            ShowDesignations();
        }

        private void dgvDesignation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var designation_obj = dgvDesignation.Rows[e.RowIndex].DataBoundItem as Designation;
                ShowDesignation(designation_obj);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
