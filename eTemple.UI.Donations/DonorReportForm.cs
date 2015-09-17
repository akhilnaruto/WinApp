using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eTemple.UI.Donations
{
    public partial class DonorReportForm : Form
    {
        public DonorReportForm()
        {
            InitializeComponent();
        }

        private void DonorReportForm_Load(object sender, EventArgs e)
        {
            r
            this.reportViewer1.RefreshReport();
        }
    }
}
