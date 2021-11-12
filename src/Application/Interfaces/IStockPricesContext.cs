using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockMarket.Domain.Entities;
using StockMarket.Application.Models;

namespace StockMarket.Application.Interfaces
{
    public interface IStockPricesContext
    {
        DbSet<StockPriceDto> StockPrice { get; set; }
        DbSet<Movie> Movie { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
