using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Districts : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int CityId { get; set; }
        public virtual string Name { get; set; }
    }
}