using Tazaker.Data.Repository.Generic;
using Tazaker.Data.ViewModels;
using Tazaker.Models;

namespace Tazaker.Data.Services.MovieService
{
    public interface IMovieServices : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(Guid id);
        Task<NewMovieDropDownVM> GetNewMovieDropDownVMAsync();
        Task AddNewMovie(NewMovieVM movieVM);
        Task UpdateMovieAsync( NewMovieVM movieVM);

    }
}
