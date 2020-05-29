using EgitimPortalProject.Core.Entities.Abstract;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class Courses : IEntity
    {
        public virtual int CourseId { get; set; }
        public virtual string CourseName { get; set; }
        public virtual DateTime IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual int CreatedUserId { get; set; }
        public virtual int TeacherId { get; set; }
    }
}