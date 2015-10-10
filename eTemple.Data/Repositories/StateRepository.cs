using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class StateRepository : IRepository<State>
    {
        private eTempleDbDB TempleDb;

        public StateRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(State entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(State entity)
        {
            throw new NotImplementedException();
        }

        public State FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<State> GetAllAsQuerable()
        {
            return TempleDb.Query<State>("Select * From State order by Id asc").ToList();
        }


        public void Update(State entity)
        {
            throw new NotImplementedException();
        }
    }
}
