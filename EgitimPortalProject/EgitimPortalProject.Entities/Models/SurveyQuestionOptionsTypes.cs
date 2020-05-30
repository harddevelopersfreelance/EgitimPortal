using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class SurveyQuestionOptionsTypes : AuditableEntityBase, IEntity
    {
        public virtual string Descriptions { get; set; }
    }
}