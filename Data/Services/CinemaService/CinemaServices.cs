using Tazaker.Data.Repository.Generic;
using Tazaker.Models;

namespace Tazaker.Data.Services.CinemaService
{
    public class CinemaServices:EntityBaseRepository<Cinema>,ICinemaServices
    {
        public CinemaServices(AppDbContext context) : base(context)
        {
            
        }
    }
}
