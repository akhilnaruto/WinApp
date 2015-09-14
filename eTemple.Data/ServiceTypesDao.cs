using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data
{
    public class ServiceTypesDao
    {
        public List<ServiceType> GetAllServiceTypes()
        {
            using (var db = new eTempleDbDB())
            {
                return db.Query<ServiceType>("Select * From ServiceTypes order by Name asc").ToList();
            }
        }

        public ServiceType GetServiceType(int Id)
        {
            using (var db = new eTempleDbDB())
            {
                return db.SingleOrDefault<ServiceType>(Id);
            }
        }

        public void SaveServiceType(ServiceType servicetypeObj)
        {
            using (var db = new eTempleDbDB())
            {
                db.Save(servicetypeObj);
            }
        }

        public int UpdateServiceType(ServiceType servicetypeObj)
        {
            using (var db = new eTempleDbDB())
            {
                return db.Update(servicetypeObj);
            }
        }
    }
}
