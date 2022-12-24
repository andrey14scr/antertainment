using Antertainment.DTO;

namespace Antertainment.API.Account;

public interface IAccountService
{
    Task<UserDto> Login(Credentials credentials);
    Task<UserDto> Register(RegisterInfo registerInfo);
}