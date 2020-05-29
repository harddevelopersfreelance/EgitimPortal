using EgitimPortalProject.Core.DataAccess.EntityFramework;
using EgitimPortalProject.Core.Entities.Concrete;
using EgitimPortalProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;

namespace EgitimPortalProject.DataAccess.Concrete.EntityFramework
{
    public class UserDal : EfEntityRepository<User, EgitimPortalDbContext>, IUserDal
    {
        public List<Role> GetClaims(User user)
        {
            using (var context = new EgitimPortalDbContext())
            {
                var result = from role in context.Roles
                             join userRole in context.UserRoles
                                 on role.RoleId equals userRole.RoleId
                             where userRole.UserId == user.Id
                             select new Role { RoleId = role.RoleId, RoleName = role.RoleName };
                return result.ToList();

            }
        }
    }
}
