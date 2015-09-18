using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class DonorRepository : IRepository<Donors>
    {
        private eTempleDbDB TempleDb;
        public DonorRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public IEnumerable<Donors> GetAllAsQuerable()
        {
          
           return TempleDb.Query<Donors>("Select * From donors order by Name asc").ToList();
          
        }

        public void Add(Donors entity)
        {
            TempleDb.Save(entity);
        }

        public void Delete(Donors entity)
        {
            throw new NotImplementedException();
        }

        public Donors FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Donors entity)
        {
            TempleDb.Update(entity);
        }
    }
}
