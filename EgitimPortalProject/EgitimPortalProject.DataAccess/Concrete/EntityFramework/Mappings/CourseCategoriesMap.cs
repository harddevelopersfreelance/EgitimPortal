using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class CourseCategoriesMap : EntityTypeConfiguration<CourseCategories>
{
public CourseCategoriesMap()
{
ToTable(@"CourseCategories", @"dbo");
HasKey(x => x.Id);
Property(x => x.CourseId).HasColumnName("CourseId");
Property(x => x.FlagId).HasColumnName("FlagId");
}
}
}

