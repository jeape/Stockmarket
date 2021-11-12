using Microsoft.EntityFrameworkCore;

using StockMarket.Domain.Entities;
using StockMarket.Application.Interfaces;
using StockMarket.Application.Models;

namespace StockMarket.Infrastructure.Persistence
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