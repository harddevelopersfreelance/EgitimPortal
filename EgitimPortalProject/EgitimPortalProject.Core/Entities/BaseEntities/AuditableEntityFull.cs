using EgitimPortalProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Core.Entities.BaseEntities
{
    public abstract class AuditableEntityFull : IAuditableEntityFull
    {
        public int Id { get; set; }
        public int? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public int? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
