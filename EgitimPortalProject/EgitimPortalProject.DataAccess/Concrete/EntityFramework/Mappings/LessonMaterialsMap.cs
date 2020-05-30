using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class LessonMaterialsMap : EntityTypeConfiguration<LessonMaterials>
{
public LessonMaterialsMap()
{
ToTable(@"LessonMaterials", @"dbo");
HasKey(x => x.MaterialId);
Property(x => x.MaterialName).HasColumnName("MaterialName");
Property(x => x.TypeId).HasColumnName("TypeId");
Property(x => x.LessonId).HasColumnName("LessonId");
Property(x => x.FilePath).HasColumnName("FilePath");
Property(x => x.AddedDate).HasColumnName("AddedDate");
Property(x => x.IsActive).HasColumnName("IsActive");
Property(x => x.DownloadCount).HasColumnName("DownloadCount");
Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
}
}
}

