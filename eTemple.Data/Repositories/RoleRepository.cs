using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;
namespace eTemple.Data.Repositories
{
    public class RoleRepository : IRepository<Roles>
    {
        private eTempleDbDB TempleDb;

        public RoleRepository()
        {
            TempleDb = new eTempleDbDB();
        }
        public void Add(Roles entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Roles entity)
        {
            throw new NotImplementedException();
        }

        public Roles FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Roles> GetAllAsQuerable()
        {
            return TempleDb.Query<Roles>("Select * From roles order by Id asc").ToList();
        }
        
        public IEnumerable<Roles> GetAllAsQuerable(int roleId)
        {

            return TempleDb.Query<Roles>("Select * From roles where Id = " + roleId + " order by Id asc").ToList();

        }

        public void Update(Roles entity)
        {
            throw new NotImplementedException();
        }
    }
}
