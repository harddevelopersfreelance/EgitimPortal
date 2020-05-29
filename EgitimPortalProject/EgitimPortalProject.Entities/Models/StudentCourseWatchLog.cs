using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class StudentCourseWatchLog : IEntity
    {
        public virtual int StudentCourseWatchLogId { get; set; }
        public virtual string Student { get; set; }
    }
}