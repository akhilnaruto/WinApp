using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class StarsRepository : IRepository<Stars>
    {
        private eTempleDbDB TempleDb;

        public StarsRepository()
        {
            TempleDb = new eTempleDbDB();
        }
        public void Add(Stars entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Stars entity)
        {
            throw new NotImplementedException();
        }

        public Stars FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stars> GetAllAsQuerable()
        {
            return TempleDb.Query<Stars>("Select * From stars order by Id asc").ToList();
        }

        public IEnumerable<Stars> GetAllAsQuerable(int starId)
        {
            return TempleDb.Query<Stars>("Select * From stars where Id = " + starId + " order by Name asc").ToList();
        }

        public void Update(Stars entity)
        {
            throw new NotImplementedException();
        }
    }
}
