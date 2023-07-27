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

        public async Task AddNewMovie(NewMovieVM movieVM)
        {
            var newMovie = new Movie()
            {
                Name = movieVM.Name,
                Description = movieVM.Description,
                Price = movieVM.Price,
                ImageURL = movieVM.ImageURL,
                CinemaId = movieVM.CinemaId,
                StartDate = movieVM.StartDate,
                EndDate = movieVM.EndDate,
                MovieCategory = movieVM.MovieCategory,
                ProducerId = movieVM.ProducerId,

            };
            await _context.AddAsync(newMovie);
            await _context.SaveChangesAsync();

            //add actors

            foreach (var actorId in movieVM.ActorIds)
            {
                var newActorMovie = new Actor_Movies()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId,

                };
                await _context.Actors_Movies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(Guid id)
        {
            var movieDetails = await _context.Movies.Include(c => c.Cinema).Include(p => p.Producer).
                 Include(am => am.Actor_Movies).ThenInclude(a => a.Actor).FirstOrDefaultAsync(n => n.Id == id);
            return movieDetails;
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

        public async Task UpdateMovieAsync(NewMovieVM movieVM)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(n => n.Id == movieVM.Id);
            if (movie != null)
            {

                movie.Name = movieVM.Name;
                movie.Description = movieVM.Description;
                movie.Price = movieVM.Price;
                movie.ImageURL = movieVM.ImageURL;
                movie.CinemaId = movieVM.CinemaId;
                movie.StartDate = movieVM.StartDate;
                movie.EndDate = movieVM.EndDate;
                movie.MovieCategory = movieVM.MovieCategory;
                movie.ProducerId = movieVM.ProducerId;

                await _context.SaveChangesAsync();

            }

           //remove exsting actors
           var existingActors = _context.Actors_Movies.Where(n=>n.MovieId == movieVM.Id).ToList();
            _context.Actors_Movies.RemoveRange(existingActors);

            await _context.SaveChangesAsync();

            //add movie actors

            foreach (var actorId in movieVM.ActorIds)
            {
                var newActorMovie = new Actor_Movies()
                {
                    MovieId = movieVM.Id,
                    ActorId = actorId, 

                };
                await _context.Actors_Movies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();

        }
    }
}
