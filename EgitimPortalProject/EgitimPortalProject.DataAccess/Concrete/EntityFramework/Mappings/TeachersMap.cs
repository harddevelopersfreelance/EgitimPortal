using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class TeachersMap : EntityTypeConfiguration<Teachers>
{
public TeachersMap()
{
ToTable(@"Teachers", @"dbo");
HasKey(x => x.TeacherId);
Property(x => x.UserId).HasColumnName("UserId");
}
}
}

