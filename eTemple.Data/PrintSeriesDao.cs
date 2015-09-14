using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class PrintSeriesDao
    {
        public List<PrintSeries> GetAllPrintSeries(String dt, String dt1, int Uid)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<PrintSeries>(
                    @"select p.*, e.Loginid as Given_To, e1.LoginId as Given_By from PrintSeries p 
                    inner join Employees e on (p.GivenTo = e.Id) 
                    inner join Employees e1 on (p.CreatedBy = e1.Id) where (DATE(p.CreatedOn) between '" + dt + "' and '" + dt1 + "') and p.GivenTo='" + Uid + "' order by p.Id desc").ToList();
            }
        }

        public List<PrintSeries> GetAllPrintSeries(String dt)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<PrintSeries>(
                    @"select p.*, e.Loginid as Given_To, e1.LoginId as Given_By from PrintSeries p 
                    inner join Employees e on (p.GivenTo = e.Id) 
                    inner join Employees e1 on (p.CreatedBy = e1.Id) where DATE(p.CreatedOn) like '" + dt + "' order by p.Id desc").ToList();
            }
        }

        public List<PrintSeries> GetAllPrintSeries()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<PrintSeries>(
                    @"select p.*, e.Loginid as Given_To, e1.LoginId as Given_By from PrintSeries p 
                    inner join Employees e on (p.GivenTo = e.Id) 
                    inner join Employees e1 on (p.CreatedBy = e1.Id) order by p.Id desc").ToList();
            }
        }
        public List<PrintSeries> GetAllPrintSeriesBalance()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<PrintSeries>("Select p.GivenTo, p.EmployeeName, p.TotalGivenTokens, t.Qty, (p.TotalGivenTokens - t.Qty) as Balance from PSCView as p INNER JOIN TknView as t on(p.GivenTo = t.CreatedBy)").ToList();
            }
        }

        public PrintSeries GetPrintSeries(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<PrintSeries>(Id);
            }
        }

        public void SavePrintSeries(PrintSeries ps)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(ps);
            }
        }

        public int UpdatePrintSeries(PrintSeries ps)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update(ps);
            }
        }

        public long getMinGovtNumber(int uId)
        {
            using (var db = new eTempleDbDB())
            {
                var PrintSeriesObj = db.SingleOrDefault<PrintSeries>("select PrintseriesStart from PrintSeries where GivenTo = '@0'  order by Id desc LIMIT 0, 1", uId);
                if (PrintSeriesObj != null && PrintSeriesObj.PrintseriesStart != null)
                {
                    return (long)PrintSeriesObj.PrintseriesStart;
                }
                else
                {
                    long gId = 0;
                    return gId;
                }
            }
        }

        public long getMaxGovtNumber(int uId)
        {
            using (var db = new eTempleDbDB())
            {
                var PrintSeriesObj = db.SingleOrDefault<PrintSeries>("select PrintseriesEnd from PrintSeries where GivenTo = '@0'  order by Id desc LIMIT 0, 1", uId);
                if (PrintSeriesObj != null && PrintSeriesObj.PrintseriesEnd != null)
                {
                    return (long)PrintSeriesObj.PrintseriesEnd;
                }
                else
                {
                    long gId = 0;
                    return gId;
                }
            }
        }

    }
}
