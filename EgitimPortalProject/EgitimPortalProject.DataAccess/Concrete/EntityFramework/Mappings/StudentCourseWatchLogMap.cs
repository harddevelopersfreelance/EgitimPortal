using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class StudentCourseWatchLogMap : EntityTypeConfiguration<StudentCourseWatchLog>
{
public StudentCourseWatchLogMap()
{
ToTable(@"StudentCourseWatchLog", @"dbo");
HasKey(x => x.);
Property(x => x.StudentCourseWatchLog).HasColumnName("StudentCourseWatchLog");
Property(x => x.Student).HasColumnName("Student");
}
}
}

