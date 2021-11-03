using System;

namespace StockPrices.Application.Models
{
    public class StockPriceDto
    {
        public StockPriceDto(string symbol, decimal bidPrice, decimal askPrice, DateTimeOffset transactionTime)
        {
            Symbol = symbol;
            BidPrice = bidPrice;
            AskPrice = askPrice;
            TransactionTime = transactionTime;
        }

        public int ID { get; private set; }
        public string Symbol { get; private set; }

        public decimal BidPrice { get; private set; }

        public decimal AskPrice { get; private set; }

        public DateTimeOffset TransactionTime { get; private set; }
    }
}
