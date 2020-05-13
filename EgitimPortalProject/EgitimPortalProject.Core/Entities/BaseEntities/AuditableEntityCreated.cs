using EgitimPortalProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Core.Entities.BaseEntities
{
    public abstract class AuditableEntityCreated : IAuditableEntityCreated
    {
        public int? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
