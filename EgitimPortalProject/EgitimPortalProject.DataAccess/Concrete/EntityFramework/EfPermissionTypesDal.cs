using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.Core.DataAccess.EntityFramework;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;

namespace EgitimPortal.DataAccess.Concrete.EntityFramework
{
    public class EfPermissionTypesDal : EfEntityRepositoryBase<PermissionTypes, EgitimPortalDbContext>, IPermissionTypesDal
    {
    }
}