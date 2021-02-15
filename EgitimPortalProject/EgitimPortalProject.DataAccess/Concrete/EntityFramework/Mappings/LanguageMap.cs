using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class LanguageMap : EntityTypeConfiguration<Language>
{
public LanguageMap()
{
ToTable(@"Language", @"dbo");
HasKey(x => x.id);
Property(x => x.Name).HasColumnName("Name");
Property(x => x.DisplayName).HasColumnName("DisplayName");
Property(x => x.Icon).HasColumnName("Icon");
Property(x => x.IsDisabled).HasColumnName("IsDisabled");
}
}
}

