using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class QuestionLevels : AuditableEntityBase, IEntity
    {
        public virtual string Description { get; set; }
    }
}