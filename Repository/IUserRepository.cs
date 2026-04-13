using portfoliotracker.Models.Domain;
using portfoliotracker.Models.DTOs;

namespace portfoliotracker.Repository
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id);
        Task<User> CreateUserAsync(User newUser);
        Task SaveChangesAsync();


    }
}
