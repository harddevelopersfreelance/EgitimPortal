using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionOptionsMap : AuditableEntityBase, IEntity
    {
        public virtual int QuestionId { get; set; }
        public virtual int OptionId { get; set; }
    }
}