using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class MaterialTypes : AuditableEntityBase, IEntity
    {
        public virtual string TypeName { get; set; }
    }
}