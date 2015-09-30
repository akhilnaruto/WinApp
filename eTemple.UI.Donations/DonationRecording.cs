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
    public partial class DonationRecording : Form
    {
        public DonationRecording()
        {
            InitializeComponent();
        }

        private void DonationRecording_Load(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masterReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonationInformation oDonationInfo = new DonationInformation();
            oDonationInfo.Show();
        }

        private void eitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DCRReportForm oDCRReportForm = new DCRReportForm();
            oDCRReportForm.Show();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorMasterReportUI oDonorReprt = new DonorMasterReportUI();
            oDonorReprt.Show();
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnquiryDetailsUI oEnquiryDet = new EnquiryDetailsUI();
            oEnquiryDet.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
