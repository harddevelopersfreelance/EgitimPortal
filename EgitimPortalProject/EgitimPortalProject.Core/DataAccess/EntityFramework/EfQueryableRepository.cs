using EgitimPortalProject.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EgitimPortalProject.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<TEntity, TContext> : IQueryableRepositoryBase<TEntity>
        where TEntity : class, IDto, new()
          where TContext : DbContext, new()
    {
        public IEnumerable<TEntity> GetByExecuteStoredProcedureQuery(string commandText, object param = null)
        {
            // cevam edilecek
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetByExecuteTextQuery(string commandText, object param = null)
        {
            throw new NotImplementedException();
        }
    }
}