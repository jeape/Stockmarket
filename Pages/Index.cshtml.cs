using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

using StockPrices.DTOs;

namespace StockPrices.Pages
{
    public class IndexModel : PageModel
    {
        public ILogger<IndexModel> Logger { get; set; }
        
        public List<StockPriceDto> StockPrices { get; private set; }

        private int MaxValue { get; set; } = 3001;

        public List<string> Symbols { get; set; } = new List<string> { "AAPL", "IBM", "MSFT", "TSLA", "AMC", "AMZN", "GME" };
        public IndexModel(ILogger<IndexModel> logger)
        {
            Logger = logger;
        }

        public void OnGet()
        {
            StockPrices = CreateList();
        }

        public List<decimal> GenerateRandomNumbers(int length, int maxValue)
        {
            var randomGenerator = new Random();
            var randomNumbers = new List<decimal>();
            for (int i=0; i < length; i++)
            {
                randomNumbers.Add(randomGenerator.Next(maxValue)*1.00M);
            }
            return randomNumbers;
        }

        public StockPriceDto Create(string symbol)
        {
            var randomPrices = GenerateRandomNumbers(2, MaxValue);
            var bidPrice = randomPrices.Min();
            var askPrice = randomPrices.Max();
            var stockPrice = new StockPriceDto(symbol, bidPrice, askPrice, DateTimeOffset.UtcNow);
            return stockPrice;
        }

        public List<StockPriceDto> CreateList()
        {
            StockPrices = new List<StockPriceDto>();
            foreach (string symbol in Symbols)
            {
                var stockPrice = Create(symbol);
                StockPrices.Add(stockPrice);
            }
            return StockPrices;
        }
    }
}
