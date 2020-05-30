using EgitimPortalProject.Core.Entities.Abstract;
using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortalProject.Core.Entities.Concrete
{
    public class UserRoles : AuditableEntityBase, IEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual Users User { get; set; }
        public virtual Roles Role { get; set; }
    }
}