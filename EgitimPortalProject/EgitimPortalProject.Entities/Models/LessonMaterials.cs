using EgitimPortalProject.Core.Entities.Abstract;
using System;

namespace EgitimPortal.Entities.Concrete
{
    public class LessonMaterials : IEntity
    {
        public virtual int MaterialId { get; set; }
        public virtual string MaterialName { get; set; }
        public virtual int TypeId { get; set; }
        public virtual int LessonId { get; set; }
        public virtual string FilePath { get; set; }
        public virtual DateTime AddedDate { get; set; }
        public virtual int IsActive { get; set; }
        public virtual int DownloadCount { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
    }
}