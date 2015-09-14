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
    public partial class MiscIncomeForm : Form
    {
        private int serviceId { get; set; }
        private long sdailyNumber;
        private long dailyNumber;

        public MiscIncomeForm()
        {
            InitializeComponent();
        }

        private void ShowMiscIncomes()
        {
            var serviceDaoObj = new ServiceDao();
            serviceId = serviceDaoObj.GetMiscIncomes();
            var tokenDaoObj = new TokenDao();
            dgvMiscIncomes.AutoGenerateColumns = false;
            dgvMiscIncomes.DataSource = tokenDaoObj.GetMiscIncomeDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiscIncomeForm_Load(object sender, EventArgs e)
        {
            tblPanel1.Location = new Point(
                (this.ClientSize.Width / 2) - (tblPanel1.Size.Width / 2)
            );
            ShowMiscIncomes();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int tId = 0;
            int.TryParse(txtId.Text, out tId);
            double amt = 0;
            amt = Convert.ToDouble(txtTotalCost.Text);
            var tokenDAO = new TokenDao();
            if (tId == 0)
            {
                sdailyNumber = tokenDAO.getHighestDailyNumber(serviceId) + 1;
                dailyNumber = tokenDAO.getMaxDailyNumber(DateTime.Now) + 1;
            }
            var tokenObj = new Token
            {
                Id = tId,
                ServiceId = serviceId,
                Quantity = 1,
                TotalCost = amt,
                ServicePerformDate = Convert.ToDateTime(dtpPerformDate.Value),
                Status = 1,
                ServiceDailyNumber = sdailyNumber,
                DailyNumber = dailyNumber,
                CreatedOn = DateTime.Now,
                CreatedBy = App.LoggedInEmployee.Id,
                AmountDescription = txtAmountDescription.Text
            };
            tokenDAO.SaveToken(tokenObj);
            ShowMiscIncomes();
        }

        private void dgvMiscIncomes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var tokenDaoObj = dgvMiscIncomes.Rows[e.RowIndex].DataBoundItem as Token;
                ShowMiscIncomeRow(tokenDaoObj);
            }
        }
        private void ShowMiscIncomeRow(Token tObj)
        {
            dtpPerformDate.Text = tObj.ServicePerformDate.ToString();
            txtTotalCost.Text = tObj.TotalCost.ToString();
            txtId.Text = tObj.Id.ToString();
            sdailyNumber = Convert.ToInt64(tObj.ServiceDailyNumber);
            dailyNumber = Convert.ToInt64(tObj.DailyNumber);
            txtAmountDescription.Text = tObj.AmountDescription;
        }
    }
}
