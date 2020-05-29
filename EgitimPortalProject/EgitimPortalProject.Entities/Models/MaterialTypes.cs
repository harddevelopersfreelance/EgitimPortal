using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class MaterialTypes : IEntity
    {
        public virtual int TypeId { get; set; }
        public virtual string TypeName { get; set; }
    }
}