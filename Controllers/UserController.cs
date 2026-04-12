using Microsoft.AspNetCore.Mvc;
using portfoliotracker.Models.DTOs;

namespace portfoliotracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {

        // POST : https://localhost:7185/user
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto newUser)
        {
            return null;
        }

        // DELETE : https://localhost:7185/user/{id}
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid userId)
        {
            return null;
        }


    }
}
