using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionOptions : IEntity
    {
        public virtual int QuestionOptionId { get; set; }
        public virtual int QuestionOptionTypeId { get; set; }
        public virtual string ImageId { get; set; }
        public virtual string isCorrect { get; set; }
        public virtual string QuestionOptionValue { get; set; }
    }
}