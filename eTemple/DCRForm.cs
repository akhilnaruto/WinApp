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
    public partial class DCRForm : Form
    {
        public DCRForm()
        {
            InitializeComponent();
            
        }

        public void LoadReport()
        {
            dgvReport.AutoGenerateColumns = false;
            var data = new ServiceDao().GetDcrReport(dtpFromDate.Value, dtpToDate.Value);
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            var startDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day);
            var endDate = new DateTime(toDate.Year, toDate.Month, toDate.Day);

            if (startDate == endDate)
                endDate.AddDays(1);

            //MessageBox.Show("select s.Id, s.Name, s.Cost, sum(t.Quantity) as SoldQuantity, s.Type, sum(t.TotalCost) as TotalCollection, max(t.ServiceDailyNumber) as EndingNumber, min(t.ServiceDailyNumber) as StartingNumber from Services s left outer join Tokens t on ( s.Id = t.ServiceId and t.CreatedOn between " + startDate + " and " + endDate + " and t.Status=1 and s.Type not in(16) ) group by s.Id, s.Name");

            var totals = new Service();
            totals.Name = "Totals";
            //totals.SoldQuantity = data.Sum(x => x.SoldQuantity);
            totals.TotalCollection = data.Sum(x => x.TotalCollection);
            data.Add(totals);

            dgvReport.DataSource = data;
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var VIPDaoObj = new VIPPrasadamDao();
            var abc = VIPDaoObj.GetDaycount(this.dtpFromDate.Value);
            var dt1 = String.Format("{0:dd-MM-yyyy}", this.dtpFromDate.Value);
            int i = 0;
            String VIPContent = "అతిధి సత్కారం కొరకు " + dt1 + " తేదిన వినియోగించిన సరుకు వివరములు : ";
            while (i < abc.Count)
            {
                var xyz = abc[i] as VIPPrasadam;
                VIPContent = VIPContent + xyz.ServiceName + " " + xyz.Qty;
                i = i + 1;
                if (i < abc.Count)
                {
                    VIPContent = VIPContent + ", ";
                }
            }
            if (abc.Count == 0)
            {
                VIPContent = "";
            }
            
            DateTime cdatetime = DateTime.Now;
            var cdt = String.Format("{0:dd-MM-yyyy h:mm tt}", cdatetime);
            var DCRGenDT = "Generated on : " + cdt;
            var reportViewer = new ReportViewer();
            reportViewer.HeaderWidthPercent = 100;
            reportViewer.ContentWidthPercent = 100;
            reportViewer.RowsPerPage = 30;

            var duration = dtpToDate.Value - dtpFromDate.Value;
            
            if (duration.Days > 0)
            {
                reportViewer.HeaderContent = string.Format("<center><h2>Daily Collection Report from {0:dd/MM/yyyy} to {1:dd/MM/yyyy}</h2></center>", this.dtpFromDate.Value, this.dtpToDate.Value);
            }
            else
            {
                reportViewer.HeaderContent = string.Format("<center><h2>Daily Collection Report for the Date of {0:dd/MM/yyyy}</h2></center>", this.dtpFromDate.Value);
            }
            if (VIPContent != "")
            {
                reportViewer.FooterContent = string.Format("<span><br />{0}</span>", VIPContent);
            }


            var tokenDAO = new TokenDao();
            Double CashDt = tokenDAO.GEtTotalCostByTransactionType(dtpFromDate.Value, dtpToDate.Value, "Cash");
            Double CardDt = tokenDAO.GEtTotalCostByTransactionType(dtpFromDate.Value, dtpToDate.Value, "Credit/Debit Card");
            Double DDDt = tokenDAO.GEtTotalCostByTransactionType(dtpFromDate.Value, dtpToDate.Value, "DD");
            Double ChequeDt = tokenDAO.GEtTotalCostByTransactionType(dtpFromDate.Value, dtpToDate.Value, "Cheque");
            var DCRCashDT = "Amount from Cash Transactions : Rs." + CashDt + "/-";
            var DCRCardDT = "Amount from Card Transactions : Rs." + CardDt + "/-";
            var DCRDDDT = "Amount from DD Transactions : Rs." + DDDt + "/-";
            var DCRChequeDT = "Amount from Cheque Transactions : Rs." + ChequeDt + "/-";

            reportViewer.FooterContent = reportViewer.FooterContent + string.Format("<span><br />{0}</span>", DCRGenDT);

            reportViewer.FooterContent = reportViewer.FooterContent + string.Format("<span><br />{0}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{1}</span>", DCRCashDT, DCRCardDT);
            reportViewer.FooterContent = reportViewer.FooterContent + string.Format("<span><br />{0}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{1}</span>", DCRDDDT, DCRChequeDT);
            
            reportViewer.GenerateFromGridView(this.dgvReport, false);
            reportViewer.Show(this);
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DCRForm_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Location = new Point(
                (this.ClientSize.Width / 2) - (tableLayoutPanel1.Size.Width / 2)
            );
        }
    }
}
