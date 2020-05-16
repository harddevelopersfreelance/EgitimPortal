using EgitimPortalProject.Core.DataAccess;
using EgitimPortalProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.DataAccess.Abstract
{
   public interface IUserDal:IEntityRepositoryBase<User>
    {
        List<Role> GetClaims(User user);
    }
}
