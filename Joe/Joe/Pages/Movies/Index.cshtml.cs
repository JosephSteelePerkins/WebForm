using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Joe.Data;
using Joe.Models;

namespace Joe.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Joe.Data.JoeContext _context;

        public IndexModel(Joe.Data.JoeContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
