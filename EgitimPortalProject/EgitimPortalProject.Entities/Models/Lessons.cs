using EgitimPortalProject.Core.Entities.Abstract;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class Lessons : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string LessonName { get; set; }
        public virtual DateTime LessonTime { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int CreatedTeacherId { get; set; }
        public virtual decimal Price { get; set; }
    }
}