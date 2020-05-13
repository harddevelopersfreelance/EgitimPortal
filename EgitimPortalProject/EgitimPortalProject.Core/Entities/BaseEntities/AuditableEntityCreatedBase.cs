using EgitimPortalProject.Core.Entities.Abstract;
using System;

namespace EgitimPortalProject.Core.Entities.BaseEntities
{
    public abstract class AuditableEntityCreatedBase : IAuditableEntityCreated, IAuditableEntityBase
    {
        public int? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public int Id { get; set; }
    }
}