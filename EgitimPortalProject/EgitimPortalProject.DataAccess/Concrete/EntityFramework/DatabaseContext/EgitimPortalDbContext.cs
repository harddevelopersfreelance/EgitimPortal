using EgitimPortalProject.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
namespace EgitimPortalProject.DataAccess.Concrete.EntityFramework.DatabaseContext
{
    public class EgitimPortalDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=EgitimPortalTest;Trusted_Connection=True;");
            }
        }

         public virtual DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public virtual DbSet<OperationClaim> OperationClaims { get; set; }
        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User").HasNoKey();
            modelBuilder.Entity<OperationClaim>().ToTable("OperationClaim").HasNoKey();
            modelBuilder.Entity<UserOperationClaim>().ToTable("UserOperationClaim").HasNoKey();
        }



    }
}
