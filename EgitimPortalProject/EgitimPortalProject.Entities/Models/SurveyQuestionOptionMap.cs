using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class SurveyQuestionOptionMap : IEntity
    {
        public virtual int id { get; set; }
        public virtual int SurveyQuestionId { get; set; }
        public virtual int SurveyOptionId { get; set; }
    }
}