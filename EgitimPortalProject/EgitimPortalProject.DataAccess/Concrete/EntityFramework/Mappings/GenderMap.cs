using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class GenderMap : EntityTypeConfiguration<Gender>
{
public GenderMap()
{
ToTable(@"Gender", @"dbo");
HasKey(x => x.Id);
Property(x => x.GenderType).HasColumnName("GenderType");
Property(x => x.GenderIcon).HasColumnName("GenderIcon");
}
}
}

