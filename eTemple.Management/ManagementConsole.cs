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
    public partial class ManagementConsole : Form
    {
        

        public ManagementConsole()
        {
            InitializeComponent();        
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxAdmin_Click(object sender, EventArgs e)
        {
            AdminConsole admConsole = new AdminConsole();
            admConsole.ShowDialog();
        }
    }
}
