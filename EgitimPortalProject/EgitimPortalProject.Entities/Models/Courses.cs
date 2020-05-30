using EgitimPortalProject.Core.Entities.Abstract;
using EgitimPortalProject.Core.Entities.BaseEntities;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class Courses : AuditableEntityBase, IEntity
    {
        public virtual string CourseName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual int CreatedUserId { get; set; }
        public virtual int TeacherId { get; set; }
    }
}