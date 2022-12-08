using Tazaker.Models;

namespace Tazaker.Data.Services.ActorService
{
    public interface IActorService
    {
        //Get all actors
        Task<ICollection<Actor>> GetAllActors();
        //Get actor by id
        Task<Actor> GetActorByIdAsync(Guid id);
        //Add actor
        void AddActorAsync(Actor actor);
        //Update actor
        Actor UpdateActor(Guid ActorId, Actor newActor);
        //Delete actor
        void DeleteActor(Guid ActorId);
    }
}
