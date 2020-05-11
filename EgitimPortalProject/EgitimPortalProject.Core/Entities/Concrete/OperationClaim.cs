using EgitimPortalProject.Core.Entities.Abstract;
using System.Collections.Generic;

namespace EgitimPortalProject.Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public OperationClaim()
        {
            UserOperationClaims = new HashSet<UserOperationClaim>();
        }

        public int OperationClaimId { get; set; }
        public string OperationClaimName { get; set; }

        public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}