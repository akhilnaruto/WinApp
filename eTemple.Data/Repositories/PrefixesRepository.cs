using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class PrefixesRepository : IRepository<Prefixes>
    {
        private eTempleDbDB TempleDb;

        public PrefixesRepository()
        {
            TempleDb = new eTempleDbDB();
        }
        public void Add(Prefixes entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Prefixes entity)
        {
            throw new NotImplementedException();
        }

        public Prefixes FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prefixes> GetAllAsQuerable()
        {
            return TempleDb.Query<Prefixes>("Select * From prefixes").ToList();
        }

        public void Update(Prefixes entity)
        {
            throw new NotImplementedException();
        }
    }
}
