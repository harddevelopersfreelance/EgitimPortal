using EgitimPortalProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EgitimPortalProject.Core.Entities.BaseEntities
{
    public abstract class AuditableEntityBase : IAuditableEntityBase
    {
        public int Id { get; set; }
    }
}
