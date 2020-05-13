using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Core.Entities.Abstract
{
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}
