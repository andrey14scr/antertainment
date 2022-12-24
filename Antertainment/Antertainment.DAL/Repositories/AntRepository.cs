using Antertainment.DAL.Entities;
using Antertainment.DAL.Repositories.Abstraction;

using Microsoft.EntityFrameworkCore;

namespace Antertainment.DAL.Repositories;

public sealed class AntRepository : EntityRepository<Ant>, IAntRepository
{
    public AntRepository(DatabaseContext сontext) : base(сontext) { }

    public async Task<IEnumerable<Ant>> GetAll(int take, int skip, bool includeAllImages)
    {
        return await Сontext.Ants.Include(a => a.Images.Where(i => i.IsPrimary)).Take(take).Skip(skip).AsNoTracking().ToListAsync();
    }
}