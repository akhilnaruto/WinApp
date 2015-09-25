using System;
using System.Collections.Generic;
using System.Linq;
using eTemple.Data.Models;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class RolesRepository : IRepository<Role>
    {
        private eTempleDbDB TempleDb;
        public RolesRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(Role entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Role entity)
        {
            throw new NotImplementedException();
        }

        public Role FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAllAsQuerable()
        {
            return TempleDb.Query<Role>("Select * From roles order by Name asc").ToList();
        }

        public void Update(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}