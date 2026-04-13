using portfoliotracker.Models.Domain;
using portfoliotracker.Models.DTOs;

namespace portfoliotracker.Service
{
    public interface IUserService
    {
        Task<GetUserDto> CreateUserAsync(CreateUserDto userDto);
        Task<Boolean> SoftDeleteUserByIdAsync(Guid id);
    }
}
