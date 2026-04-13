using Microsoft.EntityFrameworkCore;
using portfoliotracker.Models.Domain;
using System.Formats.Asn1;
using System.Globalization;
using System.Xml;

namespace portfoliotracker.Data
{
    public class DbSeeder
    {
        public static async Task SeedData(PfTrackerDbContext context)
        {
            if (await context.Stocks.AnyAsync()) return;

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "SeedData", "stocktickersasx.csv");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Seed data file not found at: " + filePath);
                return;
            }

            var newStocks = new List<Stock>();

            var rows = File.ReadAllLines(filePath).Skip(1);

            foreach(var row in rows)
            {
                var cols = row.Split(',');

                context.Stocks.Add(new Stock
                {
                    Ticker = cols[0]+".AX",
                    Name = cols[1], 
                    Location = "AU"
                });
            }

            await context.SaveChangesAsync();
        }
    }
}
