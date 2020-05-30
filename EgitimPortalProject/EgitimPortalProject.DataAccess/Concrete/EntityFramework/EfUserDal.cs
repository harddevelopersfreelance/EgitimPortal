using EgitimPortalProject.Core.DataAccess.EntityFramework;
using EgitimPortalProject.Core.Entities.Concrete;
using EgitimPortalProject.DataAccess.Abstract;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace EgitimPortalProject.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<Users, EgitimPortalDbContext>, IUserDal
    {
        public List<Roles> GetClaims(Users user)
        {
            using (var context = new EgitimPortalDbContext())
            {
                var result = from role in context.Roles
                             join userRole in context.UserRoles
                                 on role.Id equals userRole.RoleId
                             where userRole.UserId == user.Id
                             select new Roles { Id = role.Id, RoleName = role.RoleName };
                return result.ToList();
            }
        }
    }
}