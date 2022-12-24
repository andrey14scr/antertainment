using Antertainment.DAL.Entities;

namespace Antertainment.API.Account.Jwt;

public interface IJwtManager
{
    string GenerateToken(User user);
}