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
    public partial class POCMainForm : Form
    {
        public POCMainForm()
        {
            InitializeComponent();
        }

        private void POCMainForm_Load(object sender, EventArgs e)
        {
            LoadPOCServiceGrid();
        }

        private void LoadPOCServiceGrid()
        {
            var serviceDao = new ServiceDao();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = serviceDao.GetAllServices();
        }

        private void POCMainForm_Load_1(object sender, EventArgs e)
        {
            LoadPOCServiceGrid();
        }

        private void dataGridView1_RowDirtyStateNeeded(object sender, QuestionEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1[e.ColumnIndex, e.RowIndex].Value != null)
            {
                dataGridView1[e.ColumnIndex + 3, 2].Value = 10;
                var price = Convert.ToDouble(dataGridView1[e.ColumnIndex + 1, e.RowIndex].Value);
                int quantity = 0;
                bool Res = int.TryParse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString(), out quantity);
                int maxAmt = 0;
                bool res1;
                if (dataGridView1[e.ColumnIndex + 3, e.RowIndex].Value != null)
                    res1 = int.TryParse(dataGridView1[e.ColumnIndex + 3, e.RowIndex].Value.ToString(), out maxAmt);
                else
                    maxAmt = quantity + 1;
                if ((quantity < maxAmt) && Res)
                    dataGridView1[e.ColumnIndex + 2, e.RowIndex].Value = CalculateAmount(price, quantity).ToString();
                else
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = string.Empty;
            }

        }




        public double CalculateAmount(Double price, int quantity)
        {
            return price * quantity;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



        private void SaveServices()
        {

        }

        private void t1_Tick(object sender, EventArgs e)
        {
            var stockDetailsDAO = new StockDetailsDao();
            dgvPrasadamStatus.AutoGenerateColumns = false;
            dgvPrasadamStatus.DataSource = stockDetailsDAO.GetAllStockDetails();
        }

    }
}
