using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Language : IEntity
    {
        public virtual int id { get; set; }
        public virtual string Name { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string Icon { get; set; }
        public virtual bool IsDisabled { get; set; }
    }
}