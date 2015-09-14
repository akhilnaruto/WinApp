using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data
{
    public class DevoteesDao
    {
        public List<Prefix> GetAllPrefixes()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Prefix>("Select Id, Name from Prefixes").ToList();
            }
        }

        public List<Devotee> FindDevoteesByPhone(string phoneNumber)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Devotee>("SELECT * FROM Devotees where PhoneNumber = @0", phoneNumber).ToList();
            }
        }

        public List<Devotee> getPhoneNumbers(String phno)
        {
            using (var db = new eTempleDbDB())
            {
                //var cities = db.Devotees.Select(c => c.cst_City).Distinct().ToArray();
                return db.Query<Devotee>("SELECT distinct PhoneNumber FROM Devotees where PhoneNumber like '@0%' limit 0, 10 ", phno).ToList();
            }
        }

        public int Save(Devotee devotee)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(devotee);
                return devotee.Id;
            }
        }

        public int Update(Devotee devotee)
        {
            using (var db = new eTempleDbDB())
            {
                db.Update(devotee);
                return devotee.Id;
            }
        }
    }
}
