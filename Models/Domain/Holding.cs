using System.ComponentModel.DataAnnotations.Schema;

namespace portfoliotracker.Models.Domain
{
    public class Holding
    {
        public int Id { get; set; }
        public int PortfolioId { get; set; }
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public decimal AveragePrice { get; private set; }
        public int? TagId { get; set; }
        
        [ForeignKey("StockId")]
        public Stock Stock { get; set; }
        [ForeignKey("PortfolioId")]
        public Portfolio Portfolio { get; set; }
        [ForeignKey("TagId")]
        public Tag? Tag { get; set; }

        public void CalculateAveragePrice(List<Trade> trades)
        {
            var value = trades.Sum(t => t.Price*t.Quantity);
            var quantity = trades.Sum(t => t.Quantity);
            this.AveragePrice = (Decimal) value/ quantity;
        }
    }
}
