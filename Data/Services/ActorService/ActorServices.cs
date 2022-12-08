using Microsoft.EntityFrameworkCore;
using Tazaker.Models;

namespace Tazaker.Data.Services.ActorService
{
    public class ActorServices : IActorService
    {
        private readonly AppDbContext _context;
        public ActorServices(AppDbContext context)
        {
            _context = context;
        }

        public async void AddActorAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
           await _context.SaveChangesAsync();
        }

        public void DeleteActor(Guid ActorId)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetActorByIdAsync(Guid id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return actor;
        }

        public async Task<ICollection<Actor>> GetAllActors()
        {
            var allActors = await _context.Actors.ToListAsync();
            return allActors;
        }

        public Actor UpdateActor(Guid ActorId, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
