using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class CourseCategories : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int CourseId { get; set; }
        public virtual int FlagId { get; set; }
    }
}