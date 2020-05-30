using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class SurveyQuestionOptionsTypesMap : EntityTypeConfiguration<SurveyQuestionOptionsTypes>
{
public SurveyQuestionOptionsTypesMap()
{
ToTable(@"SurveyQuestionOptionsTypes", @"dbo");
HasKey(x => x.id);
Property(x => x.Descriptions).HasColumnName("Descriptions");
}
}
}

