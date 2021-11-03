using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockPrices.Application.Models;

namespace StockPrices.Application.Interfaces
{
    public interface IStockPricesContext
    {
        DbSet<StockPriceDto> StockPrice { get; set; }
        DbSet<Movie> Movie { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
