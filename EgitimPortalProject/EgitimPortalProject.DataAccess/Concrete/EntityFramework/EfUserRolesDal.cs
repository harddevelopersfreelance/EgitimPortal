using EgitimPortal.DataAccess.Abstract;
using EgitimPortalProject.Core.DataAccess.EntityFramework;
using EgitimPortalProject.Core.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;

namespace EgitimPortal.DataAccess.Concrete.EntityFramework
{
    public class EfUserRolesDal : EfEntityRepositoryBase<UserRoles, EgitimPortalDbContext>, IUserRolesDal
    {
    }
}