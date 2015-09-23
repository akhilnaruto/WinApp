﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace eTemple.UI.Donations
{
    public partial class AddressForm : Form
    {
        public DataTable DonorRecs = null;
        public AddressForm(DataTable oDonorRecs)
        {
            InitializeComponent();
            DonorRecs = oDonorRecs;
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DonorAddresses", DonorRecs);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
