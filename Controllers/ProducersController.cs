using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tazaker.Data;

namespace Tazaker.Controllers
{
    public class ProducersController : Controller
    {

        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var producers =await _context.Producers.ToListAsync();
            return View(producers);
        }
    }
}
