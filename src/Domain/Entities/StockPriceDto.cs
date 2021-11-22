using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StockMarket.Domain.Entities
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
        [DisplayName("Id")]
        public int ID { get; private set; }
        public string Symbol { get; private set; }

        [DisplayName("Bid")]
        public decimal BidPrice { get; private set; }

        [DisplayName("Ask")]
        public decimal AskPrice { get; private set; }

        [DisplayName("Transaction time")]
        public DateTimeOffset TransactionTime { get; set; }
    }
}
