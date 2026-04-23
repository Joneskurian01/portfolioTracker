using portfoliotracker.Models.DTOs;

namespace portfoliotracker.Service
{
    public interface IPortfolioService
    {

        Task<GetStockDto> GetStockAsync();
    }
}
