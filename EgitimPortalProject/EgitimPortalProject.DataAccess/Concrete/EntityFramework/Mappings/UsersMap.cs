using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;   namespace EgitimPortal.DataAccess.Concrete.EntityFramework  .Mappings
{
public class UsersMap : EntityTypeConfiguration<Users>
{
public UsersMap()
{
ToTable(@"Users", @"dbo");
HasKey(x => x.Id);
Property(x => x.FirstName).HasColumnName("FirstName");
Property(x => x.LastName).HasColumnName("LastName");
Property(x => x.PasswordSalt).HasColumnName("PasswordSalt");
Property(x => x.PasswordHash).HasColumnName("PasswordHash");
Property(x => x.Email).HasColumnName("Email");
Property(x => x.Status).HasColumnName("Status");
Property(x => x.GenderId).HasColumnName("GenderId");
Property(x => x.LanguageId).HasColumnName("LanguageId");
Property(x => x.UserMailActivated).HasColumnName("UserMailActivated");
}
}
}

