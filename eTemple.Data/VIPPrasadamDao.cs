using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class VIPPrasadamDao
    {
        public List<VIPPrasadam> GetAllVIPPrasadamDetails(String dt)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<VIPPrasadam>("SELECT v.*, s.Name as ServiceName, e.Name as ReferenceByName FROM VIPPrasadam as v inner join Services as s on (v.ServiceId = s.Id) inner join Employees as e on (v.ReferenceBy = e.Id) Where DATE(VisitedDate) like '" + dt + "' order by v.Id desc ").ToList();
            }
        }
        
        public List<VIPPrasadam> GetAllVIPPrasadamDetails()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<VIPPrasadam>("SELECT v.*, s.Name as ServiceName, e.Name as ReferenceByName FROM VIPPrasadam as v inner join Services as s on (v.ServiceId = s.Id) inner join Employees as e on (v.ReferenceBy = e.Id) order by v.Id desc ").ToList();
            }
        }

        public List<VIPPrasadam> GetVIPPrasadamDetailsByDate(DateTime dt)
        {
            String dt1 = String.Format("{0:yyyy-MM-dd}", dt);
            using (var db = new eTempleDbDB())
            {
                return db.Query<VIPPrasadam>("SELECT v.*, s.Name as ServiceName FROM VIPPrasadam as v inner join Services as s on (v.ServiceId = s.Id and DATE(v.VisitedDate) like '@0' ')", dt1).ToList();
            }
        }

        public List<VIPPrasadam> GetDaycount(DateTime dt)
        {
            String dt1 = String.Format("{0:yyyy-MM-dd}", dt);
            using (var db = new eTempleDbDB())
            {
                return db.Query<VIPPrasadam>("SELECT s.Name as ServiceName, v.ServiceId, sum(v.Qty) as Qty FROM VIPPrasadam as v inner join Services as s on ( s.Id = v.ServiceId and date(v.VisitedDate) = '" + dt1 + "')  group by v.ServiceId ").ToList();
            }
        }

        public int SaveVIPPrasadam(VIPPrasadam vObj)
        {
            var savedTokens = new List<VIPPrasadam>();
            using (var db = new eTempleDbDB())
            {
                db.Save(vObj);
                return vObj.Id;
            }
        }

        public VIPPrasadam getTokenById(int TokenId)
        {
            using (var db = new eTempleDbDB())
            {
                return db.FirstOrDefault<VIPPrasadam>("select v.*, s.Name as ServiceName from VIPPrasadam as v inner join Services as s on v.ServiceId = s.Id where v.Id = @0", TokenId);
            }
        }


        public int UpdateVIPPrasadam(VIPPrasadam vObj)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update(vObj);
            }
        }

    }
}
