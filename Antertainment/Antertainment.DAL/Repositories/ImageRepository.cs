using Antertainment.DAL.Entities;
using Antertainment.DAL.Repositories.Abstraction;

using Microsoft.EntityFrameworkCore;

namespace Antertainment.DAL.Repositories;

public sealed class ImageRepository : BaseRepository, IEntityRepository<Image>
{
    public ImageRepository(DatabaseContext databaseContext) : base(databaseContext) { }

    public async Task Add(Image entity)
    {
        await _databaseContext.AddAsync(entity);
    }

    public async Task<Image> GetById(Guid id)
    {
        return await _databaseContext.Images.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
    }

    public void Update(Image entity)
    {
        _databaseContext.Update(entity);
    }

    public void Delete(Image entity)
    {
        _databaseContext.Remove(entity);
    }
}