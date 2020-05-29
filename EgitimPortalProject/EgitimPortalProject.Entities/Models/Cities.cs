using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Cities : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int CauntryId { get; set; }
        public virtual string Name { get; set; }
        public virtual int PlateCode { get; set; }
    }
}