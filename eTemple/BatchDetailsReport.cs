using eTemple.Data;
using eTemple.Data.Models;
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
    public partial class BatchDetailsReport : Form
    {
        public long StartDailyNumberVal { get; set; }
        public long LastDailyNumberVal { get; set; }
        public int ServiceIDVal { get; set; }
        public int BatchIdVal { get; set; }
        public DateTime BatchTimeVal { get; set; }
        
        public BatchDetailsReport()
        {
            InitializeComponent();
        }

        private void BatchDetailsReport_Load(object sender, EventArgs e)
        {
            //List<Token> = new  BatchDao().GetBatchDetails(this.BatchId);
            //dgvBatchDetails
            var tokenObj = new TokenDao();
            dgvBatchDetails.AutoGenerateColumns = false;
            dgvBatchDetails.DataSource = tokenObj.GetSelectedServiceDevotees(StartDailyNumberVal, LastDailyNumberVal, ServiceIDVal);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer();
            reportViewer.HeaderWidthPercent = 100;
            reportViewer.ContentWidthPercent = 100;
            reportViewer.RowsPerPage = 30;
            //reportViewer.HeaderContent = string.Format("<h2 style='margin-left:100px'>Daily Collection Report for the Date of {0:dd/MM/yyyy}</h2>", this.dtpFromDate.Value);
            reportViewer.HeaderContent = string.Format("<div style='float: left; width: 350px;'>Batch : {0} </div> <div style='float: left;'>Time : {1:h:mm:s tt}</div>", BatchIdVal.ToString(), BatchTimeVal);
            reportViewer.GenerateFromGridView(this.dgvBatchDetails, false);
            reportViewer.Show(this);
        }

        private void dgvBatchDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
