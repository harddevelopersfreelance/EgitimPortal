using EgitimPortalProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Core.Entities.BaseEntities
{
    public abstract class AuditableEntityModificated : IAuditableEntityModificated
    {
        public int? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
