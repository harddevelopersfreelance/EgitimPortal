using EgitimPortalProject.Core.Entities.Abstract;
using EgitimPortalProject.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;

namespace EgitimPortalProject.Core.Entities.Concrete
{
    public class User : AuditableEntityCreatedBase, IEntity//AuditableEntityBase
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public DateTime? DeletedDate { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}