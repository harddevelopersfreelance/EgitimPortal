using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class SettingsMap : EntityTypeConfiguration<Settings>
{
public SettingsMap()
{
ToTable(@"Settings", @"dbo");
HasKey(x => x.id);
Property(x => x.UserId).HasColumnName("UserId");
Property(x => x.RoleId).HasColumnName("RoleId");
Property(x => x.Name).HasColumnName("Name");
Property(x => x.Value).HasColumnName("Value");
}
}
}

