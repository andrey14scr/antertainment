using Antertainment.DAL.Entities;

namespace Antertainment.DAL.Repositories.Abstraction;

public interface IAntRepository : IEntityRepository<Ant>
{
    Task<IList<Ant>> GetAll();
}