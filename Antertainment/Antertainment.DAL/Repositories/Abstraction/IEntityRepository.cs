namespace Antertainment.DAL.Repositories.Abstraction;

public interface IEntityRepository<T> : ITransactionalRepository
{
    Task Add(T entity);
    Task<T> GetById(Guid id);
    void Update(T entity);
    Task Delete(T entity);
}