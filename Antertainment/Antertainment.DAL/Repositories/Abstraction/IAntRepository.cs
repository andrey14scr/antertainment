using Antertainment.DAL.Entities;

namespace Antertainment.DAL.Repositories.Abstraction;

public interface IAntRepository : IEntityRepository<Ant>
{
    Task<IEnumerable<Ant>> GetAll(int take, int skip, bool includeAllImages);
}