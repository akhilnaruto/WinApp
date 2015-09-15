using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class BatchDao
    {
        public long GetLastBatchDailyNumberByService(int serviceId)
        {
            using (var db = new eTempleDbDB())
            {
                var batchObj = db.SingleOrDefault<Batch>("where ServiceId=@0 order by Id desc LIMIT 0, 1", serviceId);
                if (batchObj != null && batchObj.LastDailyNumber != null)
                {
                    return batchObj.LastDailyNumber;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int GetLastBatchByService(int serviceId)
        {
            using (var db = new eTempleDbDB())
            {
                var batchObj = db.SingleOrDefault<Batch>("where ServiceId=@0 order by Id desc LIMIT 0, 1", serviceId);
                return batchObj.Id;
            }
        }


        public int GetDailyBatchByService(int serviceId, String cdtval)
        {
            using (var db = new eTempleDbDB())
            {
                var batchObj = db.SingleOrDefault<Batch>("where ServiceId=@0 and date(CreatedOn) like '@1' order by Id desc LIMIT 0, 1", serviceId, cdtval);
                if (batchObj != null && batchObj.DailyBatchId != 0)
                {
                    return (batchObj.DailyBatchId + 1);
                }
                else
                {
                    return 1;
                }
            }
        }
        
        public List<Batch> GetAllBatches()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Batch>(
                @"select b.*, s.Name as ServiceName from Batches b 
                    inner join Services s on (b.ServiceId = s.Id) order by b.Id desc").ToList();
            }
        }

        public Batch GetBatch(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<Batch>(Id);
            }
        }

        public void SaveBatch(Batch batchObj)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(batchObj);
            }
        }

        public void UpdateBatch(Batch batchObj)
        {
            using (var db = new eTempleDbDB())
            {
                db.Update(batchObj);
            }
        }
    }
}
