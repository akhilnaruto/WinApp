using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class PattiOutDao
    {
        public List<PattiOut> GetAllPattiOut(String dt)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<PattiOut>(
                    @"select p.*, e.Loginid as Entered_By, s.Name as ServiceName from PattiOut p 
                    inner join Employees e on (p.EnteredBy = e.Id) 
                    inner join Services s on (p.ServiceId = s.Id) Where DATE(p.EnteredOn) like '" + dt + "' order by p.Id desc").ToList();
            }
        }

        public List<PattiOut> GetAllPattiOutWithoutDate()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<PattiOut>(
                    @"select p.*, e.Loginid as Entered_By, s.Name as ServiceName from PattiOut p 
                    inner join Employees e on (p.EnteredBy = e.Id) 
                    inner join Services s on (p.ServiceId = s.Id) order by p.Id desc").ToList();
            }
        }

        public PattiOut GetPattiOut(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<PattiOut>(Id);
            }
        }

        public void SavePattiOut(PattiOut poObj)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(poObj);
            }
        }

        public int UpdatePattiOut(PattiOut poObj)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update(poObj);
            }
        }
    }
}
