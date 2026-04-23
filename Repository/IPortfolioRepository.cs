using portfoliotracker.Models.DTOs;

namespace portfoliotracker.Repository
{
    public interface IPortfolioRepository
    {
        Task<GetStockDto> GetStockAsync();
    }
}
