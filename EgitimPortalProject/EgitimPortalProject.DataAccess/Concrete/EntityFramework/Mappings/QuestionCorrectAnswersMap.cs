using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class QuestionCorrectAnswersMap : EntityTypeConfiguration<QuestionCorrectAnswers>
{
public QuestionCorrectAnswersMap()
{
ToTable(@"QuestionCorrectAnswers", @"dbo");
HasKey(x => x.);
Property(x => x.Id).HasColumnName("Id");
Property(x => x.QuestionId).HasColumnName("QuestionId");
}
}
}

