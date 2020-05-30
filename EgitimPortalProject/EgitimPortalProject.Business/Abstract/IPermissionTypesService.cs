using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IPermissionTypesService
    {
        List<PermissionTypes> GetAll();

        PermissionTypes GetById(int id);

        PermissionTypes Add(PermissionTypes permissiontypes);

        PermissionTypes Update(PermissionTypes permissiontypes);

        void Delete(PermissionTypes permissiontypes);
    }
}