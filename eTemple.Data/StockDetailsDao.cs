using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class StockDetailsDao
    {
        public List<StockDetail> GetAllStockDetails()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<StockDetail>("SELECT sd.ServiceId, sd.Stock, s.Name as ServiceName FROM StockDetails as sd inner join Services as s on sd.ServiceId = s.Id  and ServiceId in (Select Id from Services where Type=2)").ToList();
            }
        }

        public int getStockByServiceId(int serviceId)
        {
            using (var db = new eTempleDbDB())
            {
                var sdObj = db.SingleOrDefault<StockDetail>("select * from StockDetails where ServiceId=@0", serviceId);
                if (sdObj != null && sdObj.Stock!= null)
                {
                    return (int)sdObj.Stock;
                }
                else
                {
                    return 0;
                }
            }
        }

        public StockDetail GetStockDetail(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<StockDetail>(Id);
            }
        }

        public void SaveStockDetail(StockDetail stObj)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(stObj);
            }
        }

        public void UpdateStockDetail(int stockVal, int sId)
        {
            using (var db = new eTempleDbDB())
            {
                db.Execute("Update StockDetails set Stock = Stock - @0 where ServiceId = @1 ", stockVal, sId);
            }
        }
    }
}
