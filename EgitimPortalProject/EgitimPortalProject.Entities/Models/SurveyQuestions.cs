using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class SurveyQuestions : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int SurveyQuestionTypeId { get; set; }
        public virtual string Description { get; set; }
        public virtual string Sequence { get; set; }
    }
}