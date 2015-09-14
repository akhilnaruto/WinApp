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
    public partial class GenerateBatchForm : Form
    {
        String cdtval;
        public GenerateBatchForm()
        {
            InitializeComponent();
        }

        private void GenerateBatchForm_Load(object sender, EventArgs e)
        {
            cdtval = DateTime.Now.ToString("yyyy-MM-dd");
            var servceDao = new ServiceDao();
            cmbServiceName.DataSource = servceDao.GetAllPoojasExceptPrasadam();
            var batchDaoObject = new BatchDao();
            dgvBatchTokens.AutoGenerateColumns = false;
            dgvBatchTokens.DataSource = batchDaoObject.GetAllBatches();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            long startuniid = 0;
            long lastuniid = 0;
            int serviceId = (cmbServiceName.SelectedItem as Service).Id;
            startuniid = new BatchDao().GetLastBatchDailyNumberByService(serviceId);

            int dailyBID = new BatchDao().GetDailyBatchByService(serviceId, cdtval);

            var tokenObj = new TokenDao();
            if (startuniid == 0)
            {
                startuniid = tokenObj.getLeastDailyNumber(serviceId);
                lastuniid = tokenObj.getHighestDailyNumber(serviceId);
            }
            else
            {
                startuniid = startuniid + 1;
                lastuniid = tokenObj.getHighestDailyNumber(serviceId);
            }
            if (startuniid < lastuniid)
            {
                var batchObj = new Batch
                {
                    ServiceId = serviceId,
                    StartDailyNumber = startuniid,
                    LastDailyNumber = lastuniid,
                    CreatedOn = DateTime.Now,
                    DailyBatchId = dailyBID,
                    CreatedBy = App.LoggedInEmployee.Id
                };

                var batchDaoObject = new BatchDao();
                batchDaoObject.SaveBatch(batchObj);
                //batchDaoObject.GetLastBatchByService(serviceId);

                dgvBatchTokens.DataSource = batchDaoObject.GetAllBatches();

                //dgvBatchTokens.DataSource = tokenObj.GetSelectedServiceDevotees(startuniid, lastuniid, serviceId);

                MessageBox.Show("Batch Data Generated Successfully.");
            }
            else
            {
                MessageBox.Show("There is no new data to generate Batch");
            }
        }

        private void dgvBatchTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var batch = dgvBatchTokens.Rows[e.RowIndex].DataBoundItem as Batch;
                if (batch != null)
                {
                    var detailsForm = new BatchDetailsReport();
                    detailsForm.StartDailyNumberVal = batch.StartDailyNumber;
                    detailsForm.LastDailyNumberVal = batch.LastDailyNumber;
                    detailsForm.ServiceIDVal = batch.ServiceId;
                    detailsForm.BatchIdVal = batch.Id;
                    detailsForm.BatchTimeVal = batch.CreatedOn;
                    detailsForm.Show(this);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
