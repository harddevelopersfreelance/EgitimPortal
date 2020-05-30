using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class CategoriesMap : EntityTypeConfiguration<Categories>
{
public CategoriesMap()
{
ToTable(@"Categories", @"dbo");
HasKey(x => x.FlagId);
Property(x => x.FlagName).HasColumnName("FlagName");
}
}
}

