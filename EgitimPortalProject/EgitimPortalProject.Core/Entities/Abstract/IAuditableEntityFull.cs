namespace EgitimPortalProject.Core.Entities.Abstract
{
    public interface IAuditableEntityFull : IBaseEntity, IAuditableEntityCreated, IAuditableEntityModificated
    {
    }
}