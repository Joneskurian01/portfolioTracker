using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using portfoliotracker.Data;

namespace portfoliotracker.Repository
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly PfTrackerDbContext _context;
        public PortfolioRepository(PfTrackerDbContext context) {
            this._context = context;
        }
    }
}
