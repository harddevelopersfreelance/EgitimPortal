using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class SurveyQuestionOptionsTypes : IEntity
    {
        public virtual int id { get; set; }
        public virtual string Descriptions { get; set; }
    }
}