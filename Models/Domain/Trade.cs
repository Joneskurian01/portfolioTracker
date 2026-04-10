namespace portfoliotracker.Models.Domain
{
    public class Trade
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
        public Stock Stock { get; set; }
    }
}
