using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class DateTypeRepository : IRepository<DateType>
    {
        private eTempleDbDB TempleDb;

        public DateTypeRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(DateType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(DateType entity)
        {
            throw new NotImplementedException();
        }

        public DateType FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DateType> GetAllAsQuerable()
        {
            return TempleDb.Query<DateType>("Select * From datetype order by Id asc").ToList();
        }

        public IEnumerable<DateType> GetAllAsQuerable(int dateTypeId)
        {

            return TempleDb.Query<DateType>("Select * From datetype where Id = " + dateTypeId + " order by Name asc").ToList();

        }

        public void Update(DateType entity)
        {
            throw new NotImplementedException();
        }
    }
}
 