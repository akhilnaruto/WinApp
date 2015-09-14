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
using System.Drawing.Printing;


namespace eTemple.UI
{
    public partial class VIPPrasadamForm : Form
    {
        public int ActualStock { get; set; }

        public VIPPrasadamForm()
        {
            InitializeComponent();
        }

        private void ShowVIPPrasadam()
        {
            var VIPDao = new VIPPrasadamDao();
            String dt = String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(currentDateTimePicker.Value));
            dgvVIPPrasadam.AutoGenerateColumns = false;
            dgvVIPPrasadam.DataSource = VIPDao.GetAllVIPPrasadamDetails(dt);
        }

        private void ShowVIP(VIPPrasadam poObj)
        {
            txtId.Text = poObj.Id.ToString();
            txtVIPName.Text = poObj.VIPName;
            txtPhone.Text = poObj.Phone;
            cmbReferenceBy.SelectedValue = poObj.ReferenceBy;
            cmbServiceID.SelectedValue = poObj.ServiceId;
            numQty.Value = poObj.Qty;
            ActualStock = poObj.Qty;
            dtVisitedDate.Value = Convert.ToDateTime(poObj.VisitedDate);
        }

        private void VIPPrasadamForm_Load(object sender, EventArgs e)
        {
            var empDao = new EmployeeDao();
            cmbReferenceBy.DataSource = empDao.GetAllEmployees();
            cmbReferenceBy.DisplayMember = "Name";
            cmbReferenceBy.ValueMember = "Id";
            var serviceDao = new ServiceDao();
            cmbServiceID.DataSource = serviceDao.GetAllVIPPrasadam();
            ShowVIPPrasadam();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowVIPPrasadam();
        }

        private void dgvVIPPrasadam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var poObj = dgvVIPPrasadam.Rows[e.RowIndex].DataBoundItem as VIPPrasadam;
                ShowVIP(poObj);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var sdDao = new StockDetailsDao();
            int serviceId = (cmbServiceID.SelectedItem as Service).Id;
            string serviceName = (cmbServiceID.SelectedItem as Service).Name;
            int stockVal = Convert.ToInt32(numQty.Text) - ActualStock;
            //stockVal = -(stockVal);
            sdDao.UpdateStockDetail(stockVal, serviceId);
            
            int poId = 0;
            int.TryParse(txtId.Text, out poId);

            int cUser = (cmbReferenceBy.SelectedItem as Employee).Id;

            var poObj = new VIPPrasadam
            {
                Id = poId,
                ServiceId = (cmbServiceID.SelectedItem as Service).Id,
                VIPName = txtVIPName.Text,
                Phone = txtPhone.Text,
                ReferenceBy = cUser,
                Qty = Convert.ToInt32(numQty.Text),
                VisitedDate = Convert.ToDateTime(dtVisitedDate.Value),
                IssuedBy = App.LoggedInEmployee.Id
            };

            var poDao = new VIPPrasadamDao();
            int tokenId = poDao.SaveVIPPrasadam(poObj);

            var savedTokens = new List<VIPPrasadam>();

            poObj = poDao.getTokenById(tokenId);
            savedTokens.Add(poObj);
            ShowVIPPrasadam();
            PrintTokens2(savedTokens);
        }

        #region Printing Related

        private void PrintTokens2(List<VIPPrasadam> tokens)
        {
            _tokensToPrint = tokens;
            _pageCounter = 0;

            PrintDocument pd = new PrintDocument();
            PrintDocument pd1 = new PrintDocument();

            pd.DefaultPageSettings.PaperSize = paperSize;
            pd.PrintPage += printDoc_PrintPage;
            pd.PrinterSettings.PrinterName = App.AppMainForm.GetTokenPrinter();

            //ToDo: can remove preview in the actual production.
            if (App.AppMainForm.IsPrintPreviewEnabled)
            {
                var ppDlg = new PrintPreviewDialog();
                ppDlg.SetBounds(30, 30, 1024, 500);
                ppDlg.PrintPreviewControl.AutoZoom = true;
                ppDlg.PrintPreviewControl.Zoom = 0.75;
                ppDlg.Document = pd;
                var dr = ppDlg.ShowDialog(this);
            }
            else
            {
                pd.Print();
            }
        }


        private string RenderToken2(VIPPrasadam token)
        {
            var sb = new StringBuilder();
            string line = string.Empty;
            /*
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            */
            sb.AppendLine();
            sb.AppendLine(_rulerLine);
            line = string.Format("  Sl No : {0}", token.Id).PadRight(_lineWidth / 2);
            sb.AppendLine(line);
            
            line = string.Format("Date : {0:dd/MM/yyyy h:mm tt}  ", token.VisitedDate).PadLeft(_lineWidth / 2);
            sb.AppendLine(line);
            
            sb.AppendLine(_rulerLine);

            if (token.ServiceName != "")
            {
                line = string.Format(" Purpose : {0}", token.ServiceName).PadRight(_lineWidth);
                sb.AppendLine(line);
            }

            if (token.VIPName != "")
            {
                line = string.Format("{0}", token.VIPName).PadRight(_lineWidth);
                sb.AppendLine(line);
            }

            sb.AppendLine(_rulerLine);

            line = string.Format(" Qty : {0}", token.Qty).PadRight(_lineWidth / 2);
            sb.AppendLine(line);

            sb.AppendLine(_rulerLine);
            sb.AppendLine();

            line = string.Format("Issued by : {0}", App.LoggedInEmployee.Name);
            sb.AppendLine(line);

            return sb.ToString();
        }

        int _pageCounter;
        List<VIPPrasadam> _tokensToPrint;
        private const int _lineWidth = 45;
        private string _rulerLine = string.Empty.PadLeft(_lineWidth, '-');
        PaperSize paperSize = new PaperSize("Custom receipt", 300, 500);

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Segoe UI", 13, System.Drawing.FontStyle.Bold);

            if (_pageCounter < _tokensToPrint.Count)
            {
                e.Graphics.DrawString(RenderToken2(_tokensToPrint[_pageCounter]),
                    printFont, System.Drawing.Brushes.Black, 10, 10);

                _pageCounter++;

                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                _pageCounter = 0;
            }
        }

        #endregion

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowVIPPrasadam();
        }


    }
}
