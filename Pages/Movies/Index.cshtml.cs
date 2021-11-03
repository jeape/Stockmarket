using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using StockPrices.Application.Models;
using StockPrices.Infrastructure.Persistence;

namespace StockPrices.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly StockPricesContext _context;

        public IndexModel(StockPricesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
