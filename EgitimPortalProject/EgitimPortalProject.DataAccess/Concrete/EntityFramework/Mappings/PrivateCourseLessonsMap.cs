using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class PrivateCourseLessonsMap : EntityTypeConfiguration<PrivateCourseLessons>
{
public PrivateCourseLessonsMap()
{
ToTable(@"PrivateCourseLessons", @"dbo");
HasKey(x => x.);
Property(x => x.PrivateCourseLessonsId).HasColumnName("PrivateCourseLessonsId");
}
}
}

