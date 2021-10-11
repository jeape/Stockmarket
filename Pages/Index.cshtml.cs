using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

using StockPrices.Domain.DTOs;
using StockPrices.Domain.Interfaces;

namespace StockPrices.Pages
{
    public class IndexModel : PageModel
    {
        public ILogger<IndexModel> Logger { get; set; }
        
        private IStockPrices StockPrices { get; set; }

        public List<StockPriceDto> StockPriceDtos { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, IStockPrices stockPrices)
        {
            Logger = logger;
            StockPrices = stockPrices;
        }

        public void OnGet()
        {
            StockPriceDtos = StockPrices.CreateList();
        }
    }
}
