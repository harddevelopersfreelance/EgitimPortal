using EgitimPortalProject.Core.Entities.Abstract;
using EgitimPortalProject.Core.Entities.BaseEntities;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class StudentCourses : AuditableEntityBase, IEntity
    {
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual DateTime PaymentDate { get; set; }
        public virtual bool IsPayment { get; set; }
    }
}