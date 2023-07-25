using Microsoft.EntityFrameworkCore;
using Tazaker.Data.Repository.Generic;
using Tazaker.Data.ViewModels;
using Tazaker.Models;

namespace Tazaker.Data.Services.MovieService
{
    public class MovieServices : EntityBaseRepository<Movie>, IMovieServices
    {
        private readonly AppDbContext _context;
        public MovieServices(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(Guid id)
        {
            var movieDetails =await _context.Movies.Include(c => c.Cinema).Include(p => p.Producer).
                 Include(am => am.Actor_Movies).ThenInclude(a => a.Actor).FirstOrDefaultAsync(n => n.Id == id);
            return   movieDetails;
        }

        public async Task<NewMovieDropDownVM> GetNewMovieDropDownVMAsync()
        {
            var response = new NewMovieDropDownVM()
            {
                Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync(),
            };
            return response;
        }
    }
}
