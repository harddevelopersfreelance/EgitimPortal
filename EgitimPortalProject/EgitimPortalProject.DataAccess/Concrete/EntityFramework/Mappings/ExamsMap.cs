using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class ExamsMap : EntityTypeConfiguration<Exams>
{
public ExamsMap()
{
ToTable(@"Exams", @"dbo");
HasKey(x => x.Id);
Property(x => x.TestName).HasColumnName("TestName");
Property(x => x.Title).HasColumnName("Title");
Property(x => x.Description).HasColumnName("Description");
Property(x => x.StartDate).HasColumnName("StartDate");
Property(x => x.EndDate).HasColumnName("EndDate");
Property(x => x.Duration).HasColumnName("Duration");
Property(x => x.IsActive).HasColumnName("IsActive");
Property(x => x.CreatedDate).HasColumnName("CreatedDate");
Property(x => x.ExamTypeId).HasColumnName("ExamTypeId");
Property(x => x.DeletedDate).HasColumnName("DeletedDate");
}
}
}

