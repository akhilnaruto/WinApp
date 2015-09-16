using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTemple.Data;
using MySql.Data.MySqlClient;

namespace eTemple.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (formValidator.Validate())
            {
                var empDao = new EmployeeDao();
                var emp = empDao.ValidateLogin(txtLoginId.Text, txtPassword.Text);
                if (emp != null && !string.IsNullOrEmpty(emp.Name))
                {
                    App.LoggedInEmployee = emp;
                    var printseriesDao = new PrintSeriesDao();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    //new MainForm().Show();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password ! Please try again.", "Unable to login !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLoginId.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error Occured.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLoginId.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnDataEntry_Click(object sender, EventArgs e)
        {

        }
    }
}
