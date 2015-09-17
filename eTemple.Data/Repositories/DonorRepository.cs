using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class DonorRepository : IRepository<Donor>
    {
        private eTempleDbDB TempleDb;
        public DonorRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public IEnumerable<Donor> GetAllAsQuerable()
        {
          
           return TempleDb.Query<Donor>("Select * From donors order by Name asc").ToList();
          
        }

        public void Add(Donor entity)
        {
            TempleDb.Save(entity);
        }

        public void Delete(Donor entity)
        {
            throw new NotImplementedException();
        }

        public Donor FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Donor entity)
        {
            TempleDb.Update(entity);
        }
    }
}
