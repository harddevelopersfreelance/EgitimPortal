using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Students : AuditableEntityBase, IEntity
    {
        public virtual int UserId { get; set; }
    }
}