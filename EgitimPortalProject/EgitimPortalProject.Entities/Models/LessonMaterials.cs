using EgitimPortalProject.Core.Entities.Abstract;
using EgitimPortalProject.Core.Entities.BaseEntities;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class LessonMaterials : AuditableEntityBase, IEntity
    {
        public virtual int MaterialId { get; set; }
        public virtual string MaterialName { get; set; }
        public virtual int TypeId { get; set; }
        public virtual int LessonId { get; set; }
        public virtual string FilePath { get; set; }
        public virtual DateTime AddedDate { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int DownloadCount { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
    }
}