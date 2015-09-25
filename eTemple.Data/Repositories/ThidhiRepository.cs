using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class ThidhiRepository : IRepository<Thidhi>
    {
        private eTempleDbDB TempleDb;

        public ThidhiRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(Thidhi entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Thidhi entity)
        {
            throw new NotImplementedException();
        }

        public Thidhi FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Thidhi> GetAllAsQuerable()
        {
            return TempleDb.Query<Thidhi>("Select * From Thidhi order by Id asc").ToList();
        }

        public IEnumerable<Thidhi> GetAllAsQuerable(int thithiId)
        {

            return TempleDb.Query<Thidhi>("Select * From thidhi where Id = " + thithiId + " order by Name asc").ToList();

        }

        public void Update(Thidhi entity)
        {
            throw new NotImplementedException();
        }
    }
}
