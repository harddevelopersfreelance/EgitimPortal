using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class SurveyQuestionsMap : EntityTypeConfiguration<SurveyQuestions>
{
public SurveyQuestionsMap()
{
ToTable(@"SurveyQuestions", @"dbo");
HasKey(x => x.Id);
Property(x => x.CategoryId).HasColumnName("CategoryId");
Property(x => x.SurveyQuestionTypeId).HasColumnName("SurveyQuestionTypeId");
Property(x => x.Description).HasColumnName("Description");
Property(x => x.Sequence).HasColumnName("Sequence");
}
}
}

