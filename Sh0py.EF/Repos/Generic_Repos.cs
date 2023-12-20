using Microsoft.EntityFrameworkCore;
using Shoopy.Core.Interfaces;
using Shoopy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shoopy.Ef.Repos
{
    public class Generic_Repos<T> : IGeneric_Repos<T> where T : class
    {
        protected ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Generic_Repos(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }



        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }




        //public IQueryable<T> Find(Func<T, bool> fun, List<string> Includes = null)
        //{
        //    var Query = _dbSet
        //        .Where(fun)
        //        .AsQueryable();

        //    if (Includes != null)
        //        foreach (var Include in Includes)
        //        {
        //            Query = Query.Include(Include);
        //        }

        //    return Query;
        //}
    }
}