using Antertainment.DAL.Entities;
using Antertainment.DAL.Repositories.Abstraction;

using Microsoft.EntityFrameworkCore;

namespace Antertainment.DAL.Repositories;

public sealed class UserRepository : EntityRepository<User>, IUserRepository
{
    public UserRepository(DatabaseContext сontext) : base(сontext)
    {
    }

    public async Task<User> GetByCredentials(string loginName, string password)
    {
        return await Сontext.Users.Include(u => u.Role)
            .FirstOrDefaultAsync(u => (u.UserName == loginName || u.Email == loginName) && u.Password == password);
    }

    public bool CheckUserUnique(params string[] loginNames)
    {
        return Сontext.Users.Any(u => loginNames.Contains(u.Email) || loginNames.Contains(u.UserName));
    }
}