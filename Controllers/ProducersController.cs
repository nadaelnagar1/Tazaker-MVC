using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tazaker.Data;
using Tazaker.Data.Services.ProducerService;
using Tazaker.Models;

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
            var Allproducers = await _producerService.GetAll();
            return View(Allproducers);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var producerDetails = await _producerService.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        public IActionResult Create()
        {
            return View();
        }
        

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
                return View(producer);
            
            await _producerService.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }


    }
}
