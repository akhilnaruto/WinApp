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
    public partial class PoojaReport : Form
    {
        public PoojaReport()
        {
            InitializeComponent();
        }

        private void PoojaReport_Load(object sender, EventArgs e)
        {
            var serviceDao = new ServiceDao();
            cmbServiceID.DataSource = serviceDao.GetAllPoojasExceptVIPPrasadam();
            dgvServiceReport.AutoGenerateColumns = false;
            if (App.LoggedInEmployee.Designation == 3)
            {
                dgvServiceReport.Columns[Constants.GridColumnIndex_Tokens_EditAction].Visible = true;
                dgvServiceReport.Columns[Constants.GridColumnIndex_Tokens_Action].Visible = true;
            }
            else
            {
                dgvServiceReport.Columns[Constants.GridColumnIndex_Tokens_EditAction].Visible = false;
                dgvServiceReport.Columns[Constants.GridColumnIndex_Tokens_Action].Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbServiceID.Text != null && fldName.Text != "" && dtValue.Text != null)
            {
                int ServiceID = (cmbServiceID.SelectedItem as Service).Id;
                String fldNameValue = fldName.Text;
                String dtval = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(dtValue.Text));
                var tokenDao = new TokenDao();
                dgvServiceReport.AutoGenerateColumns = false;
                var data = tokenDao.GetServiceReport(ServiceID, fldNameValue, dtval);

                var totals = new Token();
                totals.DevoteeName = "Totals";
                //totals.SoldQuantity = data.Sum(x => x.SoldQuantity);
                totals.TotalCost = data.Sum(x => x.TotalCost);
                data.Add(totals);
                dgvServiceReport.DataSource = data;
            }
            else
            {
                if (cmbServiceID.Text != null)
                {
                    MessageBox.Show("Select Service");
                }
                else if (fldName.Text != null)
                {
                    MessageBox.Show("Select CreatedOn / ServicePerformDate");
                }
                else if (dtValue.Text != null)
                {
                    MessageBox.Show("Select Date");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvServiceReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == Constants.GridColumnIndex_Tokens_Action && e.RowIndex >= 0)
            {
                //ToDo: also write code to remove the devotee rows from the left side grid.
                //_selectedTokens.RemoveAt(e.RowIndex);


                if (e.RowIndex >= 0)
                {
                    var tkn = dgvServiceReport.Rows[e.RowIndex].DataBoundItem as Token;
                    if (tkn != null && tkn.ServiceTypeID == 5)
                    {
                        var reportViewer = new ServiceDetailsPrint();
                        reportViewer.HeaderWidthPercent = 100;
                        reportViewer.ContentWidthPercent = 100;
                        reportViewer.RowsPerPage = 25;
                        reportViewer.HeaderContent = string.Format("<center><table width='690'><tr><td height='400' valign='bottom' align='right'>{0:dd/MM/yyyy}</td></tr></table>", tkn.CreatedOn);
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<table width='690'><tr><td width='350'></td><td width='330' align='left'> {0}, <br />{1}, <br />{2}, <br />{3}</td></tr>", tkn.DevoteeName, tkn.DoorNumber, tkn.AreaName, tkn.City);
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td height='15'></td></tr>");
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td> {0} </td></tr>", tkn.DevoteeName);
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td height='15'></td></tr>");
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td> {0} </td></tr>", tkn.Gothram);
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td height='15'></td></tr>");
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td> {0:dd-MM-yyyy} </td></tr>", tkn.ServicePerformDate);
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td height='15'></td></tr>");
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td>{0} </td></tr>", tkn.TotalCost);
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td height='15'></td></tr>");
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td> {0} </td></tr>", tkn.PhoneNumber);
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("<tr><td></td><td height='15'></td></tr>");
                        reportViewer.HeaderContent = reportViewer.HeaderContent + string.Format("</table></center>");
                        reportViewer.Show(this);
                    }
                    else
                    {
                        var savedTokens = new List<Token>();
                        savedTokens.Add(tkn);
                        PrintTokens3(savedTokens);
                        // MessageBox.Show("Sorry, You can use this option for Saswatha Annadanam only.");
                    }
                }
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == Constants.GridColumnIndex_Tokens_EditAction && e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    var tkn = dgvServiceReport.Rows[e.RowIndex].DataBoundItem as Token;
                    if (tkn != null)
                    {
                        var editReceiptObject = new EditReceipt();
                        editReceiptObject.recieptId = tkn.Id;
                        editReceiptObject.Show(this);
                    }
                }
                else
                {
                    MessageBox.Show("You don't have rights to change this data.");
                    //MessageBox.Show("Sorry, You can't use this option for this type");
                }
            }
        }


        public class Constants
        {
            public const int GridColumnIndex_Devotees_TokenId = 0;
            public const int GridColumnIndex_Tokens_ServiceDailyNumber = 1;
            public const int GridColumnIndex_Devotees_Gothram = 2;
            public const int GridColumnIndex_Devotees_DevoteeName = 3;
            public const int GridColumnIndex_Tokens_Quantity = 4;
            public const int GridColumnIndex_Devotees_TotalCost = 5;
            public const int GridColumnIndex_Tokens_ServicePerformDate = 6;
            public const int GridColumnIndex_Tokens_CreatedOn = 7;
            public const int GridColumnIndex_Tokens_Created_By = 8;
            public const int GridColumnIndex_Tokens_TokenStatus = 9;
            public const int GridColumnIndex_Tokens_Action = 10;
            public const int GridColumnIndex_Tokens_EditAction = 11;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbServiceID.Text != null && fldName.Text != "" && dtValue.Text != null)
            {
                int ServiceID = (cmbServiceID.SelectedItem as Service).Id;
                String fldNameValue = fldName.Text;
                String dtval = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(dtValue.Text));

                var detailsForm = new ServicesPrintForm();
                detailsForm.ServiceID = ServiceID;
                detailsForm.fldNameValue = fldNameValue;
                detailsForm.dtval = dtval;
                detailsForm.Show(this);
            }
            else
            {
                if (cmbServiceID.Text != null)
                {
                    MessageBox.Show("Select Service");
                }
                else if (fldName.Text != null)
                {
                    MessageBox.Show("Select CreatedOn / ServicePerformDate");
                }
                else if (dtValue.Text != null)
                {
                    MessageBox.Show("Select Date");
                }
            }
        }


        #region Printing Related

        private void PrintTokens3(List<Token> tokens)
        {
            _tokensToPrint = tokens;
            _pageCounter = 0;

            PrintDocument pd = new PrintDocument();
            PrintDocument pd1 = new PrintDocument();

            if (_tokensToPrint[_pageCounter].ServiceTypeID != 9)
            {
                pd.DefaultPageSettings.PaperSize = paperSize;
                pd.PrintPage += printDoc_PrintPage;
                pd.PrinterSettings.PrinterName = App.AppMainForm.GetTokenPrinter();
            }
            else
            {
                pd1.DefaultPageSettings.PaperSize = paperSize1;
                pd1.PrintPage += printDoc_PrintPage_1;
                pd1.PrinterSettings.PrinterName = App.AppMainForm.GetSlipPrinter();
            }

            //ToDo: can remove preview in the actual production.
            if (App.AppMainForm.IsPrintPreviewEnabled)
            {
                var ppDlg = new PrintPreviewDialog();
                ppDlg.SetBounds(30, 30, 1024, 500);
                ppDlg.PrintPreviewControl.AutoZoom = true;
                ppDlg.PrintPreviewControl.Zoom = 0.75;

                if (_tokensToPrint[_pageCounter].ServiceTypeID != 9)
                {
                    ppDlg.Document = pd;
                }
                else
                {
                    ppDlg.Document = pd1;
                }
                var dr = ppDlg.ShowDialog(this);
            }
            else
            {
                if (_tokensToPrint[_pageCounter].ServiceTypeID != 9)
                {
                    pd.Print();
                }
                else
                {
                    pd1.Print();
                }
            }
        }


        private string RenderToken3(Token token)
        {
            var sb = new StringBuilder();
            string line = string.Empty;
            string purpose = string.Empty;
            string PerformDate = string.Empty;
            string DailyNum = string.Empty;
            string CDate = string.Empty;
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            //sb.AppendLine();
            DailyNum = string.Format("{0}", token.DailyNumber).PadRight(_lineWidth / 2);
            CDate = string.Format("Date : {0:dd/MM/yyyy h:mm tt}  ", token.CreatedOn).PadRight(_lineWidth / 2);
            line = DailyNum;
            sb.AppendLine(line);
            line = string.Empty;
            line = CDate;
            sb.AppendLine(line);
            line = string.Empty;
            if (token.ServiceName != "")
            {
                purpose = string.Format("{0}", token.ServiceName).PadLeft(20);
            }
            if (token.ServiceTypeID != 2 && token.ServiceTypeID != 9)
            {
                PerformDate = string.Format("Perform Date : {0:dd/MM/yyyy}", token.ServicePerformDate).PadLeft(_lineWidth / 2);
            }

            line = string.Format("{0} {1}", token.PrefixName, token.DevoteeName).PadRight(60);
            if (purpose != "")
            {
                line = line + purpose;
            }
            sb.AppendLine(line);

            if (token.ServiceTypeID == 4)
            {
                if (token.City != "")
                {
                    line = string.Format("City : {0}", token.City).PadRight(_lineWidth / 2);
                }
            }
            else
            {
                line = string.Format("Gotram : {0}", token.Gothram).PadRight(_lineWidth / 2);
            }
            
            if (PerformDate != "")
            {
                line = line + PerformDate;
            }
            sb.AppendLine(line);
            line = "";

            if (token.ServiceTypeID == 10)
            {
                line = string.Format("{0}", token.AdditionalNames).PadRight(_lineWidth);
                sb.AppendLine(line);
            }
            if (token.ServiceId != 3)
            {
                line = string.Format("Qty : {0}", token.Quantity).PadRight(_lineWidth / 2);
            }
            if (token.ServiceTypeID == 9)
            {
                line += "";
            }
            else
            {
                if (token.ServiceId == 3)
                {
                    line = line + string.Format("Amt : {0:F}  ", token.TotalCost).PadLeft(_lineWidth);
                }
                else
                {
                    line = line + string.Format("Amt : {0:F}  ", token.TotalCost).PadLeft(_lineWidth / 2);
                }
            }
            sb.AppendLine(line);
            sb.AppendLine();
            sb.AppendLine();
            line = string.Format("Issued by : {0}", App.LoggedInEmployee.Name).PadRight(_lineWidth);
            sb.AppendLine(line);
            return sb.ToString();
        }

        private string RenderToken3_1(Token token)
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
            line = string.Format("Sl No : {0}", token.DailyNumber).PadRight(_lineWidth / 2);
            sb.AppendLine(line);
            line = string.Format("Date : {0:dd/MM/yyyy h:mm tt}  ", token.CreatedOn).PadLeft(_lineWidth / 2);
            sb.AppendLine(line);
            sb.AppendLine(_rulerLine);
            if (token.ServiceName != "")
            {
                line = string.Format("Purpose : {0}", token.ServiceName).PadRight(_lineWidth);
                sb.AppendLine(line);
            }
            if (token.ServiceTypeID != 2 && token.ServiceTypeID != 9)
            {
                line = string.Format("Perform Date : {0:dd/MM/yyyy}", token.ServicePerformDate).PadRight(_lineWidth);
                sb.AppendLine(line);
            }
            if (token.Gothram != "")
            {
                line = string.Format("{0}", token.Gothram).PadRight(_lineWidth);
                sb.AppendLine(line);
            }
            if (token.DevoteeName != "")
            {
                line = string.Format("{0} {1}", token.PrefixName, token.DevoteeName).PadRight(_lineWidth);
                sb.AppendLine(line);
            }

            if (token.ServiceTypeID == 10)
            {
                line = string.Format("{0}", token.AdditionalNames).PadRight(_lineWidth);
                sb.AppendLine(line);
            }

            sb.AppendLine(_rulerLine);

            line = string.Format("Qty : {0}", token.Quantity).PadRight(_lineWidth / 2);
            if (token.ServiceTypeID == 9)
            {
                line += "";
            }
            else
            {
                line = line + string.Format("Amt : {0:F}  ", token.TotalCost).PadLeft(_lineWidth / 2);
            }
            sb.AppendLine(line);

            sb.AppendLine(_rulerLine);
            sb.AppendLine();

            line = string.Format("Issued by : {0}", App.LoggedInEmployee.Name);
            sb.AppendLine(line);

            return sb.ToString();
        }
        int _pageCounter;
        List<Token> _tokensToPrint;
        private const int _lineWidth = 80;
        private string _rulerLine = string.Empty.PadLeft(_lineWidth, '-');
        PaperSize paperSize = new PaperSize("Custom receipt", 600, 300);
        PaperSize paperSize1 = new PaperSize("Custom receipt", 300, 500);

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Arial", 10, System.Drawing.FontStyle.Regular);

            if (_pageCounter < _tokensToPrint.Count)
            {
                e.Graphics.DrawString(RenderToken3(_tokensToPrint[_pageCounter]),
                    printFont, System.Drawing.Brushes.Black, 10, 10);

                _pageCounter++;
            }
            if (_pageCounter < _tokensToPrint.Count)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                _pageCounter = 0;
            }
        }

        public void printDoc_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Segoe UI", 13, System.Drawing.FontStyle.Bold);

            if (_pageCounter < _tokensToPrint.Count)
            {
                e.Graphics.DrawString(RenderToken3_1(_tokensToPrint[_pageCounter]),
                    printFont, System.Drawing.Brushes.Black, 10, 10);

                _pageCounter++;
            }
            if (_pageCounter < _tokensToPrint.Count)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                _pageCounter = 0;
            }
        }

        #endregion

        private void cmbServiceID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
