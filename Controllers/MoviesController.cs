using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tazaker.Data;
using Tazaker.Data.Services.MovieService;

namespace Tazaker.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieServices _movieServices;
        public MoviesController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _movieServices.GetAll(n=>n.Cinema);

            return View(movies);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var movieDetail = await _movieServices.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        public async Task<IActionResult> Create()
        {
            var movies = await _movieServices.GetNewMovieDropDownVMAsync();

            ViewBag.Cinemas = new SelectList(movies.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movies.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movies.Actors, "Id", "FullName");

            return View();
        }


    }
}
