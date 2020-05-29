using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class LessonCategories : IEntity
    {
        public virtual int LessonCategoryId { get; set; }
        public virtual int LessonID { get; set; }
        public virtual int CategoryId { get; set; }
    }
}