using Antertainment.BL.Abstraction;
using Antertainment.BL.UOW;
using Antertainment.DAL.Entities;
using Antertainment.DTO;

using AutoMapper;

namespace Antertainment.BL;

public sealed class UserService : BaseService, IUserService
{
    public UserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }

    public async Task<UserDto> GetById(Guid id)
    {
        var entity = await UnitOfWork.UserRepository.GetById(id);
        var model = Mapper.Map<UserDto>(entity);
        return model;
    }

    public async Task<UserDto> Create(UserDto user)
    {
        var entityToCreate = Mapper.Map<User>(user);
        var entity = UnitOfWork.UserRepository.Create(entityToCreate);
        var model = Mapper.Map<UserDto>(entity);
        return await Task.FromResult(model);
    }
}