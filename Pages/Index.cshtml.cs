using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using StockPrices.Application;
using StockPrices.Application.Models;

namespace StockPrices.Pages
{
    public class IndexModel : PageModel
    {
        public ILogger<IndexModel> Logger { get; set; }

        public IList<StockPriceDto> StockPriceDtos { get; set; }

        public StockPricesHandler StockPricesHandler { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, StockPricesHandler stockPricesHandler)
        {
            Logger = logger;
            StockPricesHandler = stockPricesHandler;
        }

        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            StockPriceDtos = await StockPricesHandler.HandleStockPrices(cancellationToken);
        }
    }
}
