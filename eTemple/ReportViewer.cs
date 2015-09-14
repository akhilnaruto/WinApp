using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTemple.UI
{
    public partial class ReportViewer : Form
    {
        public string HeaderContent { get; set; }

        public string FooterContent { get; set; }

        public List<string> HeaderRows = new List<string>();

        public List<string> ContentRows = new List<string>();

        public List<string> FooterRows = new List<string>();

        public int HeaderWidthPercent = 100;
        public int ContentWidthPercent = 100;
        public int FooterWidthPercent = 100;

        public int RowsPerPage = 30;

        public void GenerateFromGridView(DataGridView contentGrid, bool isLastRowFooter)
        {
            this.HeaderRows.Add(GetTableStartHtml());
            this.HeaderRows.Add(GetTableHeaderRowHtml(contentGrid));

            for (int i = 0; i < contentGrid.Rows.Count; i++)
            {
                if (isLastRowFooter && i == (contentGrid.Rows.Count - 1))
                {
                    this.ContentRows.Add(GetTableContentRowHtml(contentGrid.Rows[i], true));
                }
                else
                {
                    this.ContentRows.Add(GetTableContentRowHtml(contentGrid.Rows[i], false));
                }
            }

            this.FooterRows.Add(GetTableEndHtml());
        }

        private string GetTableStartHtml()
        {
            return "\t<table cellspacing='0' cellpadding='4' width='100%'>";
        }

        private string GetTableEndHtml()
        {
            return "\t</table>";
        }

        private string GetTableHeaderRowHtml(DataGridView contentGrid)
        {
            var sb = new StringBuilder();
            sb.AppendLine("\t\t<tr>");
            foreach (DataGridViewColumn col in contentGrid.Columns)
            {
                if (col.Visible)
                {
                    sb.AppendFormat("\t\t\t<th>{0}</th>{1}", col.HeaderText, Environment.NewLine);
                }
            }
            sb.AppendLine("\t\t</tr>");

            return sb.ToString();
        }

        private string GetTableContentRowHtml(DataGridViewRow row, bool useTh)
        {
            var sb = new StringBuilder();
            sb.AppendLine("\t\t<tr>");
            foreach (DataGridViewColumn col in row.DataGridView.Columns)
            {
                if (col.Visible)
                {
                    sb.AppendFormat("\t\t\t<{0} align='{1}'>{2}</{0}>{3}", 
                        (useTh)? "th" : "td", GetCellAlignment(col), row.Cells[col.Index].FormattedValue, Environment.NewLine);
                }
            }
            sb.AppendLine("\t\t</tr>");

            return sb.ToString();
        }

        private string GetCellAlignment(DataGridViewColumn col)
        {
            if (col.DefaultCellStyle != null)
            {
                var colAlignment = col.DefaultCellStyle.Alignment;
                if (colAlignment == DataGridViewContentAlignment.TopRight
                    || colAlignment == DataGridViewContentAlignment.MiddleRight
                    || colAlignment == DataGridViewContentAlignment.BottomRight)
                {
                    return "right";
                }
                else if (colAlignment == DataGridViewContentAlignment.TopCenter
                    || colAlignment == DataGridViewContentAlignment.MiddleCenter
                    || colAlignment == DataGridViewContentAlignment.BottomCenter)
                {
                    return "center";
                }
            }

            return "left";
        }

        private string GetPageBreakHtml()
        {
            return @"<div class='page'></div>";
        }

        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            var html = GetReportHtml();
            this.webBrowser.DocumentText = html;
        }

        private string GetReportHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(this.documentBeginHtmlTemplate, this.HeaderWidthPercent, 
                this.ContentWidthPercent, this.FooterWidthPercent, this.HeaderContent));

            sb.Append(string.Join(Environment.NewLine, this.HeaderRows));

            for (int i = 0; i < this.ContentRows.Count; i++)
            {
                if (this.RowsPerPage > 0 && (i % this.RowsPerPage == 0) && i > 0)
                {
                    sb.Append(string.Join(Environment.NewLine, this.FooterRows));
                    sb.Append(GetPageBreakHtml());
                    sb.Append(string.Join(Environment.NewLine, this.HeaderRows));
                }

                sb.Append(this.ContentRows[i]);
            }

            sb.Append(string.Join(Environment.NewLine, this.FooterRows));

            sb.Append(string.Format(documentEndHtmlTemplate, this.FooterContent));


            return sb.ToString();

        }


        private string documentBeginHtmlTemplate = @"
<html>
<head>
    <style>
    table,th,td
    {{
        border:1px solid gray;
    }}
    
    .page
    {{
        page-break-after: always;
        page-break-inside: avoid;
    }}
    
    .header
    {{
        margin-left:auto;
        margin-right:auto;
        width:{0}%;
    }}

    .content
    {{
        margin-left:auto;
        margin-right:auto;
        width:{1}%;
    }}

    .footer
    {{
        margin-left:auto;
        margin-right:auto;
        width:{2}%;
    }}
    </style>
</head>
<body onload='print();'>
    <div class='header'>
    {3}
    </div>
    <div class='content'>";
        
        private string documentEndHtmlTemplate = @"
    </div>
    <div class='footer'>
    {0}
    </div>
</body>
</html>";
    }
}
