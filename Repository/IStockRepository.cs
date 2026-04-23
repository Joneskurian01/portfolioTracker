using portfoliotracker.Models.DTOs;

namespace portfoliotracker.Repository
{
    public interface IStockRepository
    {
        Task<GetStockDto?> GetStockByIdAsync(int id);
    }
}
