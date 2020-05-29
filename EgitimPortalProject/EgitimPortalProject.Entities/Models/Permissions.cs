using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Permissions : IEntity
    {
        public virtual int id { get; set; }
        public virtual string Name { get; set; }
        public virtual int PermissionTypeId { get; set; }
        public virtual int RoleId { get; set; }
        public virtual int UserId { get; set; }
    }
}