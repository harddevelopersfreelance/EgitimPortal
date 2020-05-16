using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Entities.Entities.Concrete
{
    public class User : IEntity
    {
        
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool? Status { get; set; }
        public DateTime DeletedDate { get; set; }
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public int? CreatorUserId { get; set; }


    }
}
