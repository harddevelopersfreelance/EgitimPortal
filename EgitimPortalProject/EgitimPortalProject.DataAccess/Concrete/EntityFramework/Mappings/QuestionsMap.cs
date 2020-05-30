using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class QuestionsMap : EntityTypeConfiguration<Questions>
{
public QuestionsMap()
{
ToTable(@"Questions", @"dbo");
HasKey(x => x.Id);
Property(x => x.CategoryId).HasColumnName("CategoryId");
Property(x => x.QuestionLevelId).HasColumnName("QuestionLevelId");
Property(x => x.QuestionTypeId).HasColumnName("QuestionTypeId");
Property(x => x.Description).HasColumnName("Description");
Property(x => x.Sequence).HasColumnName("Sequence");
}
}
}

