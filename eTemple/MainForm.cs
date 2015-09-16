using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTemple.Data;
using eTemple.Data.Models;

namespace eTemple.UI
{
    public partial class MainForm : Form
    {
        Dictionary<string, Form> openedForms = new Dictionary<string, Form>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowChildForm(Form childForm, bool doNotIncludeInMainForm = false)
        {
            if (!doNotIncludeInMainForm)
            {
                childForm.MdiParent = this;
            }
            
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }


        private void LoadPrinters()
        {
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                cmbSlipPrinter.Items.Add(printerName);
                cmbTokenPrinter.Items.Add(printerName);
            }

            if (cmbTokenPrinter.Items.Count > 0)
            {
                cmbSlipPrinter.SelectedIndex = 0;
                cmbTokenPrinter.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No printers found on this machine. Please install printers for token and slip printing.", "No Printers found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetTokenPrinter()
        {
            return this.cmbTokenPrinter.SelectedItem as string;
        }

        public string GetSlipPrinter()
        {
            return this.cmbSlipPrinter.SelectedItem as string;
        }

        public bool IsPrintPreviewEnabled
        {
            get
            {
                return this.chkPrintPreview.Checked;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            /*
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                MessageBox.Show(printer);
            }
            */

            var result = new Login().ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                lblLoggedInUser.Text = string.Format("Logged in : {0}", App.LoggedInEmployee.Name);
                if (App.LoggedInEmployee.Role == 1)
                {
                    settingsToolStripMenuItem.Visible = true;
                    dCRToolStripMenuItem.Visible = true;
                    operatorReportToolStripMenuItem.Visible = true;
                }
                else
                {
                    settingsToolStripMenuItem.Visible = false;
                    dCRToolStripMenuItem.Visible = false;
                    operatorReportToolStripMenuItem.Visible = false;
                }


                LoadPrinters();
            }
            else
            {
                this.Close();
            }
        }

        

        private void designationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Designations());
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Employees(),true);
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Roles());
        }

        private void printSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new PrintSeriesForm());
        }

        private void poojaPrasadamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ServiceForm());
        }

        void unitsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowChildForm(new Units());
        }

        private void newTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new TokensForm());
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowChildForm(new ReceiptsForm());
        }

        private void pattiInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new PattiInForm());
        }

        private void pattiOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new PattiOutForm());
        }

        private void dCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new DCRForm());
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new GenerateBatchForm());
        }

        private void operatorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new OperatorReport());
        }

        private void printersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new PrintersForm());
        }

        private void receiptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ReceiptsForm());
        }

        private void hundialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new HundialsForm());
        }

        private void miscIncomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new MiscIncomeForm());
        }

        private void poojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new PoojaReport());
        }

        private void vIPPrasadamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new VIPPrasadamForm());
        }

        private void unitsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void serviceReportWithAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new PoojaAddressReport());
        }

        private void showMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new DemoMenu(),true);
        }

        private void pOCServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new POCMainForm(), true);
        }

        /// <summary>
        /// Open the Data Entry form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   ShowChildForm(new DataEntry(), true);
        }
    }
}
