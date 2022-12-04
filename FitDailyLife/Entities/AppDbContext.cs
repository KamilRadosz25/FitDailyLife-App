using Microsoft.EntityFrameworkCore;

namespace FitDailyLife.Entities
{
    public class AppDbContext : DbContext
    {
        private string _connectionString = "Server=localhost;Database=FitDailyLifeDb;Trusted_Connection=True";
        public DbSet<User> Users { get; set; }
        public DbSet<BodyParameters> BodyParameters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyParameters>()
                .Property(x => x.Weight)
                .IsRequired();

                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
