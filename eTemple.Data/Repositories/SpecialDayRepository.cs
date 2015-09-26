using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class SpecialDayRepository : IRepository<SpecialDay>
    {
        private eTempleDbDB TempleDb;

        public SpecialDayRepository()
        {
            TempleDb = new eTempleDbDB();
        }
        public void Add(SpecialDay entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SpecialDay entity)
        {
            throw new NotImplementedException();
        }

        public SpecialDay FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SpecialDay> GetAllAsQuerable()
        {
            return TempleDb.Query<SpecialDay>("Select * From specialday order by Id asc").ToList();
        }

        public IEnumerable<SpecialDay> GetAllAsQuerable(int specialDayId)
        {

            return TempleDb.Query<SpecialDay>("Select * From specialday where Id = " + specialDayId + " order by Name asc").ToList();

        }

        public void Update(SpecialDay entity)
        {
            throw new NotImplementedException();
        }
    }
}
