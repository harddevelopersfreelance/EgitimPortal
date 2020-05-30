namespace EgitimPortalProject.Core.Entities.Abstract
{
    public interface IAuditedCreation : IHasCreationTime
    {
        int? CreatorUserId { get; set; }
    }
}