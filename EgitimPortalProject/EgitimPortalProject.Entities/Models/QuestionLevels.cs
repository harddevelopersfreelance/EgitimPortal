using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionLevels : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
    }
}