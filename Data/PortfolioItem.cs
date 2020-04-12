using System;

namespace josef.Data
{
    public class PortfolioItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Duration => StartDate.Subtract(EndDate).TotalDays;
    }
}
