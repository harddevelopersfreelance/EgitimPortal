using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortalProject.Core.Entities.BaseEntities
{
    public abstract class AuditableEntityBase : IAuditableEntityBase
    {
        public int Id { get; set; }
    }
}