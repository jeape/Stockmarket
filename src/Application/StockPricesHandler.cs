using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using StockMarket.Domain.Entities;
using StockMarket.Application;
using StockMarket.Application.Interfaces;
using StockMarket.Domain.Interfaces;

namespace StockMarket.Application
{
    public class StockPricesHandler
    {
        public StockPricesHandler(IStockPricesContext context, IStockPrices stockPrices, Format format)
        {
            Context = context;
            StockPrices = stockPrices;
            Format = format;
        }

        public IStockPricesContext Context { get; private set; }
        public IStockPrices StockPrices { get; private set; }

        public Format Format { get; private set; }

        public async Task<List<StockPriceDto>> HandleStockPrices(CancellationToken cancellationToken)
        {
            var stockPricesList = StockPrices.CreateList();
            for (int i = 0; i < stockPricesList.Count; i++)
            {
                Context.StockPrice.Add(stockPricesList[i]);
            }
            await Context.SaveChangesAsync(cancellationToken);
            var stockPricesFormatted = Format.FormatStockPrices(stockPricesList);
            return stockPricesFormatted;
        }
    }
}
