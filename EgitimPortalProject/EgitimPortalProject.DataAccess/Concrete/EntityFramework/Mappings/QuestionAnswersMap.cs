using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class QuestionAnswersMap : EntityTypeConfiguration<QuestionAnswers>
{
public QuestionAnswersMap()
{
ToTable(@"QuestionAnswers", @"dbo");
HasKey(x => x.);
Property(x => x.id).HasColumnName("id");
Property(x => x.QuestionId).HasColumnName("QuestionId");
Property(x => x.OptionId).HasColumnName("OptionId");
Property(x => x.Value).HasColumnName("Value");
}
}
}

