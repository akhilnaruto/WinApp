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
    public partial class TokensForm : Form
    {
        List<Service> _services;
        BindingList<Token> _selectedTokens = new BindingList<Token>();
        BindingList<Devotee> _selectedDevotees = new BindingList<Devotee>();
        List<Prefix> _prefixes = new List<Prefix>();
        BindingList<Devotee> _possibleDevotees = new BindingList<Devotee>();

        public TokensForm()
        {
            InitializeComponent();
        }

        private void TokensForm_Load(object sender, EventArgs e)
        {
            LoadServices();

            InitializeTokensGrid();

            InitializeDevoteesGrid();
        }


        private void InitializeTokensGrid()
        {
            gvTokens.AutoGenerateColumns = false;
            gvTokens.DataSource = _selectedTokens;
        }

        private void InitializeDevoteesGrid()
        {
            dgvDevotees.AutoGenerateColumns = false;
            dgvDevotees.DataSource = _selectedDevotees;

            var prefixCol = dgvDevotees.Columns[2] as DataGridViewComboBoxColumn;
            if (prefixCol != null && prefixCol.DataSource == null)
            {
                prefixCol.DisplayMember = "Name";
                prefixCol.ValueMember = "Id";
                prefixCol.DataSource = new DevoteesDao().GetAllPrefixes();
            }
        }

        private void LoadServices()
        {
            _services = new ServiceDao().GetAllServicesForSelection();
            cmbServices.DisplayMember = "DisplayName";
            cmbServices.ValueMember = "Id";
            cmbServices.DataSource = _services;
        }

        private void btnClearAndNew_Click(object sender, EventArgs e)
        {
            _selectedTokens.Clear();
            _selectedDevotees.Clear();
            _possibleDevotees.Clear();
        }


        private void cmbServices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedService = cmbServices.SelectedItem as Service;
            txtCost.Text = string.Format("{0:F}", selectedService.Cost);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            var selectedService = cmbServices.SelectedItem as Service;
            var token = new Token();
            token.ServiceId = selectedService.Id;
            token.ServiceName = selectedService.Name;
            token.Quantity = Convert.ToInt32(txtQuantity.Text);
            token.TotalCost = token.Quantity * Convert.ToDouble(txtCost.Text);
            token.CreatedBy = App.LoggedInEmployee.Id;
            token.CreatedOn = DateTime.Now;

            _selectedTokens.Add(token);
            mtxtServiceNumber.Clear();
            txtQuantity.Text = "1";
            mtxtServiceNumber.Focus();

            for (int i = 0; i < token.Quantity; i++)
            {
                var newDevotee = new Devotee();
                newDevotee.TokenIndex = _selectedDevotees.Count + 1;
                newDevotee.ServiceName = token.ServiceName;
                newDevotee.Prefix = 1;
                newDevotee.DevoteeName = string.Empty;
                newDevotee.Gothram = string.Empty;

                _selectedDevotees.Add(newDevotee);
            }
        }

        private void gvTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && e.ColumnIndex == Constants.GridColumnIndex_Tokens_Service
                && e.RowIndex >= 0)
            {
                //ToDo: also write code to remove the devotee rows from the left side grid.
                _selectedTokens.RemoveAt(e.RowIndex);
            }

        }

        private void gvTokens_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_selectedTokens != null && _selectedTokens.Count > 0)
            {
                int? totalQuantity = _selectedTokens.Sum(x => x.Quantity);
                double? totalCost = _selectedTokens.Sum(x => x.TotalCost);

                txtTotalCost.Text = string.Format("{0:F}", totalCost);
                txtTotalQuantity.Text = string.Format("{0}", totalQuantity);
            }
        }

        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedService = cmbServices.SelectedItem as Service;
            txtCost.Text = string.Format("{0:F}", selectedService.Cost);
        }

        private void mtxtServiceNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var svcNum = Convert.ToInt32(mtxtServiceNumber.Text);

                if (_services.Any(s => s.Id == svcNum))
                {
                    cmbServices.SelectedValue = svcNum;
                    txtQuantity.Focus();
                }
                else
                {
                    mtxtServiceNumber.SelectAll();
                }
            }
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            txtCost.Focus();
        }

        private void txtCost_KeyUp(object sender, KeyEventArgs e)
        {
            btnAddService.Focus();
        }

        private void txtPhoneNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDevotees(txtPhoneNumber.Text);
                e.Handled = true;
            }
        }

        private void btnFindDevotees_Click(object sender, EventArgs e)
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
                    txtDoorNo.Text = firstDevotee.DoorNumber;
                    txtEmail.Text = firstDevotee.EmailId;
                    txtArea.Text = firstDevotee.AreaName;
                    txtCity.Text = firstDevotee.City;
                    txtMandal.Text = firstDevotee.MandalName;
                    txtDistrict.Text = firstDevotee.DistrictName;
                    txtState.Text = firstDevotee.StateName;
                }
            }

            //ToDo: Also add if there are any entered devotees in the devotees table.
        }

        private void dgvDevotees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Constants.GridColumnIndex_Devotees_DevoteeName)
            {
                var devoteeName = Convert.ToString(dgvDevotees.Rows[e.RowIndex].Cells[Constants.GridColumnIndex_Devotees_DevoteeName].Value);
                if (!_possibleDevotees.Any(d => string.Equals(d.DevoteeName, devoteeName, StringComparison.OrdinalIgnoreCase)))
                {
                    _possibleDevotees.Add(new Devotee { DevoteeName = devoteeName });
                }
            }
            else if (e.ColumnIndex == Constants.GridColumnIndex_Devotees_Gothram)
            {
                var devoteeName = Convert.ToString(dgvDevotees.Rows[e.RowIndex].Cells[Constants.GridColumnIndex_Devotees_DevoteeName].Value);
                var gothram = Convert.ToString(dgvDevotees.Rows[e.RowIndex].Cells[Constants.GridColumnIndex_Devotees_Gothram].Value);
                var possibleDevotee = _possibleDevotees.FirstOrDefault(d => string.Equals(d.DevoteeName, devoteeName, StringComparison.OrdinalIgnoreCase));
                if (possibleDevotee != null)
                {
                    possibleDevotee.Gothram = gothram;
                }
            }
        }

        private void dgvDevotees_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var txtEdit = e.Control as DataGridViewTextBoxEditingControl;
            if (txtEdit != null && txtEdit.EditingControlDataGridView.CurrentCell.ColumnIndex == Constants.GridColumnIndex_Devotees_DevoteeName)
            {
                txtEdit.ContextMenu = GetPossibleDevoteesMenu();
            }
            else if (txtEdit != null && txtEdit.EditingControlDataGridView.CurrentCell.ColumnIndex == Constants.GridColumnIndex_Devotees_Gothram)
            {
                txtEdit.ContextMenu = GetPossibleDevoteeGotramsMenu();
            }
        }

        private void dgvDevotees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            App.LogError(string.Format("Data Error occurred in Token Form Devotees Details Grid. Error Details :{0}", e.Exception));
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
                devoteeRow.Cells[Constants.GridColumnIndex_Devotees_DevoteeId].Value = selectedDevotee.Id;
                devoteeRow.Cells[Constants.GridColumnIndex_Devotees_Gothram].Value = selectedDevotee.Gothram;
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

        private void txtAmountGiven_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.Focus();
            }
        }

        private void txtAmountGiven_Leave(object sender, EventArgs e)
        {
            var amount = Convert.ToDouble(txtAmountGiven.Text);
            var total = Convert.ToDouble(txtTotalCost.Text);
            txtReturnChange.Text = string.Format("{0:F}", amount - total);
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            txtQuantity.SelectAll();
        }

        private void txtCost_Enter(object sender, EventArgs e)
        {
            txtCost.SelectAll();
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            txtPhoneNumber.SelectAll();
        }

        private void mtxtServiceNumber_Enter(object sender, EventArgs e)
        {
            mtxtServiceNumber.SelectAll();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var tokens = new TokenDao().ProcessTokens(_selectedTokens.ToList(), _selectedDevotees.ToList());
            PrintTokens(tokens);
        }

        private void dgvDevotees_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            var devoteeRow = dgvDevotees.Rows[e.RowIndex];
            
            var devotee = devoteeRow.DataBoundItem as Devotee;
            if (devotee != null && !string.IsNullOrWhiteSpace(devotee.DevoteeName))
            {
                devotee.PhoneNumber = txtPhoneNumber.Text;
                devotee.DoorNumber = txtDoorNo.Text;
                devotee.EmailId = txtEmail.Text;
                devotee.AreaName = txtArea.Text;
                devotee.City = txtCity.Text;
                devotee.MandalName = txtMandal.Text;
                devotee.DistrictName = txtDistrict.Text;
                devotee.StateName = txtState.Text;
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
        }

        public class Constants
        {
            public const int GridColumnIndex_Devotees_TokenIndex = 0;
            public const int GridColumnIndex_Devotees_ServiceName = 1;
            public const int GridColumnIndex_Devotees_Prefix = 2;
            public const int GridColumnIndex_Devotees_DevoteeId = 3;
            public const int GridColumnIndex_Devotees_DevoteeName = 4;
            public const int GridColumnIndex_Devotees_Gothram = 5;

            public const int GridColumnIndex_Tokens_Service = 0;
            public const int GridColumnIndex_Tokens_Quantity = 1;
            public const int GridColumnIndex_Tokens_Cost = 2;
            public const int GridColumnIndex_Tokens_Action = 3;
        }


        #region Printing Related

        private void PrintTokens(List<Token> tokens)
        {
            _tokensToPrint = tokens;
            _pageCounter = 0;

            PrintDocument pd = new PrintDocument();
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


        private string RenderToken(Token token)
        {
            var sb = new StringBuilder();
            string line = string.Empty;
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine(_rulerLine);
            line = string.Format("  Sl No : {0}", token.Id).PadRight(_lineWidth / 2)
                + string.Format("Date : {0:dd/MM/yyyy h:mm tt}  ", token.CreatedOn).PadLeft(_lineWidth / 2);
            sb.AppendLine(line);
            sb.AppendLine(_rulerLine);

            line = string.Format("    Purpose : {0}", token.ServiceName).PadRight(_lineWidth);
            sb.AppendLine(line);

            line = string.Format("    పేరు : {0} {1}", token.PrefixName, token.DevoteeName).PadRight(_lineWidth);
            sb.AppendLine(line);

            line = string.Format("    గోత్రం : {0}", token.Gothram).PadRight(_lineWidth);
            sb.AppendLine(line);

            sb.AppendLine(_rulerLine);
            line = string.Format("  Qty : {0}", token.Quantity).PadRight(_lineWidth / 2)
                + string.Format("Amt : {0:F}  ", token.TotalCost).PadLeft(_lineWidth / 2);
            sb.AppendLine(line);
            sb.AppendLine(_rulerLine);
            sb.AppendLine();

            return sb.ToString();
        }

        int _pageCounter;
        List<Token> _tokensToPrint;
        private const int _lineWidth = 60;
        private string _rulerLine = string.Empty.PadLeft(_lineWidth, '-');
        PaperSize paperSize = new PaperSize("Custom receipt", 400, 400);
        
        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Segoe UI", 11, System.Drawing.FontStyle.Regular);

            if (_pageCounter < _tokensToPrint.Count)
            {
                e.Graphics.DrawString(RenderToken(_tokensToPrint[_pageCounter]),
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


    }
}
