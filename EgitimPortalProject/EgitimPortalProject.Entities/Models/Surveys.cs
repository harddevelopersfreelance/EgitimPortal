using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Surveys : AuditableEntityBase, IEntity
    {
        public virtual string SurveyName { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string StartDate { get; set; }
        public virtual string EndDate { get; set; }
        public virtual string Duration { get; set; }
    }
}