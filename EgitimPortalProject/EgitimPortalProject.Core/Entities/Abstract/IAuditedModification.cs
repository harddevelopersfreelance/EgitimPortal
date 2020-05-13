namespace EgitimPortalProject.Core.Entities.Abstract
{
    public interface IAuditedModification : IHasModificationTime
    {
        int? LastModifierUserId { get; set; }
    }
}