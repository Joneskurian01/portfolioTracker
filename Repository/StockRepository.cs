using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using portfoliotracker.Data;
using portfoliotracker.Models.DTOs;

namespace portfoliotracker.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly PfTrackerDbContext _context;
        public StockRepository(PfTrackerDbContext context) {
            this._context = context;
        }

        public async Task<GetStockDto?> GetStockByIdAsync(int id)
        {
            var res = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);

            if (res == null) return null;

            return new GetStockDto()
            {
                Name = res.Name,
                Ticker = res.Ticker,
            };
        }
    }
}
