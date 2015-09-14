using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class TimingDao
    {
        public List<Timing> GetAllTimings()
        {
            String timeVal = String.Format("{0: HH:mm:ss}", DateTime.Now);
            using (var db = new eTempleDbDB())
            {
                return db.Query<Timing>("select Id, TimeName from Timing where Status=1 and TimeVal >= '" + timeVal + "' order by Id asc").ToList();
            }
        }

        public List<Timing> GetTodayTimingsWithTokens()
        {
            String dt = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
            using (var db = new eTempleDbDB())
            {
                return db.Query<Timing>(@"Select t.Id as Id, t.TimeName as TimeName, sum(t1.Quantity) as Quantity from Timing as t left outer join Tokens as t1 on (t.Id = t1.TimeID and DATE(t1.CreatedOn)='" + dt + "' and t1.Status=1 and t1.ServiceId in (Select s.Id from Services as s where s.Type=9)) group by t.TimeName").ToList();
            }
        }

    }
}
