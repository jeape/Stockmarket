using Microsoft.EntityFrameworkCore;

using StockPrices.Application.Interfaces;
using StockPrices.Application.Models;

namespace StockPrices.Infrastructure.Persistence
{
    public class StockPricesContext : DbContext, IStockPricesContext
    {
        public StockPricesContext(DbContextOptions<StockPricesContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }

        public DbSet<StockPriceDto> StockPrice { get; set; }
    }
}