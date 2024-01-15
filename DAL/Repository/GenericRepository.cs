using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected CarBookingDBContext _context = null;
        protected DbSet<T> table = null;

        public GenericRepository(CarBookingDBContext _context)
        {
            this._context = _context;
            this.table = _context.Set<T>();
        }
        public async Task<IQueryable<T>> GetAll()
        {
            return table.AsQueryable();
        }
        public async Task<T> GetById(object id)
        {
            return await table.FindAsync(id);
        }
        public async Task Insert(T obj)
        {
            await table.AddAsync(obj);
        }
        public async Task Update(T obj, object id)
        {
            var exist = await table.FindAsync(id);
            if (exist != null)
            {
                _context.Entry(exist).State = EntityState.Detached;
                table.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
            }

        }
        public async Task Delete(object id)
        {
            T exist = await table.FindAsync(id);
            if (exist != null)
            {
                table.Remove(exist);
            }

        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
