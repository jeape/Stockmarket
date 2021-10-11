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
        // public List<StockPriceDto> StockPrices { get; private set; }
        public List<decimal> AskPrices { get; private set; }

        public List<decimal> BidPrices { get; private set; }

        private int MaxValue { get; set; } = 3001;

        public List<string> Symbols { get; private set; } = new List<string> { "AAPL", "IBM", "MSFT", "TSLA", "AMC", "AMZN", "GME" };
        public IndexModel(ILogger<IndexModel> logger)
        {
            Logger = logger;
        }

        public void OnGet()
        {
            //StockPrices = new List<StockPriceDto>();

            AskPrices = GenerateRandomNumbers(Symbols.Count(), MaxValue);
            BidPrices = GenerateRandomNumbers(Symbols.Count(), MaxValue);


            // for 
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

        //public List<StockPriceDto> GenerateStocKPrices(int length, int maxValueBid, int maxValueAsk)
        //{
            //var askPrices = GenerateRandomNumbers(Symbols.Count(), MaxValueAsk);
            //var bidPrices = GenerateRandomNumbers(Symbols.Count(), MaxValueBid);

        //}
    }
}
