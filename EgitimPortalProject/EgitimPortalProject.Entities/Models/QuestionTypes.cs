using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionTypes : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
    }
}