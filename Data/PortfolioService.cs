using System;
using System.Linq;
using System.Threading.Tasks;

namespace josef.Data
{
    public class PortfolioService
    {
        private static readonly string[] Summaries = {
            "Yrkesresan", "Gymnasiedagarna", "Gymnasieantagningen Indra", "Textäventyr", "Hita rätt", "På jobbet", "Syvonline", "GRVux", "Distanspedagogik", "Praktikplatsen"
        };

        public Task<PortfolioItem[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new PortfolioItem
            {
                //StartDate = startDate.AddDays(index),
                //EndDate = startDate.AddDays(index),
                //Title = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
