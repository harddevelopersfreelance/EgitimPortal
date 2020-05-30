using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionOptionTypes : AuditableEntityBase, IEntity
    {
        public virtual string Description { get; set; }
    }
}