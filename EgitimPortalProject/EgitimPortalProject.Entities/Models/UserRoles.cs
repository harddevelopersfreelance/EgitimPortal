using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class UserRoles : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int OperationClaimId { get; set; }
    }
}