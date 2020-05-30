using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class QuestionOptionsMap : EntityTypeConfiguration<QuestionOptions>
{
public QuestionOptionsMap()
{
ToTable(@"QuestionOptions", @"dbo");
HasKey(x => x.QuestionOptionId);
Property(x => x.QuestionOptionTypeId).HasColumnName("QuestionOptionTypeId");
Property(x => x.ImageId).HasColumnName("ImageId");
Property(x => x.isCorrect).HasColumnName("isCorrect");
Property(x => x.QuestionOptionValue).HasColumnName("QuestionOptionValue");
}
}
}

