using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Language : AuditableEntityBase, IEntity
    {
        public virtual string Name { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string Icon { get; set; }
        public virtual bool IsActive { get; set; }
    }
}