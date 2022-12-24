using Antertainment.DAL.Entities;

namespace Antertainment.DAL.Repositories.Abstraction;

public interface IEntityRepository<T> : ITransactionalRepository where T : BaseEntity
{
    Task<T> Create(T entity);
    Task<T> GetById(Guid id);
    T Update(T entity);
    T Delete(T entity);
}