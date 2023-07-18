using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tazaker.Data;
using Tazaker.Data.Services.CinemaService;
using Tazaker.Models;

namespace Tazaker.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICinemaServices _services; 
        public CinemasController(ICinemaServices services )
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var cinemas=await _services.GetAll();
            return View(cinemas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
               await  _services.AddAsync(cinema);
               return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var producerDetails = await _services.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }


        public async Task<IActionResult> Edit(Guid id)
        {

            var cinema = await _services.GetByIdAsync(id);
            if (cinema == null) return View("NotFound");

            return View(cinema);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
                return View(cinema);

            if (id == cinema.Id)
            {
                await _services.UpdateAsync(id, cinema);
                return RedirectToAction(nameof(Index));
            }
            return View(cinema);
        }


        public async Task<IActionResult> Delete(Guid id)
        {
            var producer = await _services.GetByIdAsync(id);
            if (producer == null) return View("NotFound");

            return View(producer);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var producer = await _services.GetByIdAsync(id);
            if (producer == null) return View("NotFound");

            await _services.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
