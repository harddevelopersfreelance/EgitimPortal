using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class AnnouncementUsers : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int AnnouncementId { get; set; }
        public virtual int UserId { get; set; }
    }
}