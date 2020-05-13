using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortalProject.Core.Entities.Concrete
{
    public class UserRole : IEntity
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}