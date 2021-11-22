using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockMarket.Domain.Entities;

namespace StockMarket.Application
{
    public class Format
    {
        public List<StockPriceDto> FormatStockPrices(List<StockPriceDto> stockPricesList)
        {
            var formattedStockPrices = new List<StockPriceDto>();
            foreach (var stockPrice in stockPricesList)
            {
                var formattedStockPrice = FormatStockPrice(stockPrice);
                formattedStockPrices.Add(formattedStockPrice);
            }
            return formattedStockPrices;
        }

        private StockPriceDto FormatStockPrice(StockPriceDto stockPrice)
        {
            stockPrice.TransactionTime = FormatTransactionTime(stockPrice.TransactionTime);
            return stockPrice;
        }

        private DateTimeOffset FormatTransactionTime(DateTimeOffset transactionTime)
        {
            return transactionTime.ToLocalTime();
        }
    }
}
