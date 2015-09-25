using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public class MonthlyAnnaRepository : IRepository<MonthlyAnnaDanam>
    {
        private eTempleDbDB TempleDb;
        public MonthlyAnnaRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public void Add(MonthlyAnnaDanam entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MonthlyAnnaDanam entity)
        {
            throw new NotImplementedException();
        }

        public MonthlyAnnaDanam FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MonthlyAnnaDanam> GetAllAsQuerable()
        {
            return TempleDb.Query<MonthlyAnnaDanam>("Select * From MonthlyAnnadanamtbl order by Id asc").ToList();
        }

        public IEnumerable<MonthlyAnnaDanam> GetAllAsQuerable(int DayId)
        {
            return TempleDb.Query<MonthlyAnnaDanam>("Select * From MonthlyAnnadanamtbl where Id = " + DayId + " order by Day asc").ToList();
        }

        public void Update(MonthlyAnnaDanam entity)
        {
            throw new NotImplementedException();
        }
    }
}
