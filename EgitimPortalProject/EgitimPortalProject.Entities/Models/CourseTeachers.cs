using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class CourseTeachers : AuditableEntityBase, IEntity
    {
        public virtual int TeacherId { get; set; }
        public virtual int CourseId { get; set; }
    }
}