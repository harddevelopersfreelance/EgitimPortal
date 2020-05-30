using EgitimPortalProject.Core.Entities.Abstract;
using EgitimPortalProject.Core.Entities.BaseEntities;
using System.Collections.Generic;

namespace EgitimPortalProject.Core.Entities.Concrete
{
    public class Roles : AuditableEntityBase, IEntity

    {
        public Roles()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public string RoleName { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}