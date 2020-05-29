using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortalProject.Core.Entities.Concrete
{
    public class UserRoles : IEntity
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual Users User { get; set; }
        public virtual Roles Role { get; set; }
    }
}