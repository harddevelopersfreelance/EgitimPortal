using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Settings : AuditableEntityBase, IEntity
    {
        public virtual int UserId { get; set; }
        public virtual int RoleId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Value { get; set; }
    }
}