using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class RoleDao
    {
        public List<Role> GetAllRoles()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Role>("Select * From Roles order by Name asc").ToList();
            }
        }

        public Role GetRole(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<Role>(Id);
            }
        }

        public void SaveRole(Role roleObj)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(roleObj);
            }
        }

        public int UpdateRole(Role roleObj)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update(roleObj);
            }
        }
    }
}
