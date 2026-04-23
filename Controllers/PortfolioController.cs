using Microsoft.AspNetCore.Mvc;
using portfoliotracker.Service;

namespace portfoliotracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortfolioController
    {
        private readonly IPortfolioService _service; 

        public PortfolioController(IPortfolioService portfolioService)
        {
            this._service = portfolioService;
        }
    }
}
