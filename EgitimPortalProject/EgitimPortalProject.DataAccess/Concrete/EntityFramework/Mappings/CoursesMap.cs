using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class CoursesMap : EntityTypeConfiguration<Courses>
{
public CoursesMap()
{
ToTable(@"Courses", @"dbo");
HasKey(x => x.CourseId);
Property(x => x.CourseName).HasColumnName("CourseName");
Property(x => x.IsActive).HasColumnName("IsActive");
Property(x => x.CreatedDate).HasColumnName("CreatedDate");
Property(x => x.CreatedUserId).HasColumnName("CreatedUserId");
Property(x => x.TeacherId).HasColumnName("TeacherId");
}
}
}

