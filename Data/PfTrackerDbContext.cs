using Microsoft.EntityFrameworkCore;

namespace portfoliotracker.Data
{
    public class PfTrackerDbContext : DbContext 
    {
        public PfTrackerDbContext(DbContextOptions options) : base(options)
        { 
        }
    }
}
