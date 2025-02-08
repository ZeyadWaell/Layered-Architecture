using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CleaningApplication.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        void Add(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        Task RemoveAsync(T entity);
        void RemoveRange(IEnumerable<T> entities);
        Task RemoveRangeAsync(IEnumerable<T> entities);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<int> SaveAsync(); // Ensure DB Changes are committed
    }
}
