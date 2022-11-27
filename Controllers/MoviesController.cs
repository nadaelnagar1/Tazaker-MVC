using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tazaker.Data;

namespace Tazaker.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.ToListAsync();

            return View(movies);
        }
    }
}
