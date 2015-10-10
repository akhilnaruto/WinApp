using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTemple.Data.Models;

namespace eTemple.Data.Utilities
{
    public class PrintHelper
    {
        #region Printing Related

        public void PrintTokens(List<TokenPrint> tokens, Form parentDialog, string PrinterName, bool showPrintPreview)
        {
            _tokensToPrint = tokens;
            _pageCounter = 0;
            //bool showPrintPreview = true;
            PrintDocument pd = new PrintDocument();
            PrintDocument pd1 = new PrintDocument();


            pd.DefaultPageSettings.PaperSize = paperSize;
            pd.PrintPage += printDoc_PrintPage;
            pd.PrinterSettings.PrinterName = PrinterName;

            //ToDo: can remove preview in the actual production.
            if (showPrintPreview)
            {
                var ppDlg = new PrintPreviewDialog();
                ppDlg.SetBounds(30, 30, 1024, 500);
                ppDlg.PrintPreviewControl.AutoZoom = true;
                ppDlg.PrintPreviewControl.Zoom = 0.75;
                ppDlg.Document = pd;
                var dr = ppDlg.ShowDialog(parentDialog);
            }
            else
            {
                pd.Print();
            }
        }


        private string RenderToken(TokenPrint token)
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
            DailyNum = string.Format("{0}", token.Id).PadRight(_lineWidth / 2);
            CDate = string.Format("Date : {0:dd/MM/yyyy h:mm tt}  ", System.DateTime.Now).PadRight(_lineWidth / 2);
            line = DailyNum;
            if (token.Id != string.Empty && token.Id != "")
            {
                sb.AppendLine(line);
            }
            line = string.Empty;
            line = CDate;
            sb.AppendLine(line);
            line = string.Empty;

            purpose = string.Format(token.ServiceType).PadLeft(20);

            // PerformDate = string.Format("Perform Date : {0:dd/MM/yyyy}", token.DonatedDate).PadLeft(_lineWidth / 2);


            //line = string.Format("{0}", token.Name).PadRight(60);
            if (purpose != "")
            {
                line = line + purpose;
            }
            sb.AppendLine(line);


            if (token.VillageName != "")
            {
                line = string.Format("City : {0}", token.VillageName).PadRight(_lineWidth / 2);
            }

            line = string.Format("Gotram : {0}", token.Gothram).PadRight(_lineWidth / 2);


            if (PerformDate != "")
            {
                line = line + PerformDate;
            }
            sb.AppendLine(line);
            line = "";


            // int totalCost = 116;
            line = line + string.Format("Amt : {0:F}  ", token.Cost).PadLeft(_lineWidth);

            sb.AppendLine(line);
            sb.AppendLine();
            sb.AppendLine();

            return sb.ToString();
        }

        int _pageCounter;
        List<TokenPrint> _tokensToPrint;
        private const int _lineWidth = 90;
        private string _rulerLine = string.Empty.PadLeft(_lineWidth, '-');
        PaperSize paperSize = new PaperSize("Custom Receipt", 600, 300);
        PaperSize paperSize1 = new PaperSize("Custom Receipt", 300, 500);

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Arial", 10, System.Drawing.FontStyle.Regular);

            if (_pageCounter < _tokensToPrint.Count)
            {
                e.Graphics.DrawString(RenderToken(_tokensToPrint[_pageCounter]), printFont, System.Drawing.Brushes.Black, 0, 0);

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
    }
}
