using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class SurveyQuestionAnswersMap : EntityTypeConfiguration<SurveyQuestionAnswers>
{
public SurveyQuestionAnswersMap()
{
ToTable(@"SurveyQuestionAnswers", @"dbo");
HasKey(x => x.id);
Property(x => x.QuestionId).HasColumnName("QuestionId");
Property(x => x.OptionId).HasColumnName("OptionId");
Property(x => x.Value).HasColumnName("Value");
}
}
}

