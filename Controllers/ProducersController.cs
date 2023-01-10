using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tazaker.Data;
using Tazaker.Data.Services.ProducerService;

namespace Tazaker.Controllers
{
    public class ProducersController : Controller
    {

        private readonly IProducerService _producerService;
        public ProducersController(IProducerService producerService)
        {
            _producerService = producerService;
        }
        public async Task<IActionResult> Index()
        {
            var producers =await _context.Producers.ToListAsync();
            return View(producers);
        }
    }
}
