using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Permissions : AuditableEntityBase, IEntity
    {
        public virtual string Name { get; set; }
        public virtual int PermissionTypeId { get; set; }
        public virtual int RoleId { get; set; }
        public virtual int UserId { get; set; }
    }
}