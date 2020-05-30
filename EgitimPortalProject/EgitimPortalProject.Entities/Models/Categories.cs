using EgitimPortalProject.Core.Entities.Abstract;

using EgitimPortalProject.Core.Entities.BaseEntities;

namespace EgitimPortal.Entities.Concrete
{
    public class Categories : AuditableEntityBase, IEntity
    {
        public virtual string CategoryName { get; set; }
    }
}