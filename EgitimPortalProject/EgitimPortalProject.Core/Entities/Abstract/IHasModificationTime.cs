using System;

namespace EgitimPortalProject.Core.Entities.Abstract
{
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}