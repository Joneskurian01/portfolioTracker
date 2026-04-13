using portfoliotracker.Models.Domain;
using portfoliotracker.Models.DTOs;
using portfoliotracker.Repository;

namespace portfoliotracker.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<GetUserDto> CreateUserAsync(CreateUserDto newUser)
        {
            var user = new User()
                {
                    Name = newUser.Name,
                    Email = newUser.Email,
                    Address = newUser.Address,
                    State = newUser.State,
                    Postcode = newUser.Postcode
                };
            user.Portfolios.Add(new Portfolio()
                {
                    Name = "First Portfolio",
                    Description = "Default Portfolio"
                });

            await _userRepository.CreateUserAsync(user);
            var res = new GetUserDto()
                {   
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Address = user.Address,
                    State = user.State,
                    Postcode = user.Postcode,
                    DateCreated = user.DateCreated, 
                    DateDeleted = user.DateDeleted
                };
            return res;
        }
    }
}
