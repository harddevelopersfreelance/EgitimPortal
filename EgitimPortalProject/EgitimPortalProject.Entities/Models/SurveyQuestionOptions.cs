using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class SurveyQuestionOptions : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int QuestionOptionTypeId { get; set; }
        public virtual int ImageId { get; set; }
        public virtual string QuestionOptionValue { get; set; }
    }
}