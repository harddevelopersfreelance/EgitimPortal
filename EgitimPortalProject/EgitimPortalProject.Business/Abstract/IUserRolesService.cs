using EgitimPortalProject.Core.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IUserRolesService
    {
        List<UserRoles> GetAll();

        UserRoles GetById(int id);

        UserRoles Add(UserRoles userroles);

        UserRoles Update(UserRoles userroles);

        void Delete(UserRoles userroles);

        List<UserRoles> GetListByUserID(int userid);

        List<UserRoles> GetListByRoleIdID(int operationclaimid);
    }
}