using EgitimPortalProject.Core.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IRolesService
    {
        List<Roles> GetAll();

        Roles GetById(int id);

        Roles Add(Roles roles);

        Roles Update(Roles roles);

        void Delete(Roles roles);
    }
}