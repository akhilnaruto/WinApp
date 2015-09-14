using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data
{
    public class ServiceDao
    {

        public List<Service> GetAllServices()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Service>(
                    @"select s.*, st.Name as ServiceType, e1.LoginId as Created_By, e2.LoginId as Modified_By from Services s 
                    inner join ServiceTypes st on (s.Type = st.Id)
                    inner join Employees e1 on (e1.Id = s.CreeatedBy)
                    inner join Employees e2 on (e2.Id = s.ModifiedBy)
                    order by s.Id desc").ToList();
            }
        }

        public List<Service> GetAllServicesForSelection()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Service>("select Id, Name, Cost from Services").ToList();
            }
        }

        public List<Service> GetAllPoojas()
        {
            using (var db = new eTempleDbDB())
            {
                var poojas = db.Query<Service>("Select * From Services").ToList();
                return poojas;
            }
        }

        public List<Service> GetAllVIPPrasadam()
        {
            using (var db = new eTempleDbDB())
            {
                var poojas = db.Query<Service>("Select * From Services where Type in(2, 11, 16) ").ToList();
                return poojas;
            }
        }

        public List<Service> GetAllPoojasExceptVIPPrasadam()
        {
            using (var db = new eTempleDbDB())
            {
                var poojas = db.Query<Service>("Select * From Services where Type not in(16) ").ToList();
                return poojas;
            }
        }

        public List<Service> GetAllPoojasExceptMiscIncomeHundials()
        {
            using (var db = new eTempleDbDB())
            {
                var poojas = db.Query<Service>("Select * From Services where Type not in(13, 14, 16) ").ToList();
                return poojas;
            }
        }

        public List<Service> GetAllMiscIncomes()
        {
            using (var db = new eTempleDbDB())
            {
                var poojas = db.Query<Service>("Select * From Services where Type in(14) ").ToList();
                return poojas;
            }
        }

        public List<Service> GetAllHundials1()
        {
            using (var db = new eTempleDbDB())
            {
                var poojas = db.Query<Service>("Select * From Services where Type in(13) ").ToList();
                return poojas;
            }
        }

        public int GetHundials()
        {
            using (var db = new eTempleDbDB())
            {
                var serviceObj = db.SingleOrDefault<Service>("Select * From Services where Type in(13) order by Id desc LIMIT 0, 1");
                if (serviceObj != null && serviceObj.Id != null)
                {
                    return (int)serviceObj.Id;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int GetMiscIncomes()
        {
            using (var db = new eTempleDbDB())
            {
                var serviceObj = db.SingleOrDefault<Service>("Select * From Services where Type in(14) order by Id desc LIMIT 0, 1");
                if (serviceObj != null && serviceObj.Id != null)
                {
                    return (int)serviceObj.Id;
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<Service> GetAllPoojasExceptPrasadam()
        {
            using (var db = new eTempleDbDB())
            {
                var poojas = db.Query<Service>("Select * From Services where Type!=2").ToList();
                return poojas;
            }
        }

        public Service GetPrintSeries(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<Service>(Id);
            }
        }

        public int SavePrintSeries(Service ps)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(ps);
                return ps.Id;
            }
        }

        public int UpdatePrintSeries(Service ps)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update(ps);
            }
        }

        public List<Service> GetDcrReport(DateTime fromDate, DateTime toDate)
        {
            var startDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day);
            var endDate = new DateTime(toDate.Year, toDate.Month, toDate.Day);

            if (startDate == endDate)
                endDate.AddDays(1);

            using (var db = new eTempleDbDB())
            {
                //sum(t.Quantity) as SoldQuantity
                return db.Query<Service>(@"select s.Id, s.Name, s.Cost, sum(t.Quantity) as SoldQuantity, s.Type, sum(t.TotalCost) as TotalCollection, max(t.ServiceDailyNumber) as EndingNumber, min(t.ServiceDailyNumber) as StartingNumber 
                                            from Services s
                                            left outer join Tokens t on ( s.Id = t.ServiceId and t.CreatedOn between @0 and @1 and t.Status=1 and s.Type not in(16) )  
                                            where s.Type != 16
                                            group by s.Id, s.Name", startDate, endDate).ToList();
                /*
                return db.Query<Service>(@"select s.Id, s.Name, (max(t.ServiceDailyNumber) - min(t.ServiceDailyNumber) + 1) as SoldQuantity, sum(t.TotalCost) as TotalCollection, max(t.ServiceDailyNumber) as EndingNumber, min(t.ServiceDailyNumber) as StartingNumber 
                                            from Services s
                                            left outer join Tokens t on ( s.Id = t.ServiceId and t.CreatedOn between @0 and @1) 
                                            group by s.Id, s.Name", startDate, endDate).ToList();
                */

            }
        }

        public List<Service> GetOperatorReport(DateTime cDate, int cUsername)
        {
            var curDate = new DateTime(cDate.Year, cDate.Month, cDate.Day);

            using (var db = new eTempleDbDB())
            {
                return db.Query<Service>(@"select s.Id, s.Name, sum(t.Quantity) as SoldQuantity, sum(t.TotalCost) as TotalCollection 
                                            from Services s
                                            left outer join Tokens t on ( s.Id = t.ServiceId and DATE(t.CreatedOn) = @0 and t.CreatedBy = @1 and t.Status=1) 
                                            where s.Type != 16
                                            group by s.Id, s.Name", curDate, cUsername).ToList();

            }
        }
    }
}
