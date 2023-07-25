using System.Linq.Expressions;
using Tazaker.Models;

namespace Tazaker.Data.Repository.Generic
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<ICollection<T>> GetAll();
        Task<ICollection<T>> GetAll(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(Guid Id, T entity);
        Task DeleteAsync(Guid ActorId);
    }
}
