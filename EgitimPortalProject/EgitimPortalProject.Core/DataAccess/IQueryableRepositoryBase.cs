using EgitimPortalProject.Core.Entities.Abstract;
using System.Collections.Generic;

namespace EgitimPortalProject.Core.DataAccess
{
    public interface IQueryableRepositoryBase<T> where T : class, IDto, new()
    {
        IEnumerable<T> GetByExecuteTextQuery(string commandText, object param = null);

        IEnumerable<T> GetByExecuteStoredProcedureQuery(string commandText, object param = null);
    }
}