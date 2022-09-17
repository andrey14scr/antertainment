using Antertainment.DAL.Entities;
using Antertainment.DAL.Repositories.Abstraction;

using Microsoft.EntityFrameworkCore;

namespace Antertainment.DAL.Repositories;

public sealed class AntRepository : BaseRepository, IAntRepository
{
    public AntRepository(DatabaseContext databaseContext) : base(databaseContext) { }

    public async Task Add(Ant entity)
    {
        await _databaseContext.AddAsync(entity);
    }

    public async Task<Ant> GetById(Guid id)
    {
        return await _databaseContext.Ants.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<IList<Ant>> GetAll()
    {
        return await _databaseContext.Ants.AsNoTracking().ToListAsync();
    }

    public void Update(Ant entity)
    {
        _databaseContext.Update(entity);
    }

    public void Delete(Ant entity)
    {
        _databaseContext.Remove(entity);
    }
}