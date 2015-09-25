using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data.Repositories
{
    public class ServiceTypeRepository : IRepository<ServiceTypes>
    {
        private eTempleDbDB TempleDb;
        public ServiceTypeRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public IEnumerable<ServiceTypes> GetAllAsQuerable()
        {

            return TempleDb.Query<ServiceTypes>("Select * From ServiceTypes order by Id asc").ToList();

        }


        public IEnumerable<ServiceTypes> GetAllAsQuerable(int serviceTypeId)
        {

            return TempleDb.Query<ServiceTypes>("Select * From ServiceTypes where Id = " + serviceTypeId + " order by Name asc").ToList();

        }

        public void Add(ServiceTypes entity)
        {
            TempleDb.Save(entity);
        }

        public void Delete(ServiceTypes entity)
        {
            throw new NotImplementedException();
        }

        public ServiceTypes FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(ServiceTypes entity)
        {
            TempleDb.Update(entity);
        }
    }
}
