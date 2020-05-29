using EgitimPortalProject.Core.Entities.Abstract;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class StudentCourses : IEntity
    {
        public virtual int StudentCourseId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual DateTime PaymentDate { get; set; }
        public virtual bool IsPayment { get; set; }
    }
}