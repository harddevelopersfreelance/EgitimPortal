using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class QuestionTypesMap : EntityTypeConfiguration<QuestionTypes>
{
public QuestionTypesMap()
{
ToTable(@"QuestionTypes", @"dbo");
HasKey(x => x.Id);
Property(x => x.Description).HasColumnName("Description");
}
}
}

