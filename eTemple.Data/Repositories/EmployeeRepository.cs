using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class EmployeeRepository : IRepository<Employees>
    {
        private eTempleDbDB TempleDb;

        public EmployeeRepository()
        {
            TempleDb = new eTempleDbDB();
        }
        public void Add(Employees entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employees entity)
        {
            throw new NotImplementedException();
        }

        public Employees FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employees> GetAllAsQuerable()
        {
            return TempleDb.Query<Employees>("Select * From employees").ToList();
        }

        public void Update(Employees entity)
        {
            throw new NotImplementedException();
        }
    }
}
