using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class DesignationRepository : IRepository<Designations>
    {
        private eTempleDbDB TempleDb;

        public DesignationRepository()
        {
            TempleDb = new eTempleDbDB();
        }
        public void Add(Designations entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Designations entity)
        {
            throw new NotImplementedException();
        }

        public Designations FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Designations> GetAllAsQuerable()
        {
            return TempleDb.Query<Designations>("Select * From designations").ToList();
        }

        public void Update(Designations entity)
        {
            throw new NotImplementedException();
        }
    }
}
