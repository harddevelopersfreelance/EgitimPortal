using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Districts : AuditableEntityBase, IEntity
    {
        public virtual int CityId { get; set; }
        public virtual string Name { get; set; }
    }
}