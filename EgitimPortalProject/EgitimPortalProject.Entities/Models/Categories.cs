using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortal.Entities.Concrete
{
    public class Categories : IEntity
    {
        public virtual int FlagId { get; set; }
        public virtual string FlagName { get; set; }
    }
}