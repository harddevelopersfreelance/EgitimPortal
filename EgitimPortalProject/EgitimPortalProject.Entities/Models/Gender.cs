using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Gender : AuditableEntityBase, IEntity
    {
        public virtual string GenderType { get; set; }
        public virtual string GenderIcon { get; set; }
    }
}