using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class DesignationDao
    {
        public List<Designation> GetAllDesignations()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<Designation>("Select * From Designations order by Name asc").ToList();
            }
        }
        
        public Designation GetDesignation(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<Designation>(Id);
            }
        }

        public void SaveDesignation(Designation designationObj)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(designationObj);
            }
        }

        public int UpdateDesignation(Designation designationObj)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update(designationObj);
            }
        }
        /*
        public int AddDesignation(String Designation)
        {
            using (var db = new eTempleDbDB())
            {
                try
                {
                    var dsg = new Designation
                    {
                        Name = Designation
                    };
                    db.Insert("Designations", "Id", dsg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return 1;
        }
        */
    }
}
