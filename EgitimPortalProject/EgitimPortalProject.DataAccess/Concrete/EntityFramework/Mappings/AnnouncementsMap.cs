using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext;

namespace EgitimPortal.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AnnouncementsMap : EntityTypeConfiguration<Announcements>
    {
        public AnnouncementsMap()
        {
            ToTable(@"Announcements", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.Title).HasColumnName("Title");
            Property(x => x.Content).HasColumnName("Content");
            Property(x => x.PublishStartDate).HasColumnName("PublishStartDate");
            Property(x => x.PublishEndDate).HasColumnName("PublishEndDate");
            Property(x => x.ThumpnailId).HasColumnName("ThumpnailId");
            Property(x => x.AttachmentId).HasColumnName("AttachmentId");
            Property(x => x.IsShared).HasColumnName("IsShared");
            Property(x => x.IsMail).HasColumnName("IsMail");
            Property(x => x.IsNotification).HasColumnName("IsNotification");
            Property(x => x.IsSms).HasColumnName("IsSms");
        }
    }
}

