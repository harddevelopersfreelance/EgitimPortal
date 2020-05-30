using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Questions : AuditableEntityBase, IEntity
    {
        public virtual int CategoryId { get; set; }
        public virtual int QuestionLevelId { get; set; }
        public virtual int QuestionTypeId { get; set; }
        public virtual string Description { get; set; }
        public virtual string Sequence { get; set; }
    }
}