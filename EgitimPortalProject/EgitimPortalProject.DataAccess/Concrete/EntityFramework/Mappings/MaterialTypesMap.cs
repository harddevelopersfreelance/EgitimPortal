using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class MaterialTypesMap : EntityTypeConfiguration<MaterialTypes>
{
public MaterialTypesMap()
{
ToTable(@"MaterialTypes", @"dbo");
HasKey(x => x.TypeId);
Property(x => x.TypeName).HasColumnName("TypeName");
}
}
}

