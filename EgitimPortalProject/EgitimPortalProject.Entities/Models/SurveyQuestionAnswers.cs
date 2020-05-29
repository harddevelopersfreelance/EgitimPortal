using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class SurveyQuestionAnswers : IEntity
    {
        public virtual int id { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual int OptionId { get; set; }
        public virtual string Value { get; set; }
    }
}