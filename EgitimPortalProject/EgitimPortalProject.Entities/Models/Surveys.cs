using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Surveys : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string SurveyName { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string StartDate { get; set; }
        public virtual string EndDate { get; set; }
        public virtual string Duration { get; set; }
    }
}