﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTemple.Data.Models;

namespace eTemple.Data.Repositories
{
    public class ServiceNameRepository : IRepository<ServiceName>
    {
        private eTempleDbDB TempleDb;
        public ServiceNameRepository()
        {
            TempleDb = new eTempleDbDB();
        }

        public IEnumerable<ServiceName> GetAllAsQuerable()
        {

            return TempleDb.Query<ServiceName>("Select * From ServiceName order by Name asc").ToList();

        }

        public void Add(ServiceName entity)
        {
            TempleDb.Save(entity);
        }

        public void Delete(ServiceName entity)
        {
            throw new NotImplementedException();
        }

        public ServiceName FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(ServiceName entity)
        {
            TempleDb.Update(entity);
        }
    }
}