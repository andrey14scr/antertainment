using Antertainment.DAL.Entities;

using Microsoft.EntityFrameworkCore;

namespace Antertainment.DAL.Repositories.Abstraction;

public class EntityRepository<T> : BaseRepository, IEntityRepository<T> where T : BaseEntity
{
    public EntityRepository(DatabaseContext сontext) : base(сontext)
    {
    }

    public async Task<T> GetById(Guid id)
    {
        return await Сontext.Set<T>().FirstOrDefaultAsync(i => i.Id == id);
    }

    public T Update(T entity)
    {
        var result = Сontext.Update(entity);
        return result.Entity;
    }

    public T Delete(T entity)
    {
        var result = Сontext.Update(entity);
        return result.Entity;
    }

    public async Task<T> Create(T entity)
    {
        var result = await Сontext.AddAsync(entity);
        return result.Entity;
    }
}