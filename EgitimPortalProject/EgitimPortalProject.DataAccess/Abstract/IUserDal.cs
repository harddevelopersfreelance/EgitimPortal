using EgitimPortalProject.Core.DataAccess;
using EgitimPortalProject.Core.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortalProject.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepositoryBase<Users>
    {
        List<Roles> GetClaims(Users user);
    }
}