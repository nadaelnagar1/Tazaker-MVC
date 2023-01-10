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
            var actors = await _actorServices.GetAll();
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
           
              _actorServices.AddAsync(actor);
              return RedirectToAction("Index");
        }

        //Get: Actors/Details/id
        public async Task<IActionResult> Details(Guid id)
        {
            var actorDetails =await _actorServices.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            return View(actorDetails);
        }


        public async Task<IActionResult> Edit(Guid id)
        {
            var actorDetails = await _actorServices.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id,Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _actorServices.UpdateAsync(id, actor);
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> Delete(Guid id)
        {
            var actorDetails = await _actorServices.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id, Actor actor)
        {
            var actorDetails = await _actorServices.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");

            await _actorServices.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
