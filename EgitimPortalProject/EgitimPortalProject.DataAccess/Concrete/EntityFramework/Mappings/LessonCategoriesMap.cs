using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class LessonCategoriesMap : EntityTypeConfiguration<LessonCategories>
{
public LessonCategoriesMap()
{
ToTable(@"LessonCategories", @"dbo");
HasKey(x => x.);
Property(x => x.LessonCategoryId).HasColumnName("LessonCategoryId");
Property(x => x.LessonID).HasColumnName("LessonID");
Property(x => x.CategoryId).HasColumnName("CategoryId");
}
}
}

