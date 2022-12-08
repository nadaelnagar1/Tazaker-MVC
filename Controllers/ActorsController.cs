using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tazaker.Data;
using Tazaker.Data.Services.ActorService;
using Tazaker.Models;

namespace Tazaker.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _actorServices;
        public ActorsController( IActorService actorServices)
        {
            _actorServices = actorServices;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await _actorServices.GetAllActors();
            return View(actors);
        }
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
           
              _actorServices.AddActorAsync(actor);
              return RedirectToAction("Index");
        }

        //Get: Actors/Details/id
        public async Task<IActionResult> Details(Guid id)
        {
            var actorDetails =await _actorServices.GetActorByIdAsync(id);
            if (actorDetails == null)
                return View("Not found");
            return View(actorDetails);
        }
    }
}
