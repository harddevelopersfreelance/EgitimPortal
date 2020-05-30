using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class SurveyQuestionOptionsMap : EntityTypeConfiguration<SurveyQuestionOptions>
{
public SurveyQuestionOptionsMap()
{
ToTable(@"SurveyQuestionOptions", @"dbo");
HasKey(x => x.Id);
Property(x => x.QuestionOptionTypeId).HasColumnName("QuestionOptionTypeId");
Property(x => x.ImageId).HasColumnName("ImageId");
Property(x => x.QuestionOptionValue).HasColumnName("QuestionOptionValue");
}
}
}

