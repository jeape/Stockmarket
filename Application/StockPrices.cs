using StockPrices.DTOs;
using StockPrices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockPrices.Application
{
    public class StockPrices : IStockPrices
    {
        private List<string> Symbols { get; set; } = new List<string> { "AAPL", "IBM", "MSFT", "TSLA", "AMC", "AMZN", "GME" };
        private int MaxValueRandomNumbers { get; set; } = 3001;

        private List<decimal> GenerateRandomNumbers(int length, int maxValue)
        {
            var randomGenerator = new Random();
            var randomNumbers = new List<decimal>();
            for (int i = 0; i < length; i++)
            {
                randomNumbers.Add(randomGenerator.Next(maxValue) * 1.00M);
            }
            return randomNumbers;
        }

        private StockPriceDto Create(string symbol)
        {
            var randomPrices = GenerateRandomNumbers(2, MaxValueRandomNumbers);
            var bidPrice = randomPrices.Min();
            var askPrice = randomPrices.Max();
            var stockPrice = new StockPriceDto(symbol, bidPrice, askPrice, DateTimeOffset.UtcNow);
            return stockPrice;
        }

        public List<StockPriceDto> CreateList()
        {
            var stockPrices = new List<StockPriceDto>();
            foreach (string symbol in Symbols)
            {
                var stockPrice = Create(symbol);
                stockPrices.Add(stockPrice);
            }
            return stockPrices;
        }
    }
}
