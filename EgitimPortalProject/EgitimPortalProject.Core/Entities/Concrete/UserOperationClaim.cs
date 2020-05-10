using System.Collections.Generic;
using TokenProject.Core.Entities;

namespace EgitimPortalProject.Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        
        public int UserOperationClaimId { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public virtual User  User{ get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
    }
}