using System;

namespace EgitimPortalProject.Core.Entities.Abstract
{
    public interface IHasCreationTime
    {
        DateTime CreationTime { get; set; }
    }
}