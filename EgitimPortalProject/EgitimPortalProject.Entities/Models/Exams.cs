using EgitimPortalProject.Core.Entities.Abstract;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class Exams : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string TestName { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual string Duration { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual int ExamTypeId { get; set; }
        public virtual DateTime DeletedDate { get; set; }
    }
}