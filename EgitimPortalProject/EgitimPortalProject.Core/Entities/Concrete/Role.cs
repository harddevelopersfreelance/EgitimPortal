using EgitimPortalProject.Core.Entities.Abstract;
using System.Collections.Generic;

namespace EgitimPortalProject.Core.Entities.Concrete
{
    public class Role : IEntity
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}