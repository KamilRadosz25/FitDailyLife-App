using Microsoft.EntityFrameworkCore;

namespace FitDailyLife.Entities
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BodyParameters> BodyParameters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyParameters>()
                .Property(x => x.Weight)
                .IsRequired();

                
        }

    }
}
