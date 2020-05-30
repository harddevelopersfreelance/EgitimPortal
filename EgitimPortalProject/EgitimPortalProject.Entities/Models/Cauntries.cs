using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Cauntries : AuditableEntityBase, IEntity
    {
        public virtual string Name { get; set; }
    }
}