using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Students : IEntity
    {
        public virtual int StudentId { get; set; }
        public virtual int UserId { get; set; }
    }
}