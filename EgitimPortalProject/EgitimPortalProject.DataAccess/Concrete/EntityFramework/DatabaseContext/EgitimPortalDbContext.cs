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

        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User").HasKey(u => u.UserId);
            modelBuilder.Entity<Role>().ToTable("Role").HasKey(op => op.RoleId);
            //modelBuilder.Entity<UserOperationClaim>().ToTable("UserOperationClaim").HasNoKey();

            modelBuilder.Entity<UserRole>()
                .ToTable("UserRole")
                .HasKey(c => c.UserRoleId);

            modelBuilder.Entity<UserRole>()
                .HasOne<User>(sc => sc.User)
                .WithMany(s => s.UserRoles)
                .HasForeignKey(sc => sc.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne<Role>(sc => sc.Role)
                .WithMany(s => s.UserRoles)
                .HasForeignKey(sc => sc.RoleId);
        }
    }
}