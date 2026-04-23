using portfoliotracker.Models.DTOs;

namespace portfoliotracker.Service
{
    public interface IStockService
    {

        Task<GetStockDto?> GetStockByIdAsync(int id);
    }
}
