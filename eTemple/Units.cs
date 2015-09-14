using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTemple.UI
{
    public partial class Units : Form
    {
        public Units()
        {
            InitializeComponent();
            listall();
        }

        private void listall()
        {
            var lgnDao = new Data.UnitsDao();
            dataGridView1.DataSource = lgnDao.GetAllUnits();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = true;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Unit Name";
            dataGridView1.Columns[2].HeaderText = "Delete Status";
            dataGridView1.Columns[3].HeaderText = "Created On";
            dataGridView1.Columns[4].HeaderText = "Created By";
            txtUnitname.Focus();
        }

        private void Units_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Unitname = txtUnitname.Text;
            var untDao = new Data.UnitsDao();
            int result = untDao.AddUnit(Unitname);
            if (result == 1)
            {
                MessageBox.Show("Unit Details Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtUnitname.Text = "";
            }
            else
            {
                MessageBox.Show("Error occured while Adding Unit Details", "Unable to add Units !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            listall();
        }
    }
}
