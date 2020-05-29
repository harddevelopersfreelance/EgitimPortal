using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class PermissionTypes : IEntity
    {
        public virtual int id { get; set; }
        public virtual string Description { get; set; }
    }
}