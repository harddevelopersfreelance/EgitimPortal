using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class LessonCategories : AuditableEntityBase, IEntity
    {
        public virtual int LessonID { get; set; }
        public virtual int CategoryId { get; set; }
    }
}