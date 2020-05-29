using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class ExamQuestionMapMap : EntityTypeConfiguration<ExamQuestionMap>
{
public ExamQuestionMapMap()
{
ToTable(@"ExamQuestionMap", @"dbo");
HasKey(x => x.Id);
Property(x => x.ExamId).HasColumnName("ExamId");
Property(x => x.QuestionId).HasColumnName("QuestionId");
Property(x => x.QuestionWeigth).HasColumnName("QuestionWeigth");
}
}
}

