using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionAnswers : AuditableEntityBase, IEntity
    {
        public virtual int QuestionId { get; set; }
        public virtual int OptionId { get; set; }
        public virtual string Value { get; set; }
    }
}