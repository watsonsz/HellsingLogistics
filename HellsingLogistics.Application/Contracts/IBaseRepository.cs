using HellsingLogistics.Domain.Common;

namespace HellsingLogistics.Application.Contracts;
public interface IBaseRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteListAsync(List<T> entities);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<bool> ExistsById(Guid id);
    }