using EgitimPortalProject.Core.Entities.Abstract;
using EgitimPortalProject.Core.Entities.BaseEntities;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class Announcements : AuditableEntityBase, IEntity
    {
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        public virtual DateTime PublishStartDate { get; set; }
        public virtual DateTime PublishEndDate { get; set; }
        public virtual string ThumpnailId { get; set; }
        public virtual int AttachmentId { get; set; }
        public virtual bool IsShared { get; set; }
        public virtual bool IsMail { get; set; }
        public virtual bool IsNotification { get; set; }
        public virtual bool IsSms { get; set; }
    }
}