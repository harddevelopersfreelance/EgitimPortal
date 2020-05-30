using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class TeacherCourseLessonsMap : EntityTypeConfiguration<TeacherCourseLessons>
{
public TeacherCourseLessonsMap()
{
ToTable(@"TeacherCourseLessons", @"dbo");
HasKey(x => x.TeacherCourseLessonId);
Property(x => x.CourseId).HasColumnName("CourseId");
Property(x => x.LessonId).HasColumnName("LessonId");
}
}
}

