using Tazaker.Data.Repository.Generic;
using Tazaker.Models;

namespace Tazaker.Data.Services.MovieService
{
    public interface IMovieServices : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(Guid id);
    }
}
