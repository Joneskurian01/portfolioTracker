using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using Microsoft.EntityFrameworkCore;
using portfoliotracker.Models.Domain;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

namespace portfoliotracker.Data
{
    public class DbSeeder
    {
        public static async Task SeedData(PfTrackerDbContext context)
        {
            if (await context.Stocks.AnyAsync()) return;

            var filePath = Path.Combine(Directory.GetCurrentDirectory(),"Data", "SeedData", "stocktickersasx.csv");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Seed data file not found at: " + filePath);
                return;
            }

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<StockSeedMap>();

            var records = csv.GetRecords<StockSeed>()
                .Select(stock => new Stock()
                {
                    Ticker = stock.Code,
                    Name = stock.Name,
                    Location = "AU"
                })
                .ToList();

            await context.Stocks.AddRangeAsync(records);
            await context.SaveChangesAsync();
        }
    }

    public class StockSeed
    {
        public StockSeed() { }

        [Name("ASX code")]
        public string Code { get; set; }

        [Name("Company name")]
        public string Name { get; set; }

        [Name("Market Cap")]
        public double MarketCap { get; set; }
    }

    public sealed class StockSeedMap : ClassMap<StockSeed>
    {
        public StockSeedMap()
        {
            Map(m => m.Code).Name("ASX code");
            Map(m => m.Name).Name("Company name");
            Map(m => m.MarketCap).Name("Market Cap");
        }
    }
}
