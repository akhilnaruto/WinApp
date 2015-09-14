using eTemple.Data;
using eTemple.Data.Models;
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

namespace eTemple.UI
{
    public partial class ReceiptsForm : Form
    {
        private int sId { get; set; }
        private String sName { get; set; }
        private int sType { get; set; }
        private double sCost { get; set; }
        private int dPhone { get; set; }
        private int dId { get; set; }
        private String clickedButtonName { get; set; }
        private Color defaultColorForButton { get; set; }

        BindingList<Devotee> _selectedDevotees = new BindingList<Devotee>();
        List<Prefix> _prefixes = new List<Prefix>();
        BindingList<Devotee> _possibleDevotees = new BindingList<Devotee>();
        BindingList<Devotee> _copiedDevotees = new BindingList<Devotee>();
        // AutoCompleteStringCollection autoComplete { get; set; }

        //private Timer t2 = new Timer();
        
        public ReceiptsForm()
        {
            InitializeComponent();
        }

        private void QtyLimit(int limit)
        {
            cmbQty.Items.Clear();
            for (int i = 1; i <= limit; i++)
            {
                cmbQty.Items.Add(new { Text = i.ToString(), Value = i });
            }
        }

        private AutoCompleteStringCollection AutoCompleteLoad(String phno)
        {
            var DevoteesDAOObj = new DevoteesDao();
            var devoteesPhoneNumbers = DevoteesDAOObj.getPhoneNumbers(phno);
            AutoCompleteStringCollection str = new AutoCompleteStringCollection();
            foreach(Devotee devoteePhno in devoteesPhoneNumbers)
            {
                str.Add(devoteePhno.ToString());
            }
            return str;
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            var stockDetailsDAO = new StockDetailsDao();
            dgvPrasadamStatus.AutoGenerateColumns = false;
            dgvPrasadamStatus.DataSource = stockDetailsDAO.GetAllStockDetails();
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            var timingObj1 = new TimingDao();
            dgvTimings.AutoGenerateColumns = false;
            dgvTimings.DataSource = timingObj1.GetTodayTimingsWithTokens();
        }
        
        private void ReceiptsForm_Load(object sender, EventArgs e)
        {
            Timer t1 = new Timer();
            t1.Interval = 100;
            t1.Tick += new EventHandler(t1_Tick);
            t1.Start();

            cmbTransactionType.DataSource = new TransactionTypeDao().GetAllTransactionTypes();
            //dgvPrasadamStatus.Hide();

            QtyLimit(100);

            cmbQty.DisplayMember = "Text";
            cmbQty.ValueMember = "Value";

            txtStateName.Text = "Andhra Pradesh";

            InitializeDevoteesGrid();
            load_menu();

            tblPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            tblPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            tblPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            tblPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            tblPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            tblPanel6.Dock = System.Windows.Forms.DockStyle.Left;

            defaultColorForButton = btnSubmit.BackColor;

            txtPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //txtPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;

            /*
            AutoCompleteLoad();
            txtPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPhoneNumber.AutoCompleteCustomSource = autoComplete;
            txtPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            */

            //t2.Interval = 5000;
            //t2.Tick += new EventHandler(t2_Tick);
        }

        private void load_menu()
        {
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel11.Hide();
            cmbTimeId.Hide();

            //var timingObj = new TimingDao();
            //cmbTimeId.DataSource = timingObj.GetAllTimings();

            var all_poojas = new ServiceDao();
            var poojas_list = all_poojas.GetAllPoojasExceptMiscIncomeHundials();
            int button_position = 0;
            if (cmbQty.Text == "")
            {
                cmbQty.Text = "1";
            }
            else
            {
                cmbQty.Text = cmbQty.Text;
            }
            devoteeAdd(Convert.ToInt32(cmbQty.Text));

            //dgvPrasadamStatus.Show();

            foreach (var pooja_details in poojas_list)
            {
                //System.Windows.Forms.ToolTip pooja_tooptip = new System.Windows.Forms.ToolTip();
                var pooja_tooptip = new ToolTip();
                var pooja_button = new Button();
                pooja_button.Text = pooja_details.Id.ToString();
                pooja_button.Name = "btnPooja" + pooja_details.Id;
                pooja_tooptip.SetToolTip(pooja_button, pooja_details.Name);
                
                
                
                pooja_button.Width = 46;
                pooja_button.Height = 46;
                pooja_button.Font = new Font("Segoe UI", 15.5F, FontStyle.Bold);

                if (pooja_details.Type == 2 || pooja_details.Type == 11 || pooja_details.Type == 15)
                {
                    pooja_button.Click += (sender, e) => { PrasadamReceipt(sender, e, pooja_details.Id, pooja_details.Name, pooja_details.Type, pooja_details.Cost); };
                }
                else if (pooja_details.Type == 9)
                {
                    pooja_button.Click += (sender, e) => { FreeAnnadanamReceipt(sender, e, pooja_details.Id, pooja_details.Name, pooja_details.Type, pooja_details.Cost); };
                }
                else if (pooja_details.Type == 1 || pooja_details.Type == 3 || pooja_details.Type == 4 || pooja_details.Type == 10)
                {
                    pooja_button.Click += (sender, e) => { DailyPoojaReceipt(sender, e, pooja_details.Id, pooja_details.Name, pooja_details.Type, pooja_details.Cost); };
                }
                else if (pooja_details.Type == 5 || pooja_details.Type == 6 || pooja_details.Type == 7 || pooja_details.Type == 8 || pooja_details.Type == 12)
                {
                    pooja_button.Click += (sender, e) => { SpecialPoojaReceipt(sender, e, pooja_details.Id, pooja_details.Name, pooja_details.Type, pooja_details.Cost); };
                }
                pooja_button.Left = (button_position + 0) * (pooja_button.Width + 2);
                this.panel1.Controls.Add(pooja_button);
                button_position++;
            }
        }

        private void DailyPoojaReceipt(object sender, EventArgs e, int pId, string pName, int pType, double pCost)
        {
            clickedButtonName = ((Button)sender).Name;
            FocusOnBtn(clickedButtonName, 0);
            sId = pId;
            sName = pName;
            sType = pType;
            sCost = pCost;
            panel3.Show();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            if (pId == 11)
            {
                panel7.Show();
            }
            else
            {
                panel7.Hide();
            }
            panel8.Show();
            panel11.Hide();
            //cmbTimeId.Hide();
            txtServiceName.Text = sName;
            //t2.Stop();

            double tAmt = 0;
            if (sCost != 0)
            {
                if (sType == 10)
                {
                    txtTotalAmount.Text = sCost.ToString();
                }
                else
                {
                    tAmt = sCost * Convert.ToDouble(cmbQty.Text);
                }
            }
            txtTotalAmount.Text = tAmt.ToString();
            
            if (sCost == 0)
            {
                txtTotalAmount.Enabled = true;
            }
            else
            {
                txtTotalAmount.Enabled = false;
            }
            txtPhoneNumber.Focus();
            //dgvPrasadamStatus.Hide();
        }

        private void SpecialPoojaReceipt(object sender, EventArgs e, int pId, string pName, int pType, double pCost)
        {
            clickedButtonName = ((Button)sender).Name;
            FocusOnBtn(clickedButtonName, 0);
            sId = pId;
            sName = pName;
            sType = pType;
            sCost = pCost;
            panel3.Show();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            panel7.Show();
            panel8.Show();
            panel11.Hide();
            //cmbTimeId.Hide();
            txtServiceName.Text = sName;
            
            //t2.Stop();

            double tAmt = 0;
            if (sCost != 0)
            {
                if (sType == 10)
                {
                    txtTotalAmount.Text = sCost.ToString();
                }
                else
                {
                    tAmt = sCost * Convert.ToDouble(cmbQty.Text);
                }
            }
            txtTotalAmount.Text = tAmt.ToString();


            if (sCost == 0)
            {
                txtTotalAmount.Enabled = true;
            }
            else
            {
                txtTotalAmount.Enabled = false;
            }
            txtPhoneNumber.Focus();
            //dgvPrasadamStatus.Hide();
        }

        private void PrasadamReceipt(object sender, EventArgs e, int pId, string pName, int pType, double pCost)
        {
            clickedButtonName = ((Button)sender).Name;
            FocusOnBtn(clickedButtonName, 0);
            sId = pId;
            sName = pName;
            sType = pType;
            sCost = pCost;
            panel3.Show();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            panel7.Hide();
            panel8.Show();
            panel11.Hide();
            //cmbTimeId.Hide();
            txtServiceName.Text = sName;

            //t2.Stop();

            double tAmt = 0;
            if (sCost != 0)
            {
                if (sType == 10)
                {
                    txtTotalAmount.Text = sCost.ToString();
                }
                else
                {
                    tAmt = sCost * Convert.ToDouble(cmbQty.Text);
                }
            }
            txtTotalAmount.Text = tAmt.ToString();


            if (sCost == 0)
            {
                txtTotalAmount.Enabled = true;
            }
            else
            {
                txtTotalAmount.Enabled = false;
            }
            //QtyLimit(100);
            txtPhoneNumber.Focus();
            //dgvPrasadamStatus.Show();
        }

        private void FreeAnnadanamReceipt(object sender, EventArgs e, int pId, string pName, int pType, double pCost)
        {
            clickedButtonName = ((Button)sender).Name;
            FocusOnBtn(clickedButtonName, 0);
            sId = pId;
            sName = pName;
            sType = pType;
            sCost = pCost;
            panel3.Show();
            panel4.Hide();
            panel5.Show();
            panel6.Show();
            panel7.Hide();
            panel8.Show();
            panel11.Show();
            cmbTimeId.Show();
            txtServiceName.Text = sName;

            var timingObj = new TimingDao();
            dgvTimings.AutoGenerateColumns = false;
            dgvTimings.DataSource = timingObj.GetTodayTimingsWithTokens();
            /*
            t2.Start();
            */

            // var timingObj = new TimingDao();
            cmbTimeId.DataSource = timingObj.GetAllTimings();

            
            txtTotalAmount.Text = sCost.ToString();
            if (sCost == 0)
            {
                txtTotalAmount.Enabled = true;
            }
            else
            {
                txtTotalAmount.Enabled = false;
            }
            txtPhoneNumber.Focus();
            //dgvPrasadamStatus.Hide();
        }

        private void InitializeDevoteesGrid()
        {
            dgvDevotees.AutoGenerateColumns = false;
            dgvDevotees.DataSource = _selectedDevotees;

            var prefixCol = dgvDevotees.Columns[1] as DataGridViewComboBoxColumn;
            if (prefixCol != null && prefixCol.DataSource == null)
            {
                prefixCol.DisplayMember = "Name";
                prefixCol.ValueMember = "Id";
                prefixCol.DataSource = new DevoteesDao().GetAllPrefixes();
            }
        }

        private void devoteeAdd(int cmdqty)
        {
            if (sType != 2 && sType != 11 && sType != 15)
            {
                int i;
                //dgvDevotees.DataSource = null;
                //_selectedDevotees.Clear();
                _copiedDevotees = _selectedDevotees;
                _selectedDevotees.Clear();
                for (i = 0; i < cmdqty; i++)
                {
                    /*
                    if (_copiedDevotees.Count > 0)
                    {
                        _selectedDevotees.Add(_copiedDevotees[i]);
                    }
                    else
                    */
                    {
                        var newDevotee = new Devotee();
                        newDevotee.Prefix = 1;
                        newDevotee.Id = 0;
                        newDevotee.DevoteeName = string.Empty;
                        newDevotee.Gothram = string.Empty;
                        _selectedDevotees.Add(newDevotee);
                    }
                }
            }
            else
            {
                _copiedDevotees = _selectedDevotees;
                _selectedDevotees.Clear();
                var newDevotee = new Devotee();
                newDevotee.Prefix = 1;
                newDevotee.Id = 0;
                newDevotee.DevoteeName = string.Empty;
                newDevotee.Gothram = string.Empty;
                _selectedDevotees.Add(newDevotee);
            }
        }

        private void cmbQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sCost != 0)
            {
                if (sType == 10)
                {
                    txtTotalAmount.Text = sCost.ToString();
                }
                else
                {
                    double tAmt = sCost * Convert.ToDouble(cmbQty.Text);
                    txtTotalAmount.Text = tAmt.ToString();
                }
            }
            devoteeAdd(Convert.ToInt32(cmbQty.Text));
        }

        private void LoadDevotees(string phoneNumber)
        {
            _possibleDevotees.Clear();
            if (!string.IsNullOrWhiteSpace(phoneNumber))
            {
                var devotees = new DevoteesDao().FindDevoteesByPhone(phoneNumber);
                foreach (var d in devotees)
                {
                    _possibleDevotees.Add(d);
                }
                if (_possibleDevotees.Count > 0)
                {
                    var firstDevotee = _possibleDevotees[0];
                    txtDoorNumber.Text = firstDevotee.DoorNumber;
                    txtAreaName.Text = firstDevotee.AreaName;
                    txtCity.Text = firstDevotee.City;
                    txtMandalName.Text = firstDevotee.MandalName;
                    txtDistrictName.Text = firstDevotee.DistrictName;
                    txtStateName.Text = firstDevotee.StateName;
                }
            }

            //ToDo: Also add if there are any entered devotees in the devotees table.
        }

        private void txtPhoneNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPhoneNumber.Text.Length >= 4)
            {
                // AutoCompleteLoad();
                // txtPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPhoneNumber.AutoCompleteCustomSource = AutoCompleteLoad(txtPhoneNumber.Text);
                txtPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            
            if (e.KeyCode == Keys.Enter)
            {
                LoadDevotees(txtPhoneNumber.Text);
                e.Handled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                txtPhoneNumber.Focus();
            }
            else
            {
                LoadDevotees(txtPhoneNumber.Text);
            }
        }

        private void dgvDevotees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var devoteeName = Convert.ToString(dgvDevotees.Rows[e.RowIndex].Cells[2].Value);
                if (!_possibleDevotees.Any(d => string.Equals(d.DevoteeName, devoteeName, StringComparison.OrdinalIgnoreCase)))
                {
                    _possibleDevotees.Add(new Devotee { DevoteeName = devoteeName });
                }
            }
            else if (e.ColumnIndex == 3)
            {
                var devoteeName = Convert.ToString(dgvDevotees.Rows[e.RowIndex].Cells[2].Value);
                var gothram = Convert.ToString(dgvDevotees.Rows[e.RowIndex].Cells[3].Value);
                var possibleDevotee = _possibleDevotees.FirstOrDefault(d => string.Equals(d.DevoteeName, devoteeName, StringComparison.OrdinalIgnoreCase));
                if (possibleDevotee != null)
                {
                    possibleDevotee.Gothram = gothram;
                }
            }
        }

        private void dgvDevotees_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            /*
            var devoteeRow = dgvDevotees.Rows[e.RowIndex];
            var devotee = devoteeRow.DataBoundItem as Devotee;
            if (devotee != null && !string.IsNullOrWhiteSpace(devotee.DevoteeName) )
            {
                devotee.PhoneNumber = txtPhoneNumber.Text;
                devotee.DoorNumber = txtDoorNumber.Text;
                devotee.AreaName = txtAreaName.Text;
                devotee.City = txtCity.Text;
                devotee.MandalName = txtMandalName.Text;
                devotee.DistrictName = txtDistrictName.Text;
                devotee.StateName = txtStateName.Text;
                new DevoteesDao().Save(devotee);

                var pd = _possibleDevotees.FirstOrDefault(d => (d.Id == devotee.Id || string.Equals(d.DevoteeName, devotee.DevoteeName, StringComparison.OrdinalIgnoreCase)));
                if (pd != null)
                {
                    pd.Id = devotee.Id;
                    pd.PhoneNumber = devotee.PhoneNumber;
                    pd.DoorNumber = devotee.DoorNumber;
                    pd.EmailId = devotee.EmailId;
                    pd.AreaName = devotee.AreaName;
                    pd.City = devotee.City;
                    pd.MandalName = devotee.MandalName;
                    pd.DistrictName = devotee.DistrictName;
                    pd.StateName = devotee.StateName;
                    var prefix = _prefixes.FirstOrDefault(p => p.Id == devotee.Id);
                    pd.PrefixName = (prefix == null) ? string.Empty : prefix.Name;
                }
            }
            */
        }

        private void dgvDevotees_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var txtEdit = e.Control as DataGridViewTextBoxEditingControl;
            if (txtEdit != null && txtEdit.EditingControlDataGridView.CurrentCell.ColumnIndex == 2)
            {
                txtEdit.ContextMenu = GetPossibleDevoteesMenu();
            }
            else if (txtEdit != null && txtEdit.EditingControlDataGridView.CurrentCell.ColumnIndex == 3)
            {
                txtEdit.ContextMenu = GetPossibleDevoteeGotramsMenu();
            }
        }

        private ContextMenu GetPossibleDevoteesMenu()
        {
            if (_possibleDevotees != null && _possibleDevotees.Count > 0)
            {
                var menu = new ContextMenu();

                for (int i = 0; i < _possibleDevotees.Count; i++)
                {
                    var d = _possibleDevotees[i];

                    var mi = new MenuItem { Text = string.Format("{0} : {1}", i + 1, d.DevoteeName), Tag = d.DevoteeName };

                    mi.Click += possibleDevotee_Click;

                    menu.MenuItems.Add(mi);
                }
                return menu;
            }
            else
                return null;
        }

        private ContextMenu GetPossibleDevoteeGotramsMenu()
        {
            if (_possibleDevotees != null && _possibleDevotees.Count > 0)
            {
                var gothrams = _possibleDevotees.Select(x => x.Gothram).Distinct().ToList();
                var menu = new ContextMenu();

                if (gothrams != null && gothrams.Count > 0)
                {
                    for (int i = 0; i < gothrams.Count; i++)
                    {
                        var mi = new MenuItem { Text = string.Format("{0} : {1}", i + 1, gothrams[i]), Tag = gothrams[i] };

                        mi.Click += possibleDevoteeGothram_Click;

                        menu.MenuItems.Add(mi);
                    }
                    return menu;
                }
            }

            return null;
        }

        void possibleDevotee_Click(object sender, EventArgs e)
        {
            var selectedMenuItem = sender as MenuItem;
            var selectedDevotee = _possibleDevotees.FirstOrDefault(x => string.Equals(x.DevoteeName, selectedMenuItem.Tag));

            var gridCellTextBox = selectedMenuItem.GetContextMenu().SourceControl as DataGridViewTextBoxEditingControl;
            if (gridCellTextBox != null)
            {
                gridCellTextBox.Text = selectedDevotee.DevoteeName;
                var devoteeRow = gridCellTextBox.EditingControlDataGridView.CurrentRow;
                devoteeRow.Cells[0].Value = selectedDevotee.Id;
                devoteeRow.Cells[3].Value = selectedDevotee.Gothram;
            }
        }

        void possibleDevoteeGothram_Click(object sender, EventArgs e)
        {
            var selectedMenuItem = sender as MenuItem;
            var gridCellTextBox = selectedMenuItem.GetContextMenu().SourceControl as DataGridViewTextBoxEditingControl;

            if (gridCellTextBox != null)
            {
                gridCellTextBox.Text = Convert.ToString(selectedMenuItem.Tag);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStateName.Text = "Andhra Pradesh";
            txtPhoneNumber.Text = null;
            txtMandalName.Text = null;
            txtDoorNumber.Text = null;
            txtDistrictName.Text = null;
            txtCity.Text = null;
            txtAreaName.Text = null;

            txtTotalAmount.Text = sCost.ToString();
            txtServiceName.Text = sName;

            cmbQty.Text = "1";
            dtpPerformDate.Text = DateTime.Now.ToString();
            _selectedDevotees.Clear();
            _possibleDevotees.Clear();
            _copiedDevotees.Clear();
            InitializeDevoteesGrid();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int devoteeRows = Convert.ToInt32(cmbQty.Text);
            //MessageBox.Show(devoteeRows.ToString());
            if (sType == 2 || sType == 11 || sType == 15)
            {
                //get Devotees and store. Store Single Token.
                var savedTokens = new List<Token>();
                long tokenId = 0;
                //get Devotees and store. Store Multiple Tokens and print MUltiple Tokens.
                int serviceId = 0;
                if (sId == 0)
                {
                    serviceId = sId;
                }
                var tokenDAO = new TokenDao();
                int devoteeId = 0;
                int prefixID = 1;
                String devoteeName = "";
                String devoteeGothram = "";
                String devoteeAdditionalNames = "";
                String devoteeAdditionalGothrams = "";

                if (cmbTransactionType.Text != "Cash" && txtTransactionID.Text == "")
                {
                    MessageBox.Show("Please enter Transaction ID of your Transaction");
                    goto Exitlabel;
                }
                for (int i = 0; i < 1; i++)
                {
                    if (i == 0)
                    {
                        prefixID = Convert.ToInt32(dgvDevotees.Rows[i].Cells[1].Value.ToString());
                        devoteeId = Convert.ToInt32(dgvDevotees.Rows[i].Cells[0].Value.ToString());
                        devoteeName = dgvDevotees.Rows[i].Cells[2].Value.ToString();
                        devoteeGothram = dgvDevotees.Rows[i].Cells[3].Value.ToString();
                    }
                    else
                    {
                        devoteeAdditionalNames = devoteeAdditionalNames + "," + dgvDevotees.Rows[i].Cells[2].Value.ToString();
                        devoteeAdditionalGothrams = devoteeAdditionalGothrams + "," + dgvDevotees.Rows[i].Cells[3].Value.ToString();
                    }
                }

                if (devoteeId == 0)
                {
                    var devoteeObj = new Devotee
                    {
                        DevoteeName = devoteeName,
                        Prefix = prefixID,
                        Gothram = devoteeGothram,
                        DoorNumber = txtDoorNumber.Text,
                        AreaName = txtAreaName.Text,
                        City = txtCity.Text,
                        MandalName = txtMandalName.Text,
                        DistrictName = txtDistrictName.Text,
                        StateName = txtStateName.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        AdditionalNames = devoteeAdditionalNames,
                        AdditionalGothrams = devoteeAdditionalGothrams,
                        OtherDetails = txtOtherDetails.Text
                    };
                    var devoteeDao = new DevoteesDao();
                    devoteeId = devoteeDao.Save(devoteeObj);
                    // MessageBox.Show(devoteeId.ToString());
                }

                long sdailyNumber = tokenDAO.getHighestDailyNumber(sId) + 1;
                long dailyNumber = tokenDAO.getMaxDailyNumber(DateTime.Now) + 1;
                
                var tokenObj = new Token
                {
                    ServiceId = sId,
                    DevoteeId = devoteeId,
                    Quantity = Convert.ToInt32(cmbQty.Text),
                    TotalCost = Convert.ToDouble(txtTotalAmount.Text),
                    ServicePerformDate = Convert.ToDateTime(dtpPerformDate.Value),
                    Status = 1,
                    ServiceDailyNumber = sdailyNumber,
                    DailyNumber = dailyNumber,
                    CreatedOn = DateTime.Now,
                    CreatedBy = App.LoggedInEmployee.Id,
                    TransactionType = cmbTransactionType.Text,
                    TransactionID = txtTransactionID.Text,
                    TransactionDate = Convert.ToDateTime(dtpDDChecqueDate.Value)
                };
                tokenId = tokenDAO.SaveToken(tokenObj);
                // MessageBox.Show(tokenId.ToString());

                tokenObj = tokenDAO.getTokenById(tokenId);
                savedTokens.Add(tokenObj);

                if (sType == 2)
                {
                    var sdDao = new StockDetailsDao();
                    int stockVal = Convert.ToInt32(cmbQty.Text);
                    // int CurrStock = sdDao.getStockByServiceId(sId);
                    // stockVal = stockVal - CurrStock;
                    sdDao.UpdateStockDetail(stockVal, sId);
                }

                PrintTokens(savedTokens);
                Exitlabel:
                {
                }
            }
            else if (sType == 9)
            {
                //get Devotees and store. Store Single Token.
                var savedTokens = new List<Token>();
                long tokenId = 0;
                //get Devotees and store. Store Multiple Tokens and print MUltiple Tokens.
                int serviceId = 0;
                if (sId == 0)
                {
                    serviceId = sId;
                }
                /*
                if (cmbTimeId.Text == "" || cmbTimeId.Text == null)
                {
                    MessageBox.Show("Free Annadanam Timings completed for Today. Sorry for the Inconvenience.");
                    goto Exitlabel;
                }
                if (cmbTransactionType.Text != "Cash" && txtTransactionID.Text == "")
                {
                    MessageBox.Show("Please enter Transaction ID of your Transaction");
                    goto Exitlabel;
                }
                int timeIdValue = (cmbTimeId.SelectedItem as Timing).Id;
                */
                int timeIdValue = 1;
                //int TimeValId = 0;
                //String TimeValName = "";
                int TimeValCount = 0;
                //int dgvTimingsRows = App.DayMaxSlots;
                //for (int i = 0; i < dgvTimingsRows; i++)
                {
                    int i = timeIdValue - 1;
                    
                    String i2Val;
                    if (dgvTimings.Rows[i].Cells[2].Value.ToString() != null)
                    {
                        i2Val = Convert.ToString(dgvTimings.Rows[i].Cells[2].Value.ToString());
                    }
                    else
                    {
                        i2Val = "0";
                    }
                    
                    TimeValCount = Convert.ToInt32(i2Val);
                    /*
                    if ((Convert.ToInt32(cmbQty.Text) + TimeValCount) > App.SlotMaxVal)
                    {
                        MessageBox.Show("Slot is not Available for the specified Quantity. Please select another Slot.");
                        goto Exitlabel;
                    }
                    */
                }


                var tokenDAO = new TokenDao();
                int devoteeId = 0;
                int prefixID = 1;
                String devoteeName = "";
                String devoteeGothram = "";
                String devoteeAdditionalNames = "";
                String devoteeAdditionalGothrams = "";
                for (int i = 0; i < devoteeRows; i++)
                {
                    if (i == 0)
                    {
                        prefixID = Convert.ToInt32(dgvDevotees.Rows[i].Cells[1].Value.ToString());
                        devoteeId = Convert.ToInt32(dgvDevotees.Rows[i].Cells[0].Value.ToString());
                        devoteeName = Convert.ToString(dgvDevotees.Rows[i].Cells[2].Value.ToString());
                        devoteeGothram = Convert.ToString(dgvDevotees.Rows[i].Cells[3].Value.ToString());
                    }
                    else
                    {
                        devoteeAdditionalNames = Convert.ToString(devoteeAdditionalNames) + "," + Convert.ToString(dgvDevotees.Rows[i].Cells[2].Value.ToString());
                        devoteeAdditionalGothrams = Convert.ToString(devoteeAdditionalGothrams) + "," + Convert.ToString(dgvDevotees.Rows[i].Cells[3].Value.ToString());
                    }
                }

                if (prefixID <= 0)
                {
                    MessageBox.Show("Please Select Prefix", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (devoteeName == "")
                {
                    MessageBox.Show("Please Enter Devotee Name", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (devoteeId == 0)
                    {
                        var devoteeObj = new Devotee
                        {
                            DevoteeName = devoteeName,
                            Prefix = prefixID,
                            Gothram = devoteeGothram,
                            DoorNumber = txtDoorNumber.Text,
                            AreaName = txtAreaName.Text,
                            City = txtCity.Text,
                            MandalName = txtMandalName.Text,
                            DistrictName = txtDistrictName.Text,
                            StateName = txtStateName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            AdditionalNames = devoteeAdditionalNames,
                            AdditionalGothrams = devoteeAdditionalGothrams,
                            OtherDetails = txtOtherDetails.Text
                        };
                        var devoteeDao = new DevoteesDao();
                        devoteeId = devoteeDao.Save(devoteeObj);
                        // MessageBox.Show(devoteeId.ToString());
                    }

                    long sdailyNumber = tokenDAO.getHighestDailyNumber(sId) + 1;
                    long dailyNumber = tokenDAO.getMaxDailyNumber(DateTime.Now) + 1;
                    
                    var tokenObj = new Token
                    {
                        ServiceId = sId,
                        DevoteeId = devoteeId,
                        Quantity = Convert.ToInt32(cmbQty.Text),
                        TotalCost = 0,
                        ServicePerformDate = Convert.ToDateTime(dtpPerformDate.Value),
                        Status = 1,
                        ServiceDailyNumber = sdailyNumber,
                        DailyNumber = dailyNumber,
                        CreatedOn = DateTime.Now,
                        CreatedBy = App.LoggedInEmployee.Id,
                        TimeId = timeIdValue,
                        TransactionType = cmbTransactionType.Text
                    };
                    tokenId = tokenDAO.SaveToken(tokenObj);
                    // MessageBox.Show(tokenId.ToString());

                    tokenObj = tokenDAO.getTokenById(tokenId);
                    savedTokens.Add(tokenObj);

                    PrintTokens(savedTokens);
                }
                Exitlabel:
                {
                }
                //get Devotees and store. Store Multiple Tokens and print First Person name only.
            }
            else if (sType == 10)
            {
                //get Devotees and store in Additional Persons and Additional Gothrams. Store Single Token.
                var savedTokens = new List<Token>();
                long tokenId = 0;
                //get Devotees and store. Store Multiple Tokens and print MUltiple Tokens.
                int serviceId = 0;
                if (sId == 0)
                {
                    serviceId = sId;
                }
                var tokenDAO = new TokenDao();
                int devoteeId = 0;
                int prefixID = 1;
                String devoteeName = "";
                String devoteeGothram = "";
                String devoteeAdditionalNames = "";
                String devoteeAdditionalGothrams = "";
                for (int i = 0; i < devoteeRows; i++)
                {
                    if (i == 0)
                    {
                        prefixID = Convert.ToInt32(dgvDevotees.Rows[i].Cells[1].Value.ToString());
                        devoteeId = Convert.ToInt32(dgvDevotees.Rows[i].Cells[0].Value.ToString());
                        devoteeName = dgvDevotees.Rows[i].Cells[2].Value.ToString();
                        devoteeGothram = dgvDevotees.Rows[i].Cells[3].Value.ToString();
                    }
                    else
                    {
                        devoteeAdditionalNames = devoteeAdditionalNames + "," + dgvDevotees.Rows[i].Cells[2].Value.ToString();
                        devoteeAdditionalGothrams = devoteeAdditionalGothrams + "," + dgvDevotees.Rows[i].Cells[3].Value.ToString();
                    }
                }
                if (cmbTransactionType.Text != "Cash" && txtTransactionID.Text == "")
                {
                    MessageBox.Show("Please enter Transaction ID of your Transaction");
                    goto Exitlabel;
                }
                if (prefixID <= 0)
                {
                    MessageBox.Show("Please Select Prefix", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (devoteeName == "")
                {
                    MessageBox.Show("Please Enter Devotee Name", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (devoteeId == 0)
                    {
                        var devoteeObj = new Devotee
                        {
                            DevoteeName = devoteeName,
                            Prefix = prefixID,
                            Gothram = devoteeGothram,
                            DoorNumber = txtDoorNumber.Text,
                            AreaName = txtAreaName.Text,
                            City = txtCity.Text,
                            MandalName = txtMandalName.Text,
                            DistrictName = txtDistrictName.Text,
                            StateName = txtStateName.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            AdditionalNames = devoteeAdditionalNames,
                            AdditionalGothrams = devoteeAdditionalGothrams,
                            OtherDetails = txtOtherDetails.Text
                        };
                        var devoteeDao = new DevoteesDao();
                        devoteeId = devoteeDao.Save(devoteeObj);
                        // MessageBox.Show(devoteeId.ToString());
                    }

                    double scCost = 0;
                    if (sCost == 0)
                    {
                        scCost = Convert.ToDouble(txtTotalAmount.Text);
                    }
                    else
                    {
                        scCost = sCost;
                    }

                    long sdailyNumber = tokenDAO.getHighestDailyNumber(sId) + 1;
                    long dailyNumber = tokenDAO.getMaxDailyNumber(DateTime.Now) + 1;
                    var tokenObj = new Token
                    {
                        ServiceId = sId,
                        DevoteeId = devoteeId,
                        Quantity = Convert.ToInt32(cmbQty.Text),
                        TotalCost = scCost, //Convert.ToDouble(txtTotalAmount.Text) sCost
                        ServicePerformDate = Convert.ToDateTime(dtpPerformDate.Value),
                        Status = 1,
                        ServiceDailyNumber = sdailyNumber,
                        DailyNumber = dailyNumber,
                        CreatedOn = DateTime.Now,
                        CreatedBy = App.LoggedInEmployee.Id,
                        TransactionType = cmbTransactionType.Text
                    };
                    tokenId = tokenDAO.SaveToken(tokenObj);
                    // MessageBox.Show(tokenId.ToString());

                    tokenObj = tokenDAO.getTokenById(tokenId);
                    savedTokens.Add(tokenObj);

                    PrintTokens(savedTokens);
                }
                Exitlabel:
                {
                }
            }
            else if (sType == 1 || sType == 3 || sType == 4 || sType == 5 || sType == 6 || sType == 7 || sType == 8 || sType == 12)
            {
                {
                    var savedTokens = new List<Token>();
                    long tokenId = 0;
                    //get Devotees and store. Store Multiple Tokens and print MUltiple Tokens.
                    int serviceId = 0;
                    if (sId == 0)
                    {
                        serviceId = sId;
                    }
                    var tokenDAO = new TokenDao();
                    int devoteeId = 0;
                    int prefixID = 1;
                    String devoteeName = "";
                    String devoteeGothram = "";
                    if (cmbTransactionType.Text != "Cash" && txtTransactionID.Text == "")
                    {
                        MessageBox.Show("Please enter Transaction ID or DD/Cheque Number of your Transaction");
                        goto Exitlabel;
                    }
                    int dVal = 1;
                    if (sId != 1)
                    {
                        for (int i = 0; i < devoteeRows; i++)
                        {
                            devoteeId = 0;
                            devoteeId = Convert.ToInt32(dgvDevotees.Rows[i].Cells[0].Value.ToString());
                            devoteeName = dgvDevotees.Rows[i].Cells[2].Value.ToString();
                            devoteeGothram = dgvDevotees.Rows[i].Cells[3].Value.ToString();
                            prefixID = Convert.ToInt32(dgvDevotees.Rows[i].Cells[1].Value.ToString());
                            if (prefixID <= 0)
                            {
                                MessageBox.Show("Please Select Prefix", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dVal = 0;
                                dgvDevotees.Rows[i].Cells[1].Selected = true;
                                break;
                            }
                            else if (devoteeName == "")
                            {
                                MessageBox.Show("Please Enter Devotee Name", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dVal = 0;
                                dgvDevotees.Rows[i].Cells[2].Selected = true;
                                break;
                            }
                            else if (devoteeGothram == "")
                            {
                                MessageBox.Show("Please Enter Devotee Gothram", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dVal = 0;
                                dgvDevotees.Rows[i].Cells[3].Selected = true;
                                break;
                            }
                        }
                        if (sType == 4)
                        {

                            if (txtPhoneNumber.Text == "")
                            {
                                MessageBox.Show("Please Enter Phone Number", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dVal = 0;
                            }
                            else if (txtCity.Text == "")
                            {
                                MessageBox.Show("Please Enter City or Village", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dVal = 0;
                            }
                        }
                    }
                    else
                    {
                        dVal = 1;
                    }
                    
                    if (dVal == 1)
                    {
                        for (int i = 0; i < devoteeRows; i++)
                        {
                            devoteeId = 0;
                            devoteeId = Convert.ToInt32(dgvDevotees.Rows[i].Cells[0].Value.ToString());
                            devoteeName = dgvDevotees.Rows[i].Cells[2].Value.ToString();
                            devoteeGothram = dgvDevotees.Rows[i].Cells[3].Value.ToString();
                            prefixID = Convert.ToInt32(dgvDevotees.Rows[i].Cells[1].Value.ToString());

                            if (devoteeId == 0)
                            {
                                //prefixID = int.TryParse(dgvDevotees.Rows[i].Cells[1].Value.ToString(), out prefixId);
                                var devoteeObj = new Devotee
                                {
                                    DevoteeName = dgvDevotees.Rows[i].Cells[2].Value.ToString(),
                                    Prefix = prefixID,
                                    Gothram = dgvDevotees.Rows[i].Cells[3].Value.ToString(),
                                    DoorNumber = txtDoorNumber.Text,
                                    AreaName = txtAreaName.Text,
                                    City = txtCity.Text,
                                    MandalName = txtMandalName.Text,
                                    DistrictName = txtDistrictName.Text,
                                    StateName = txtStateName.Text,
                                    PhoneNumber = txtPhoneNumber.Text,
                                    OtherDetails = txtOtherDetails.Text
                                };
                                var devoteeDao = new DevoteesDao();
                                devoteeId = devoteeDao.Save(devoteeObj);
                                // MessageBox.Show(devoteeId.ToString());
                            }
                            

                            double scCost = 0;
                            if (sCost == 0)
                            {
                                scCost = Convert.ToDouble(txtTotalAmount.Text);
                            }
                            else
                            {
                                scCost = sCost;
                            }

                            long sdailyNumber = tokenDAO.getHighestDailyNumber(sId) + 1;
                            long dailyNumber = tokenDAO.getMaxDailyNumber(DateTime.Now) + 1;
                            var tokenObj = new Token
                            {
                                ServiceId = sId,
                                DevoteeId = devoteeId,
                                Quantity = 1,
                                TotalCost = scCost, //Convert.ToDouble(txtTotalAmount.Text) sCost
                                ServicePerformDate = Convert.ToDateTime(dtpPerformDate.Value),
                                Status = 1,
                                ServiceDailyNumber = sdailyNumber,
                                DailyNumber = dailyNumber,
                                CreatedOn = DateTime.Now,
                                CreatedBy = App.LoggedInEmployee.Id,
                                TransactionType = cmbTransactionType.Text
                            };
                            tokenId = tokenDAO.SaveToken(tokenObj);
                            // MessageBox.Show(tokenId.ToString());

                            tokenObj = tokenDAO.getTokenById(tokenId);
                            savedTokens.Add(tokenObj);

                        }
                        PrintTokens(savedTokens);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Devotee Details", "Error Occured !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                Exitlabel:
                {
                }
            }
            //(btnPooja + sId).Focus();
            FocusOnBtn(clickedButtonName, 1);
        }
        
        private void FocusOnBtn(String btnName, int focusValue)
        {
            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(Panel))
                {
                    var panel = control as Panel;
                    if (panel.Name == "panel1")
                    {
                        foreach (var pan in panel.Controls)
                        {
                            if (pan.GetType() == typeof(Button))
                            {
                                Button btn = pan as Button;
                                if (btn.Name == btnName)
                                {
                                    if(focusValue == 1)
                                    {
                                        btn.Focus();
                                    }
                                    btn.BackColor = Color.SkyBlue;
                                }
                                else
                                {
                                    btn.BackColor = defaultColorForButton;
                                }
                            }
                        }
                    }
                }

            }
            //btnName.Focus();
            //btnName.BackColor = Color.YellowGreen;
        }

        #region Printing Related

        private void PrintTokens(List<Token> tokens)
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


        private string RenderToken(Token token)
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
            if (token.ServiceTypeID!=2 && token.ServiceTypeID!=9)
            {
                PerformDate = string.Format("Perform Date : {0:dd/MM/yyyy}", token.ServicePerformDate).PadLeft(_lineWidth / 2);
            }
            /*
            if (token.DevoteeName != "")
            {
            */

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

        private string RenderToken_1(Token token)
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
            if (token.ServiceTypeID!=2 && token.ServiceTypeID!=9)
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

        public void printDoc_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Segoe UI", 13, System.Drawing.FontStyle.Bold);

            if (_pageCounter < _tokensToPrint.Count)
            {
                e.Graphics.DrawString(RenderToken_1(_tokensToPrint[_pageCounter]),
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTimings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblPName_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDoorNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransactionType.Text == "Cash")
            {
                lblTransactionID.Visible = false;
                txtTransactionID.Visible = false;
                lblDDdate.Visible = false;
                dtpDDChecqueDate.Visible = false;
            }
            else if (cmbTransactionType.Text == "Credit/Debit Card")
            {
                lblTransactionID.Text = "Transaction ID";
                lblTransactionID.Visible = true;
                txtTransactionID.Visible = true;
                lblDDdate.Visible = false;
                dtpDDChecqueDate.Visible = false;
            }
            else if (cmbTransactionType.Text == "DD")
            {
                lblTransactionID.Text = "Number && Bank";
                lblDDdate.Text = "Date";
                lblTransactionID.Visible = true;
                txtTransactionID.Visible = true;
                lblDDdate.Visible = true;
                dtpDDChecqueDate.Visible = true;
            }
            else if (cmbTransactionType.Text == "Cheque")
            {
                lblTransactionID.Text = "Number && Bank";
                lblDDdate.Text = "Date";
                lblTransactionID.Visible = true;
                txtTransactionID.Visible = true;
                lblDDdate.Visible = true;
                dtpDDChecqueDate.Visible = true;
            }
        }
    }
}
