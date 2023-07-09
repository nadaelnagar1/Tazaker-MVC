using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tazaker.Data;
using Tazaker.Data.Services.CinemaService;

namespace Tazaker.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICinemaServices _services;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var cinemas=await _context.Cinemas.ToListAsync();
            return View(cinemas);
        }
    }
}
