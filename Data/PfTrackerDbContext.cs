using Microsoft.EntityFrameworkCore;
using portfoliotracker.Models.Domain;

namespace portfoliotracker.Data
{
    public class PfTrackerDbContext : DbContext 
    {
        public PfTrackerDbContext(DbContextOptions options) : base(options)
        { 
        }

        // ADD THESE LINES:
        public DbSet<User> Users { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Holding> Holdings { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
