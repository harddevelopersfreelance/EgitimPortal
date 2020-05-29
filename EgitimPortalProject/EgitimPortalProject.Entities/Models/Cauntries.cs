using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Cauntries : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}