using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class TeacherCourseLessons : IEntity
    {
        public virtual int TeacherCourseLessonId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual int LessonId { get; set; }
    }
}