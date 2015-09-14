using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class UnitsDao
    {
        public List<Unit> GetAllUnits()
        {
            using (var db = new eTempleDbDB())
            {
                var units = db.Query<Unit>("Select * From Units order by Name asc").ToList();
                return units;
            }
        }

        public int AddUnit(String Unitname)
        {
            using (var db = new eTempleDbDB())
            {
                try
                {
                    var unt = new Unit
                    {
                        Name = Unitname,
                        IsDeleted = 0,
                        CreatedOn = DateTime.Now
                    };
                    db.Insert("Units", "Id", unt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 1;
        }
    }
}
