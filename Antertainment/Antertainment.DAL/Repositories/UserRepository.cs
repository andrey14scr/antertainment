using Antertainment.DAL.Entities;
using Antertainment.DAL.Repositories.Abstraction;

using Microsoft.EntityFrameworkCore;

namespace Antertainment.DAL.Repositories;

public sealed class UserRepository : BaseRepository, IEntityRepository<User>
{
    public UserRepository(DatabaseContext databaseContext) : base(databaseContext) { }

    public async Task Add(User entity)
    {
        await _databaseContext.AddAsync(entity);
    }

    public async Task<User> GetById(Guid id)
    {
        return await _databaseContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
    }

    public void Update(User entity)
    {
        _databaseContext.Update(entity);
    }

    public void Delete(User entity)
    {
        _databaseContext.Remove(entity);
    }
}