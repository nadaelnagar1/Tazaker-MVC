using Microsoft.EntityFrameworkCore;
using Tazaker.Data.Repository.Generic;
using Tazaker.Models;

namespace Tazaker.Data.Services.ActorService
{
    public class ActorServices : EntityBaseRepository<Actor>, IActorService
    {
        public ActorServices(AppDbContext context):base(context)
        {
        }

    }
}
