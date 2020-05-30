using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionCorrectAnswers : AuditableEntityBase, IEntity
    {
        public virtual int QuestionId { get; set; }
    }
}