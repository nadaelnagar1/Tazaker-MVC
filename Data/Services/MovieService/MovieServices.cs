using Tazaker.Data.Repository.Generic;
using Tazaker.Models;

namespace Tazaker.Data.Services.MovieService
{
    public class MovieServices : EntityBaseRepository<Movie>, IMovieServices
    {
        public MovieServices(AppDbContext context) : base(context)
        {
            
        }
    }
}
