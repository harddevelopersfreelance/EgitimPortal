using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Users : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual byte[] PasswordSalt { get; set; }
        public virtual byte[] PasswordHash { get; set; }
        public virtual string Email { get; set; }
        public virtual bool Status { get; set; }
        public virtual int GenderId { get; set; }
        public virtual int LanguageId { get; set; }
        public virtual bool UserMailActivated { get; set; }
    }
}