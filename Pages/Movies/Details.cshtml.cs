using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using StockPrices.Application.Models;
using StockPrices.Infrastructure.Persistence;

namespace StockPrices.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly StockPricesContext _context;

        public DetailsModel(StockPricesContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
