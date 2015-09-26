using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class PakshaRepository : IRepository<Paksha>
    {
        private eTempleDbDB TempleDb;

        public PakshaRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(Paksha entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Paksha entity)
        {
            throw new NotImplementedException();
        }

        public Paksha FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paksha> GetAllAsQuerable()
        {
            return TempleDb.Query<Paksha>("Select * From paksha order by Id asc").ToList();
        }

        public void Update(Paksha entity)
        {
            throw new NotImplementedException();
        }
    }
}
