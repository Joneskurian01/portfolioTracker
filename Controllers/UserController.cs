using Microsoft.AspNetCore.Mvc;
using portfoliotracker.Models.Domain;
using portfoliotracker.Models.DTOs;
using portfoliotracker.Service;

namespace portfoliotracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

    
        // POST : https://localhost:7185/user
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto newUser)
        {
            var user = await _userService.CreateUserAsync(newUser);
            return Ok(user);

        }

        // DELETE : https://localhost:7185/user/{id}
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> SoftDeleteUser([FromRoute] Guid userId)
        {
            var res = await _userService.SoftDeleteUserByIdAsync(userId);
            return res?
                NoContent(): 
                BadRequest("User could not be deleted. The user may not exist or is already inactive.");
        }


    }
}
