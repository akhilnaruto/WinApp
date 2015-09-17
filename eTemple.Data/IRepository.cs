using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> GetAllAsQuerable();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int Id);
    }
}
