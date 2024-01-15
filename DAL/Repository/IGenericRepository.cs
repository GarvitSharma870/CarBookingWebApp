using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IGenericRepository<T>
    {
        Task<IQueryable<T>> GetAll();
        Task<T> GetById(object id);
        Task Insert(T obj);
        Task Update(T obj, object id);
        Task Delete(object id);
        Task Save();
    }
}
