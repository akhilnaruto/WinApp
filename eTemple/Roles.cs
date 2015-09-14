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
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
            ShowRoles();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            ShowRoles();
        }

        private void ShowRoles()
        {
            var roleDao = new RoleDao();
            dgvRoles.DataSource = roleDao.GetAllRoles();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gpbRoles_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int roleId = 0;
            int.TryParse(txtRoleId.Text, out roleId);
            var role_obj = new Role
            {
                Id = roleId,
                Name = txtRoleName.Text
            };
            var roleDao = new RoleDao();
            roleDao.SaveRole(role_obj);

            ShowRoles();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var role_obj = dgvRoles.Rows[e.RowIndex].DataBoundItem as Role;
                ShowRole(role_obj);
            }
        }

        private void ShowRole(Role roleobj)
        {
            txtRoleId.Text = roleobj.Id.ToString();
            txtRoleName.Text = roleobj.Name;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowRoles();
        }

    }
}
