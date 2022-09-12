namespace Antertainment.DAL.Repositories.Abstraction;

public interface ITransactionalRepository
{
    Task SaveChanges();
}