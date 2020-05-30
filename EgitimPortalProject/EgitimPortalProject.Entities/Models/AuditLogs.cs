using EgitimPortalProject.Core.Entities.Abstract;
using EgitimPortalProject.Core.Entities.BaseEntities;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class AuditLogs : AuditableEntityBase, IEntity
    {
        public virtual int UserId { get; set; }
        public virtual string ServiceName { get; set; }
        public virtual string MethodName { get; set; }
        public virtual string Parameters { get; set; }
        public virtual string ReturnValue { get; set; }
        public virtual DateTime ExecutionTime { get; set; }
        public virtual int ExecutionDuration { get; set; }
        public virtual string ClientIpAddress { get; set; }
        public virtual string BrowserInfo { get; set; }
        public virtual string Exception { get; set; }
    }
}