using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class CourseTeachers : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int TeacherId { get; set; }
        public virtual int CourseId { get; set; }
    }
}