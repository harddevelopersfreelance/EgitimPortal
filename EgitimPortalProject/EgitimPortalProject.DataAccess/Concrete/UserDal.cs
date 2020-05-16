using EgitimPortalProject.Core.DataAccess.EntityFramework;
using EgitimPortalProject.Core.Entities.Concrete;
using EgitimPortalProject.DataAccess.Abstract;
using EgitimPortalProject.DataAccess.Concrete.EntityFramework.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EgitimPortalProject.DataAccess.Concrete
{
    public class UserDal : EfEntityRepository<User, EgitimPortalDbContext>, IUserDal
    {
        public List<Role> GetClaims(User user)
        {
            using (var context = new EgitimPortalDbContext())
            {
                var result = from role in context.Role
                             join userRole in context.UserRole
                                 on role.RoleId equals userRole.RoleId
                             where userRole.UserId == user.Id
                             select new Role { RoleId = role.RoleId, RoleName = role.RoleName };
                return result.ToList();

            }
        }
    }
}
