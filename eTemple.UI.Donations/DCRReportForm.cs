using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using eTemple.Data.Repositories;
using eTemple.Data.Models;


namespace eTemple.UI.Donations
{
    public partial class DCRReportForm : Form
    {
        //public DataTable DonorRecs = null;
        public DataTable DCRVals = null;
        public DonorRepository oDonorRepository = null;
        public DailyAnnaDanamRepository oDailyAnnaDanamRepository = null;
        public DCRReportForm()
        {
            InitializeComponent();
            oDonorRepository = new DonorRepository();
            oDailyAnnaDanamRepository = new DailyAnnaDanamRepository();
            DCRVals = new DataTable();
        }

        private void DonorReportForm_Load(object sender, EventArgs e)
        {
            DataSet DonorRecs = oDonorRepository.getTotalAmountperSVC(DateTime.Now.ToString("yyyy-MM-dd"));
            int count = 0;
            double totalAmount = 0;
            string perfrmDate = DateTime.Now.ToString("dd-MM-yyyy");
            DCRVals.Columns.Add("PerformDate");
            DCRVals.Columns.Add("Sno");
            DCRVals.Columns.Add("ServiceType");
            DCRVals.Columns.Add("CostPerUnit");
            DCRVals.Columns.Add("Start");
            DCRVals.Columns.Add("End");
            DCRVals.Columns.Add("Quantity");
            DCRVals.Columns.Add("TotalCost");


            foreach (DataRow dr in DonorRecs.Tables[0].Rows)
            {
                DataRow drNew = DCRVals.NewRow();
                drNew["PerformDate"] = perfrmDate;
                drNew["Sno"] = count+1;
                drNew["ServiceType"] = dr["ServiceType"];
                drNew["CostPerUnit"] = "0.00";
                drNew["Start"] = "0";
                drNew["End"] = "0";
                drNew["Quantity"] = dr["cnt"];
                drNew["TotalCost"] = dr["Amount"];
                count++;
                totalAmount = totalAmount + Convert.ToDouble(dr["Amount"]);
                DCRVals.Rows.Add(drNew);
            }
            int qty = Convert.ToInt32(oDailyAnnaDanamRepository.getTotalAmtperDate(DateTime.Now.ToString("yyyy-MM-dd")).Tables[0].Rows[0][0]);
            if (qty > 0)
            {
                DataRow drDailyAnndnmRow = DCRVals.NewRow();
                drDailyAnndnmRow["PerformDate"] = perfrmDate;
                drDailyAnndnmRow["Sno"] = count+1;
                drDailyAnndnmRow["ServiceType"] = "Daily Annadanam";
                drDailyAnndnmRow["CostPerUnit"] = "116";
                drDailyAnndnmRow["Start"] = "0";
                drDailyAnndnmRow["End"] = "0";
                drDailyAnndnmRow["Quantity"] = qty;
                totalAmount = totalAmount + (qty * Convert.ToDouble(drDailyAnndnmRow["CostPerUnit"]));
                drDailyAnndnmRow["TotalCost"] = totalAmount;
                DCRVals.Rows.Add(drDailyAnndnmRow);
            }
            DataRow drTotalRow = DCRVals.NewRow();
            drTotalRow["PerformDate"] = perfrmDate;
            drTotalRow["Sno"] = 0;
            drTotalRow["ServiceType"] = "Totals";
            drTotalRow["CostPerUnit"] = "0.00";
            drTotalRow["Start"] = "0";
            drTotalRow["End"] = "0";
            drTotalRow["Quantity"] = "0";
            drTotalRow["TotalCost"] = string.Format("{0:0.00}", totalAmount);
            DCRVals.Rows.Add(drTotalRow);
            ReportDataSource rds = new ReportDataSource("DCRDataSet", DCRVals);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            PageSettings pg = new PageSettings();
            PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.Legal;
            pg.PaperSize = size;
            reportViewer1.SetPageSettings(pg);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
