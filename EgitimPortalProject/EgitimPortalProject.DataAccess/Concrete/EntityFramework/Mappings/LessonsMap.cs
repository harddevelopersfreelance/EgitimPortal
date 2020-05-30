using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class LessonsMap : EntityTypeConfiguration<Lessons>
{
public LessonsMap()
{
ToTable(@"Lessons", @"dbo");
HasKey(x => x.Id);
Property(x => x.LessonName).HasColumnName("LessonName");
Property(x => x.LessonTime).HasColumnName("LessonTime");
Property(x => x.IsActive).HasColumnName("IsActive");
Property(x => x.CreatedTeacherId).HasColumnName("CreatedTeacherId");
Property(x => x.Price).HasColumnName("Price");
}
}
}

