using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class LanguageTextMap : EntityTypeConfiguration<LanguageText>
{
public LanguageTextMap()
{
ToTable(@"LanguageText", @"dbo");
HasKey(x => x.);
Property(x => x.id).HasColumnName("id");
Property(x => x.LanguageName).HasColumnName("LanguageName");
Property(x => x.Source).HasColumnName("Source");
Property(x => x.Key).HasColumnName("Key");
Property(x => x.Value).HasColumnName("Value");
}
}
}

