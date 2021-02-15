using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class TeacherCourseLessons : AuditableEntityBase, IEntity
    {
        public virtual int CourseId { get; set; }
        public virtual int LessonId { get; set; }
    }
}