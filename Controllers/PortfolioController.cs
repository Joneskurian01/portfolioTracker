using Microsoft.AspNetCore.Mvc;
using portfoliotracker.Service;

namespace portfoliotracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortfolioController
    {
        private readonly IStockService _service; 

        public PortfolioController(IStockService portfolioService)
        {
            this._service = portfolioService;
        }
    }
}
