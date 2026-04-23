using portfoliotracker.Repository;

namespace portfoliotracker.Service
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository repository;

        public PortfolioService(IPortfolioRepository repository)
        {
            this.repository = repository;
        }
    }
}
