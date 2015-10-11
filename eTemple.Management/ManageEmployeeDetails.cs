using eTemple.Data.Models;
using eTemple.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTemple.Management
{
    public partial class ManageEmployeeDetails : Form
    {
        private EmployeeRepository empRepo;
        private RoleRepository roleRepo;
        private BindingSource bindingSource = null;
        private DataTable dtDetails;
        public string userId;
        public int rowId;
        public int maxId;
        public ManageEmployeeDetails()
        {
            InitializeComponent();
            empRepo = new EmployeeRepository();
            roleRepo = new RoleRepository();
            HideControls(false);
        }

        public void HideControls(bool showhide)
        {
            if (showhide == false)
            {
                lblId.Visible = false;
                lblLoginName.Visible = false;
                lblName.Visible = false;
                lblPassword.Visible = false;
                lblRole.Visible = false;
                txtId.Visible = false;
                txtLoginName.Visible = false;
                txtName.Visible = false;
                txtPassword.Visible = false;
                txtRole.Visible = false;
                cmbRoleType.Visible = false;
                btnDelete.Visible = false;
                btnSave.Visible = false;
                btnUpdate.Visible = false;
                btnCancel.Visible = false;
            }
            else if (showhide == true)
            {
                lblId.Visible = true;
                lblLoginName.Visible = true;
                lblName.Visible = true;
                lblPassword.Visible = true;
                lblRole.Visible = true;
                txtId.Visible = true;
                txtLoginName.Visible = true;
                txtName.Visible = true;
                txtPassword.Visible = true;
                txtRole.Visible = true;
                cmbRoleType.Visible = false;
                btnDelete.Visible = true;
                btnSave.Visible = true;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageEmployeeDetails_Load(object sender, EventArgs e)
        {
            loadGridviewData();
        }

        public void loadGridviewData()
        {
            dtDetails = new DataTable();
            dtDetails = empRepo.getEmpData();
            bindingSource = new BindingSource();
            bindingSource.DataSource = dtDetails;

            dgvEmployee.DataSource = bindingSource;
            dgvEmployee.ReadOnly = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userId = dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
            rowId = dgvEmployee.Rows[e.RowIndex].Index;
            HideControls(true);
            loadControls();

        }
        /// <summary>
        /// 
        /// </summary>
        public void loadControls()
        {
            if (dtDetails.Rows.Count == 0)
            {
                int set = 100;
                txtId.Text = set.ToString();
                btnUpdate.Visible = false;
                btnSave.Visible = true;
                btnDelete.Enabled = false;
            }
            else
            {
                try
                {
                    bindDataOnGridViewClick();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void bindDataOnGridViewClick()
        {
            var bindRoleType = roleRepo.GetAllAsQuerable();
            var cmbRoleTypeList = bindRoleType.ToList();
            cmbRoleType.DataSource = cmbRoleTypeList;
            cmbRoleType.DisplayMember = "Name";
            cmbRoleType.Visible = true;
            txtRole.Visible = false;


            Roles newRole = new Roles
            {
                Id = Convert.ToInt32(dtDetails.Rows[rowId]["Role"]),
                Name = ""
            };

            var bindRoleT = roleRepo.GetAllAsQuerable(newRole.Id);
            string[] roleValue = bindRoleT.Select(p => p.Name).ToArray();
            cmbRoleType.SelectedIndex = cmbRoleType.FindString(roleValue[0]);

            txtId.Text = dtDetails.Rows[rowId]["Id"].ToString();
            txtName.Text = dtDetails.Rows[rowId]["Name"].ToString();
            txtLoginName.Text = dtDetails.Rows[rowId]["LoginId"].ToString();
            txtPassword.Text = dtDetails.Rows[rowId]["Password"].ToString();
            txtRole.Visible = false;
            cmbRoleType.Visible = true;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnDelete.Visible = true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string status = empRepo.DeleteEmployee(userId);
                    HideControls(false);
                    loadGridviewData();
                }
                else
                {
                    //HideControls(false);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRoleTypeId = 0;
            var selectedRoleType = cmbRoleType.SelectedItem as Roles;
            if (selectedRoleType == null)
                selectedRoleTypeId = 0;
            else
                selectedRoleTypeId = selectedRoleType.Id;

            Employees empDetials = new Employees
            {
                Id = Convert.ToInt32(dtDetails.Rows[rowId]["Id"]),
                LoginId = txtLoginName.Text.Trim(),
                Name = txtName.Text.Trim(),
                Role = selectedRoleTypeId,
                Password = txtPassword.Text,
                CreatedOn = DateTime.Today.Date,
                CreatedBy = ApplicationElements.loggedInEmployee.Id
            };

            string updateStatus = empRepo.updateEmployeeInformation(empDetials);

                if (updateStatus == "Success")
                {
                    MessageBox.Show("Details updated successfully.");
                    CleareAllcontrolsRecursive();
                }
                txtRole.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            CleareAllcontrolsRecursive();
            HideControls(true);
            maxId = Convert.ToInt16(dtDetails.Compute("MAX(id)", string.Empty));
            maxId = maxId + 1;
            txtId.Text = maxId.ToString();
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            btnDelete.Visible = false;

            var bindRoleType = roleRepo.GetAllAsQuerable();
            var cmbRoleTypeList = bindRoleType.ToList();
            cmbRoleType.DataSource = cmbRoleTypeList;
            cmbRoleType.DisplayMember = "Name";
            cmbRoleType.Visible = true;
            txtRole.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int selectedRoleTypeId = 0;
            var selectedRoleType = cmbRoleType.SelectedItem as Roles;
            if (selectedRoleType == null)
                selectedRoleTypeId = 0;
            else
                selectedRoleTypeId = selectedRoleType.Id;

            Employees empDetials = new Employees
            {
                Id = maxId,
                LoginId = txtLoginName.Text.Trim(),
                Name = txtName.Text.Trim(),
                Role = selectedRoleTypeId,
                Password = txtPassword.Text,
                CreatedOn = DateTime.Today.Date,
                CreatedBy = ApplicationElements.loggedInEmployee.Id
            };

            string insertStatus = empRepo.InsertEmployee(empDetials);

            if (insertStatus == "Success")
            {
                MessageBox.Show("Data inserted successfully.");
                loadGridviewData();
                CleareAllcontrolsRecursive();
            }            
        }

        private void CleareAllcontrolsRecursive()
        {
            lblId.Visible = false;
            lblLoginName.Visible = false;
            lblName.Visible = false;
            lblPassword.Visible = false;
            lblRole.Visible = false;
            txtId.Visible = false;
            txtId.Text = "";
            txtLoginName.Visible = false;
            txtLoginName.Text = "";
            txtName.Visible = false;
            txtName.Text = "";
            txtPassword.Visible = false;
            txtPassword.Text = "";
            txtRole.Visible = false;
            cmbRoleType.Visible = false;
            txtRole.Text = "";
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideControls(false);
        }
    }
}