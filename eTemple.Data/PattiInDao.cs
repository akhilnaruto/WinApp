using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class PattiInDao
    {
        public List<PattiIn> GetAllPattiIn()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<PattiIn>(
                    @"select p.*, e.Loginid as Entered_By, s.Name as ServiceName from PattiIn p 
                    inner join Employees e on (p.EnteredBy = e.Id) 
                    inner join Services s on (p.ServiceId = s.Id) order by p.Id desc").ToList();
            }
        }

        public PattiIn GetPattiIn(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<PattiIn>(Id);
            }
        }

        public void SavePattiIn(PattiIn piObj)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(piObj);
            }
        }

        public int UpdatePattiIn(PattiIn piObj)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update(piObj);
            }
        }
    }
}
