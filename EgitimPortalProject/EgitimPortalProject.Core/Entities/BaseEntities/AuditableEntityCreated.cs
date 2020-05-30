using EgitimPortalProject.Core.Entities.Abstract;
using System;

namespace EgitimPortalProject.Core.Entities.BaseEntities
{
    public abstract class AuditableEntityCreated : IAuditableEntityCreated
    {
        public int? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}