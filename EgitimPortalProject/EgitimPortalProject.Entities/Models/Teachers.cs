using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Teachers : IEntity
    {
        public virtual int TeacherId { get; set; }
        public virtual int UserId { get; set; }
    }
}