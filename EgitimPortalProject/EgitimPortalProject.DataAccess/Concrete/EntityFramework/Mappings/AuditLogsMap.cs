using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class AuditLogsMap : EntityTypeConfiguration<AuditLogs>
{
public AuditLogsMap()
{
ToTable(@"AuditLogs", @"dbo");
HasKey(x => x.id);
Property(x => x.UserId).HasColumnName("UserId");
Property(x => x.ServiceName).HasColumnName("ServiceName");
Property(x => x.MethodName).HasColumnName("MethodName");
Property(x => x.Parameters).HasColumnName("Parameters");
Property(x => x.ReturnValue).HasColumnName("ReturnValue");
Property(x => x.ExecutionTime).HasColumnName("ExecutionTime");
Property(x => x.ExecutionDuration).HasColumnName("ExecutionDuration");
Property(x => x.ClientIpAddress).HasColumnName("ClientIpAddress");
Property(x => x.BrowserInfo).HasColumnName("BrowserInfo");
Property(x => x.Exception).HasColumnName("Exception");
}
}
}

