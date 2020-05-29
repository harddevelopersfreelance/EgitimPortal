using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Gender : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string GenderType { get; set; }
        public virtual string GenderIcon { get; set; }
    }
}