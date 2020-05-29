using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class TestExamTypesMap : EntityTypeConfiguration<TestExamTypes>
{
public TestExamTypesMap()
{
ToTable(@"TestExamTypes", @"dbo");
HasKey(x => x.TestTypeId);
Property(x => x.TestTypeName).HasColumnName("TestTypeName");
}
}
}

