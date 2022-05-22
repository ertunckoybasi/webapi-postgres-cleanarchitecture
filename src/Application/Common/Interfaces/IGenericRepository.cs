using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericRepository<T> where T : class, IEntityBase
    {
        T Add(T t);
        Task<T> AddAsyn(T t);
        Task<int> CountAsync();
        Task<int> DeleteAsyn(T entity);
        T Find(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate);
        Task<T> GetAsync(int id);
        Task<ICollection<T>> GetAllAsyn();
        Task<int> SaveAsync();
        Task<T> UpdateAsyn(T t, object key);
        void Dispose();
    }
}

