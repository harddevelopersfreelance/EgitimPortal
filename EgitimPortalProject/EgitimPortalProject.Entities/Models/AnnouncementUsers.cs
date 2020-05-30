using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class AnnouncementUsers : AuditableEntityBase, IEntity
    {
        public virtual int AnnouncementId { get; set; }
        public virtual int UserId { get; set; }
    }
}