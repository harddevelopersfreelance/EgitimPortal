using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Cities : AuditableEntityBase, IEntity
    {
        public virtual int CauntryId { get; set; }
        public virtual string Name { get; set; }
        public virtual int PlateCode { get; set; }
    }
}