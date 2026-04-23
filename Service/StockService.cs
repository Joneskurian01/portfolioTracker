using portfoliotracker.Models.DTOs;
using portfoliotracker.Repository;

namespace portfoliotracker.Service
{
    public class StockService : IStockService
    {
        private readonly IStockRepository repository;

        public StockService(IStockRepository repository)
        {
            this.repository = repository;
        }

        public Task<GetStockDto?> GetStockByIdAsync(int id)
        {
            var res = repository.GetStockByIdAsync(id);
            if (res == null) return null;
        }
    }
}
