﻿using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public List<int> AskPrices { get; private set; }
        public List<int> BidPrices { get; private set; }
        private int MaxValueBid { get; set; } = 301;
        private int MaxValueAsk { get; set; } = 401;

        public List<string> Symbols { get; private set; } = new List<string> { "AAPL", "IBM", "MSFT" };
        public IndexModel(ILogger<IndexModel> logger)
        {
            Logger = logger;
        }

        public void OnGet()
        {
            AskPrices = GenerateRandomNumbers(Symbols.Count(), MaxValueAsk);
            BidPrices = GenerateRandomNumbers(Symbols.Count(), MaxValueBid);
        }

        public List<int> GenerateRandomNumbers(int length, int maxValue)
        {
            var randomGenerator = new Random(0);
            var randomNumbers = new List<int>();
            for (int i=0; i <= length; i++)
            {
                randomNumbers.Add(randomGenerator.Next(maxValue));
            }
            return randomNumbers;
        }

    }
}
