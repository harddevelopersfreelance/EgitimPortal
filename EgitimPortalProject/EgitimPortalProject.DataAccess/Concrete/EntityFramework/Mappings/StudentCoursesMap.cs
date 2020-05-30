using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class StudentCoursesMap : EntityTypeConfiguration<StudentCourses>
{
public StudentCoursesMap()
{
ToTable(@"StudentCourses", @"dbo");
HasKey(x => x.StudentCourseId);
Property(x => x.StudentId).HasColumnName("StudentId");
Property(x => x.CourseId).HasColumnName("CourseId");
Property(x => x.PaymentDate).HasColumnName("PaymentDate");
Property(x => x.IsPayment).HasColumnName("IsPayment");
}
}
}

