using EgitimPortalProject.Core.Entities.Abstract;
using System.Collections.Generic;

namespace EgitimPortalProject.Core.Entities.Concrete
{
    public class Roles : IEntity
    {
        public Roles()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}