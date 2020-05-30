using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class StudentCourseWatchLog : AuditableEntityBase, IEntity
    {
        public virtual string Student { get; set; }
    }
}