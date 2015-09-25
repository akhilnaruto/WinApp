using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
   public  class MonthsRepository : IRepository<Months>
    {
        private eTempleDbDB TempleDb;

        public MonthsRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(Months entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Months entity)
        {
            throw new NotImplementedException();
        }

        public Months FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Months> GetAllAsQuerable()
        {
            return TempleDb.Query<Months>("Select * From month order by Id").ToList();
        }

        public IEnumerable<Months> GetAllAsQuerable(int donorMonthId)
        {

            return TempleDb.Query<Months>("Select * From month where Id = " + donorMonthId + " order by Name asc").ToList();

        }

        public void Update(Months entity)
        {
            throw new NotImplementedException();
        }
    }
}
