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
    public partial class AdminConsole : Form
    {
        private EmployeeRepository empRepo;
        public AdminConsole()
        {
            InitializeComponent();
            empRepo = new EmployeeRepository();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
