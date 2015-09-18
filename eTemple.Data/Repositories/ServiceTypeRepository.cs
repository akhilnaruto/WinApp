using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data.Repositories
{
    public class ServiceTypeRepository : IRepository<ServiceType>
    {
        private eTempleDbDB TempleDb;
        public ServiceTypeRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public IEnumerable<ServiceType> GetAllAsQuerable()
        {

            return TempleDb.Query<ServiceType>("Select * From ServiceTypes order by Name asc").ToList();

        }

        public void Add(ServiceType entity)
        {
            TempleDb.Save(entity);
        }

        public void Delete(ServiceType entity)
        {
            throw new NotImplementedException();
        }

        public ServiceType FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(ServiceType entity)
        {
            TempleDb.Update(entity);
        }
    }
}
