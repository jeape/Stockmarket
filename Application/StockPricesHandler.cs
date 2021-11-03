using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using StockPrices.Application.Interfaces;
using StockPrices.Application.Models;
using StockPrices.Domain.Interfaces;

namespace StockPrices.Application
{
    public class StockPricesHandler
    {
        public StockPricesHandler(IStockPricesContext context, IStockPrices stockPrices)
        {
            Context = context;
            StockPrices = stockPrices;
        }

        public IStockPricesContext Context { get; private set; }
        public IStockPrices StockPrices { get; private set; }

        public async Task<List<StockPriceDto>> HandleStockPrices(CancellationToken cancellationToken)
        {
            var stockPricesList = StockPrices.CreateList();
            for (int i = 0; i < stockPricesList.Count; i++)
            {
                Context.StockPrice.Add(stockPricesList[i]);
            }
            await Context.SaveChangesAsync(cancellationToken);
            return stockPricesList;
        }
    }
}
