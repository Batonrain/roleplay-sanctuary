using Microsoft.EntityFrameworkCore;
using RoleplaySanctuary.Domain.Models.User;

namespace RoleplaySanctuary.DAL
{
    public class RoleplaySanctuaryDbContext : DbContext
    {
        public RoleplaySanctuaryDbContext(DbContextOptions<RoleplaySanctuaryDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RoleplaySanctuary;Username=admin;Password=admin");
        //}

        public DbSet<User> Users { get; set; }
        public DbSet<LoginCredential> LoginCredentials { get; set; }
    }
}