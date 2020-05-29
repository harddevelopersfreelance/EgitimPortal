using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Settings : IEntity
    {
        public virtual int id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int RoleId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Value { get; set; }
    }
}