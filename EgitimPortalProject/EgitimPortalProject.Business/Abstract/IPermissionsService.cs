using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IPermissionsService
    {
        List<Permissions> GetAll();

        Permissions GetById(int id);

        Permissions Add(Permissions permissions);

        Permissions Update(Permissions permissions);

        void Delete(Permissions permissions);

        List<Permissions> GetListByPermissionTypeID(int permissiontypeid);

        List<Permissions> GetListByRoleID(int roleid);

        List<Permissions> GetListByUserID(int userid);
    }
}