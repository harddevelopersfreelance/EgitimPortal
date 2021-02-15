using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class SurveyQuestionOptions : AuditableEntityBase, IEntity
    {
        public virtual int QuestionOptionTypeId { get; set; }
        public virtual int ImageId { get; set; }
        public virtual string QuestionOptionValue { get; set; }
    }
}