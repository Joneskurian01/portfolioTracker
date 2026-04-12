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
        public Task<IActionResult> CreateUser([FromBody] CreateUserDto newUser)
        {

        }

        // DELETE : https://localhost:7185/user/{id}
        [HttpDelete]
        [Route("{id:guid}")]
        public Task<IActionResult> DeleteUser([FromRoute] Guid userId)
        {

        }


    }
}
