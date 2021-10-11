using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockPrices.DTOs
{
    public class StockPriceDto
    {
        public string Symbol { get; set; }
        
        public decimal BidPrice { get; set; }
        
        public decimal AskPrice { get; set; }
        
        public DateTimeOffset TransactionTime { get; set; }
    }
}
