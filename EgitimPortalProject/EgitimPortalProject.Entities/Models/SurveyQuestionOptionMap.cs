using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class SurveyQuestionOptionMap : AuditableEntityBase, IEntity
    {
        public virtual int SurveyQuestionId { get; set; }
        public virtual int SurveyOptionId { get; set; }
    }
}