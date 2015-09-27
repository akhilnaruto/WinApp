using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data.Repositories
{

    public class GothramsRepository : IRepository<Gothrams>
    {
        private eTempleDbDB TempleDb;

        public GothramsRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(Gothrams entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gothrams entity)
        {
            throw new NotImplementedException();
        }

        public Thidhi FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gothrams> GetAllAsQuerable()
        {
            return TempleDb.Query<Gothrams>("Select name From Gothrams").ToList();
        }

        public void Update(Gothrams entity)
        {
            throw new NotImplementedException();
        }
    }
}
