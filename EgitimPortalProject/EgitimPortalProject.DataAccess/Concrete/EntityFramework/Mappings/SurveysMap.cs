using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class SurveysMap : EntityTypeConfiguration<Surveys>
{
public SurveysMap()
{
ToTable(@"Surveys", @"dbo");
HasKey(x => x.);
Property(x => x.Id).HasColumnName("Id");
Property(x => x.SurveyName).HasColumnName("SurveyName");
Property(x => x.Title).HasColumnName("Title");
Property(x => x.Description).HasColumnName("Description");
Property(x => x.StartDate).HasColumnName("StartDate");
Property(x => x.EndDate).HasColumnName("EndDate");
Property(x => x.Duration).HasColumnName("Duration");
}
}
}

