using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data
{
    public class TokenDao
    {
        
        public List<Token> ProcessTokens(List<Token> tokens, List<Devotee> devotees)
        {
            var savedTokens = new List<Token>();
            using (var db = new eTempleDbDB())
            {
                int tokenCounter = 0;
                foreach (var t in tokens)
                {
                    for (int i = 0; i < t.Quantity; i++)
                    {
                        var newToken = new Token();
                        newToken.ServiceId = t.ServiceId;
                        newToken.Quantity = 1; // we always create a new record for each ticket.
                        newToken.TotalCost = t.TotalCost / t.Quantity;
                        if (devotees.Count > tokenCounter)
                        {
                            var tokenDevotee = devotees[tokenCounter];
                            if (tokenDevotee.Id == 0)
                            {
                                // use the first devotee if other devotee details are not mentioned.
                                tokenDevotee = devotees.FirstOrDefault(d => d.Id != 0);
                            }
                            if (tokenDevotee != null)
                            {
                                newToken.DevoteeId = tokenDevotee.Id;
                            }
                        }

                        newToken.CreatedBy = t.CreatedBy;
                        newToken.CreatedOn = t.CreatedOn;

                        db.Save(newToken);

                        newToken = db.FirstOrDefault<Token>(@"select t.*, s.Name as ServiceName, s.Type as ServiceTypeID, s.Type as ServiceType, d.DevoteeName, d.Gothram, D.AdditionalNames, d.AdditionalGothrams, p.Name as PrefixName
                                            from Tokens t 
                                            join Services s on (t.ServiceId = s.Id)
                                            left outer join Devotees d on (t.DevoteeId = d.Id)
                                            left outer join Prefixes p on (d.Prefix = p.Id)
                                            where t.Id = @0", newToken.Id);

                        savedTokens.Add(newToken);

                        tokenCounter++;
                    }
                }
            }

            return savedTokens;
        }

        public long getLeastDailyNumber(int serviceId)
        {
            using (var db = new eTempleDbDB())
            {
                var tokenObj = db.SingleOrDefault<Token>("select min(ServiceDailyNumber) as ServiceDailyNumber from Tokens where ServiceId=@0", serviceId);
                if (tokenObj != null && tokenObj.ServiceDailyNumber != null)
                {
                    return (long)tokenObj.ServiceDailyNumber;
                }
                else
                {
                    return 0;
                }
            }
        }

        public long getHighestDailyNumber(int serviceId)
        {
            using (var db = new eTempleDbDB())
            {
                var tokenObj = db.SingleOrDefault<Token>("select max(ServiceDailyNumber) as ServiceDailyNumber from Tokens where ServiceId=@0", serviceId);
                if (tokenObj != null && tokenObj.ServiceDailyNumber != null)
                {
                    return (long)tokenObj.ServiceDailyNumber;
                }
                else
                {
                    return 0;
                }
            }
        }

        public long getMaxDailyNumber(DateTime dt1)
        {
            String dt = String.Format("{0:yyyy-MM-dd}", dt1);
            using (var db = new eTempleDbDB())
            {
                var tokenObj = db.SingleOrDefault<Token>("select max(DailyNumber) as DailyNumber from Tokens where DATE(CreatedOn) like '" + dt + "'  order by Id desc LIMIT 0, 1");
                if (tokenObj != null && tokenObj.DailyNumber != null)
                {
                    return (long)tokenObj.DailyNumber;
                }
                else
                {
                    String str = string.Format("{0:yyyyMMdd}0000", DateTime.Now);
                    return Convert.ToInt64(str);
                }
            }
        }

        public List<Token> GetSelectedServiceDevotees(long startId, long endId, int serviceId)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Token>(
                @"select t.*, d.DevoteeName as DevoteeName, d.Gothram as Gothram, p.Name as PrefixName from Tokens t 
                    inner join Devotees d on (t.DevoteeId = d.Id) 
                    inner join Prefixes p on (d.Prefix = p.Id)
                    and ServiceId = @0 and (ServiceDailyNumber between @1 and @2) order by t.Id desc", serviceId, startId, endId).ToList();
            }
        }

        public List<Token> GetHundialsDetails()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Token>(
                @"select t.*, e.LoginId as Created_By from Tokens t 
                    inner join Employees e on (t.CreatedBy = e.Id) and ServiceId in (Select Id from Services where Type = 13) order by t.Id desc").ToList();
            }
        }

        public List<Token> GetMiscIncomeDetails()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Token>(
                @"select t.*, e.LoginId as Created_By from Tokens t 
                    inner join Employees e on (t.CreatedBy = e.Id) and ServiceId in (Select Id from Services where Type = 14) order by t.Id desc").ToList();
            }
        }

        public Token GetToken(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<Token>(Id);
            }
        }

        public Token getTokenById(long TokenId)
        {
            using (var db = new eTempleDbDB())
            {
                return db.FirstOrDefault<Token>(@"select t.*, s.Name as ServiceName, s.Type as ServiceTypeID, s.Type as ServiceType, d.DevoteeName, d.Gothram, d.DoorNumber, d.AreaName, d.City, d.MandalName, d.StateName, p.Name as PrefixName
                                                from Tokens t 
                                                join Services s on (t.ServiceId = s.Id)
                                                left outer join Devotees d on (t.DevoteeId = d.Id)
                                                left outer join Prefixes p on (d.Prefix = p.Id)
                                                where t.Id = @0", TokenId);
            }
        }

        public Token GetTokenWithDevoteeDetails(long TokenId)
        {
            using (var db = new eTempleDbDB())
            {
                return db.FirstOrDefault<Token>(@"select t.*, s.Name as ServiceName, s.Type as ServiceTypeID, s.Type as ServiceType, d.Prefix as PrefixId, d.EmailId as EmailId, d.DevoteeName, d.Gothram, d.DoorNumber, d.AreaName, d.City, d.MandalName, d.DistrictName, d.StateName, d.OtherDetails, d.PhoneNumber, d.AdditionalNames as AdditionalNames, d.AdditionalGothrams as AdditionalGothrams, p.Name as PrefixName, e.Loginid as Created_By, e.Name as Entered_By
                                    from Tokens t 
                                    join Services s on (t.ServiceId = s.Id)
                                    left outer join Devotees d on (t.DevoteeId = d.Id)
                                    left outer join Prefixes p on (d.Prefix = p.Id)
                                    left outer join Employees e on (e.Id = t.CreatedBy)
                                    where  t.Status=1 and t.Id = @0", TokenId);
            }
        }

        public long SaveToken(Token ps)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(ps);
                return ps.Id;
            }
        }

        public long UpdateToken(Token ps)
        {
            using (var db = new eTempleDbDB())
            {
                db.Update(ps);
                return ps.Id;
            }
        }

        public long UpdateTokenPart(DateTime ServicePerformDate, String TokenStatus, long Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update<Token>("Update Tokens set ServicePerformDate=@0, TokenStatus=@1 where Id=@2", ServicePerformDate, TokenStatus, Id);
            }
        }

        public List<Token> GetServiceReport(int ServiceId, String fldNameValue, String dtval)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Token>(@"select t.*, s.Name as ServiceName, s.Type as ServiceTypeID, s.Type as ServiceType, d.Prefix as PrefixId, d.EmailId as EmailId, d.DevoteeName, d.Gothram, d.DoorNumber, d.AreaName, d.City, d.MandalName, d.DistrictName, d.StateName, d.OtherDetails, d.PhoneNumber, d.AdditionalNames as AdditionalNames, d.AdditionalGothrams as AdditionalGothrams, p.Name as PrefixName, e.Loginid as Created_By, e.Name as Entered_By
                                    from Tokens t 
                                    join Services s on (t.ServiceId = s.Id)
                                    left outer join Devotees d on (t.DevoteeId = d.Id)
                                    left outer join Prefixes p on (d.Prefix = p.Id)
                                    left outer join Employees e on (e.Id = t.CreatedBy)
                                    where  t.Status=1 and t.ServiceId = " + ServiceId + " and DATE(t. " + fldNameValue + ") like '" + dtval + "' order by t.Id ASC").ToList();
            }
        }

        public List<Token> GetServiceReport1(int ServiceType, String fldNameValue, String dtval)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Token>(@"select t.*, s.Name as ServiceName, s.Type as ServiceTypeID, s.Type as ServiceType, d.Prefix as PrefixId, d.DevoteeName, d.Gothram,  d.AdditionalNames as AdditionalNames, d.AdditionalGothrams as AdditionalGothrams, p.Name as PrefixName
                                    from Tokens t 
                                    join Services s on (t.ServiceId = s.Id)
                                    left outer join Devotees d on (t.DevoteeId = d.Id)
                                    left outer join Prefixes p on (d.Prefix = p.Id)
                                    where s.Type = " + ServiceType + " and DATE(t. " + fldNameValue + ") like '" + dtval + "'").ToList();
            }
        }

        public int GetTimeIdCount(int TimeIdVal, int serviceId)
        {
            String dt = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
            using (var db = new eTempleDbDB())
            {
                String SqlQuery = "Select sum(Quantity) as Quantity from Tokens where TimeId = " + TimeIdVal + " and Date(ServicePerformDate) = '" + dt + "' and ServiceId='" + serviceId + "' ";
                var tokenObj = db.SingleOrDefault<Token>(SqlQuery);
                if (tokenObj != null && tokenObj.Quantity != null)
                {
                    return (int)tokenObj.Quantity; 
                }
                else
                {
                    return 0;
                }
            }
        }

        public double GEtTotalCostByTransactionType(DateTime fromDate, DateTime toDate, String tType)
        {
            var startDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day);
            var endDate = new DateTime(toDate.Year, toDate.Month, toDate.Day);

            if (startDate == endDate)
                endDate.AddDays(1);

            String strDt = String.Format("{0:yyyy-MM-dd}", startDate);
            String toDt = String.Format("{0:yyyy-MM-dd}", endDate);
            using (var db = new eTempleDbDB())
            {
                String SqlQuery = "Select sum(TotalCost) as TotalCost from Tokens where ( CreatedOn between '" + strDt + "' and '" + toDt + "' ) and TransactionType = '" + tType + "' ";
                var tokenObj = db.SingleOrDefault<Token>(SqlQuery);
                if (tokenObj != null && tokenObj.TotalCost != null)
                {
                    return (double)tokenObj.TotalCost;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
