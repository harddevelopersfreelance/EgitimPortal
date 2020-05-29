using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionOptionsMap : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual int OptionId { get; set; }
    }
}