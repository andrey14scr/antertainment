using Antertainment.DTO;

namespace Antertainment.BL.Abstraction;

public interface IUserService
{
    Task<UserDto> GetById(Guid id);
    Task<UserDto> Create(UserDto user);
}