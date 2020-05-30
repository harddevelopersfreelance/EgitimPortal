using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class ExamTestMap : EntityTypeConfiguration<ExamTest>
{
public ExamTestMap()
{
ToTable(@"ExamTest", @"dbo");
HasKey(x => x.);
Property(x => x.Id).HasColumnName("Id");
Property(x => x.ExamTestName).HasColumnName("ExamTestName");
}
}
}

