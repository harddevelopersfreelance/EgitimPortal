using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class CourseCategories : AuditableEntityBase, IEntity
    {
        public virtual int CourseId { get; set; }
        public virtual int FlagId { get; set; }
    }
}