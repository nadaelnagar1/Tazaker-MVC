using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tazaker.Data;
using Tazaker.Data.Services.MovieService;
using Tazaker.Models;

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

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            if(!ModelState.IsValid)
            {
                return View(movie); 
            }
            await _movieServices.AddNewMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var movieDetails = await _movieServices.GetMovieByIdAsync(id);
            if(movieDetails == null) return View("NotFound");

            var response = new NewMovieVM(){
              Id=movieDetails.Id,
              Name=movieDetails.Name,
              Description=movieDetails.Description,
              Price=movieDetails.Price,
              StartDate=movieDetails.StartDate,
              EndDate=movieDetails.EndDate,
              ImageURL=movieDetails.ImageURL,
              MovieCategory=movieDetails.MovieCategory,
              CinemaId=movieDetails.CinemaId,
              ProducerId=movieDetails.ProducerId,
              ActorIds=movieDetails.Actor_Movies.Select(n=>n.ActorId).ToList(),
            };

            var movies = await _movieServices.GetNewMovieDropDownVMAsync();

            ViewBag.Cinemas = new SelectList(movies.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movies.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movies.Actors, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, NewMovieVM movie)
        {
            if (id != movie.Id) return View("NotFound");



            if (!ModelState.IsValid)
            {
                var movies = await _movieServices.GetNewMovieDropDownVMAsync();

                ViewBag.Cinemas = new SelectList(movies.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movies.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movies.Actors, "Id", "FullName");

                return View(movie);
            }
            await _movieServices.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}
