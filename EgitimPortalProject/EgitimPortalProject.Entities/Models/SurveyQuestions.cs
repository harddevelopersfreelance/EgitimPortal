using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class SurveyQuestions : AuditableEntityBase, IEntity
    {
        public virtual int CategoryId { get; set; }
        public virtual int SurveyQuestionTypeId { get; set; }
        public virtual string Description { get; set; }
        public virtual string Sequence { get; set; }
    }
}