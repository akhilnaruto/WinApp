using eTemple.Data;
using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTemple.UI
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        
        private void Employees_Load(object sender, EventArgs e)
        {
            var designationDao = new DesignationDao();
            var roleDao = new RoleDao();

            cmbRoles.DataSource = roleDao.GetAllRoles();
            cmbDesignations.DataSource = designationDao.GetAllDesignations();

            ShowEmployees();
        }

        private void ShowEmployees()
        {
            var empDao = new EmployeeDao();
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.DataSource = empDao.GetAllEmployees();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (formValidator.Validate())
            {
                int empId = 0;
                int.TryParse(txtEmployeeId.Text, out empId);
                var emp = new Employee
                {
                    Id = empId,
                    Name = txtName.Text,
                    Role = (cmbRoles.SelectedItem as Role).Id,
                    Designation = (cmbDesignations.SelectedItem as Designation).Id,
                    AllowLogin = Convert.ToSByte(chkAllowLogin.Checked),
                    IsDeleted = Convert.ToSByte(chkIsDeleted.Checked),
                    LoginId = txtLoginId.Text,
                    Password = txtPassword.Text,
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now,
                    ModifiedBy = 1,
                    ModifiedOn = DateTime.Now
                };

                var empDao = new EmployeeDao();
                empDao.SaveEmployee(emp);

                ShowEmployees();
            }
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var emp = dgvEmployees.Rows[e.RowIndex].DataBoundItem as Employee;
                ShowEmployee(emp);
            }
        }

        private void ShowEmployee(Employee emp)
        {
            txtEmployeeId.Text = emp.Id.ToString();
            txtName.Text = emp.Name;
            cmbDesignations.SelectedValue = emp.Designation;
            cmbRoles.SelectedValue = emp.Role;
            chkAllowLogin.Checked = Convert.ToBoolean(emp.AllowLogin);
            chkIsDeleted.Checked = Convert.ToBoolean(emp.IsDeleted);
            txtLoginId.Text = emp.LoginId;
            txtPassword.Text = emp.Password;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowEmployees();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
