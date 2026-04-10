namespace portfoliotracker.Models.Domain
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PortfolioId { get; set; }

    }
}