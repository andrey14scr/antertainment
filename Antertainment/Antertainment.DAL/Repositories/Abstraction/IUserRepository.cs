using Antertainment.DAL.Entities;

namespace Antertainment.DAL.Repositories.Abstraction;

public interface IUserRepository : IEntityRepository<User>
{
    Task<User> GetByCredentials(string loginName, string password);
    bool CheckUserUnique(params string[] loginNames);
}