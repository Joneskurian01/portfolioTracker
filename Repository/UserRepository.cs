using Microsoft.EntityFrameworkCore;
using portfoliotracker.Data;
using portfoliotracker.Models.Domain;
using portfoliotracker.Models.DTOs;

namespace portfoliotracker.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PfTrackerDbContext _context;
        public UserRepository(PfTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            return await _context.Users
                .Include(u => u.Portfolios)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> CreateUserAsync(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
