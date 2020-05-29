using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionCorrectAnswers : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int QuestionId { get; set; }
    }
}