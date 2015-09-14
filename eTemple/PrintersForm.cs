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
    public partial class PrintersForm : Form
    {
        public PrintersForm()
        {
            InitializeComponent();
        }

        private void PrintersForm_Load(object sender, EventArgs e)
        {
            tblPanel.Location = new Point(
                (this.ClientSize.Width / 2) - (tblPanel.Size.Width / 2)
            );
            tblPanel.Anchor = AnchorStyles.Top;
        }
    }
}
