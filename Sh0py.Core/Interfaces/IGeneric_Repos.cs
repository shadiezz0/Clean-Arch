using Shoopy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shoopy.Core.Interfaces
{
    public interface IGeneric_Repos<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);


        //Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);
        //Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[] includes = null);
        //Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take);

        //Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        //void DeleteRange(IEnumerable<T> entities);


    }
}
