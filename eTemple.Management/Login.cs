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
    public partial class Login : Form
    {
        private EmployeeRepository empRepo;
        public Login()
        {
            InitializeComponent();
            empRepo = new EmployeeRepository();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool checkvalidate = validation();

            var emp = empRepo.ValidateLogin(txtLoginId.Text, txtPassword.Text);
            if (emp != null && !string.IsNullOrEmpty(emp.Name))
            {
                ApplicationElements.loggedInEmployee = emp;
                ManagementConsole mgmt = new ManagementConsole();
                this.Hide();
                mgmt.ShowDialog();
                this.Dispose();
                //new MainForm().Show();
            }
            else
            {
                MessageBox.Show("Invalid user name or password ! Please try again.", "Unable to login !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoginId.Focus();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool validation()
        {
            bool needValidate = true;

            if (txtLoginId.Text == "" || txtLoginId.Text == string.Empty)
            {
                errorProvider1.SetError(txtLoginId, "Need to enter Login Id to continue");
                needValidate = false;
                return needValidate;
            }

            if (txtPassword.Text == "" || txtPassword.Text == string.Empty)
            {
                errorProvider1.SetError(txtLoginId, "Need to enter Password to continue");
                needValidate = false;
                return needValidate;
            }
            return needValidate;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
