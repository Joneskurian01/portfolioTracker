using System.ComponentModel.DataAnnotations.Schema;

namespace portfoliotracker.Models.Domain
{
    public class Portfolio
    {
        public Portfolio()
        {
            this.DateCreated = DateOnly.FromDateTime(DateTime.Now);
            this.IsActive = true;
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Boolean IsActive { get; set; }
        public DateOnly DateCreated { get; private set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public Guid UserId { get; set; }
        public List<Holding> Holdings { get; set; } = new List<Holding>();
        public List<Trade> Trades { get; private set; } = new List<Trade>();
        [NotMapped]
        public Dictionary<int, List<Trade>> TradesByStockId { get; private set; } = new Dictionary<int, List<Trade>>();

        public void AddTrade(Trade NewTrade)
        {
            this.Trades.Add(NewTrade);
            var holding = this.Holdings.FirstOrDefault(h => h.StockId == NewTrade.StockId);
            
            if (holding != null)
            {
                holding.Quantity = holding.Quantity + NewTrade.Quantity;
            }
            else
            {
                holding = new Holding()
                {
                    StockId = NewTrade.StockId,
                    Quantity = NewTrade.Quantity,

                };
                this.Holdings.Add(holding);
            }

            if (holding.Quantity > 0) { 
                holding.CalculateAveragePrice(this.TradesByStockId[NewTrade.StockId]); 
            }
            else {
                this.Holdings.Remove(holding);
            }// add error handling for less than 0
        }

        public void Deactivate()
        {
            this.IsActive = false;
        }
    }
}
