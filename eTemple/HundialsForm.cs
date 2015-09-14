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
    public partial class HundialsForm : Form
    {
        private int serviceId { get; set; }
        private long sdailyNumber;
        private long dailyNumber;


        public HundialsForm()
        {
            InitializeComponent();
        }
        
        private void ShowHundials()
        {
            var serviceDaoObj = new ServiceDao();
            serviceId = serviceDaoObj.GetHundials();
            var tokenDaoObj = new TokenDao();
            dgvHundial.AutoGenerateColumns = false;
            dgvHundial.DataSource = tokenDaoObj.GetHundialsDetails();
        }

        private void HundialsForm_Load(object sender, EventArgs e)
        {
            tblPanel1.Location = new Point(
                (this.ClientSize.Width / 2) - (tblPanel1.Size.Width / 2)
            );
            ShowHundials();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvHundial.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                CreatedBy = App.LoggedInEmployee.Id
            };
            tokenDAO.SaveToken(tokenObj);
            ShowHundials();
        }

        private void dgvHundial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var tokenDaoObj = dgvHundial.Rows[e.RowIndex].DataBoundItem as Token;
                ShowHundialRow(tokenDaoObj);
            }
        }
        private void ShowHundialRow(Token tObj)
        {
            dtpPerformDate.Text = tObj.ServicePerformDate.ToString();
            txtTotalCost.Text = tObj.TotalCost.ToString();
            txtId.Text = tObj.Id.ToString();
            sdailyNumber = Convert.ToInt64(tObj.ServiceDailyNumber);
            dailyNumber = Convert.ToInt64(tObj.DailyNumber);
        }
    }
}
