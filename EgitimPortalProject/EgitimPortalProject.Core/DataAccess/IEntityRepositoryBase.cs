using EgitimPortalProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EgitimPortalProject.Core.DataAccess
{
    public interface IEntityRepositoryBase<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        T Add(T entity);

        T Update(T entity);

        int Delete(T entity);

        Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null);

        Task<T> GetAsync(Expression<Func<T, bool>> filter);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<int> DeleteAsync(T entity);
    }
}