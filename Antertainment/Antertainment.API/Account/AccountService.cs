using Antertainment.API.Account.Jwt;
using Antertainment.BL;
using Antertainment.BL.Exceptions;
using Antertainment.BL.UOW;
using Antertainment.DAL.Entities;
using Antertainment.DTO;

using AutoMapper;

using System.Security.Cryptography;
using System.Text;

namespace Antertainment.API.Account;

public sealed class AccountService : BaseService, IAccountService
{
    private readonly IJwtManager _jwtManager;

    public AccountService(IUnitOfWork unitOfWork, IMapper mapper, IJwtManager jwtManager) : base(unitOfWork, mapper)
    {
        _jwtManager = jwtManager;
    }

    public async Task<UserDto> Login(Credentials credentials)
    {
        var hashedPassword = Hash(credentials.Password);
        var result = await UnitOfWork.UserRepository.GetByCredentials(credentials.Login, hashedPassword);

        if (result is null)
        {
            throw new AntertainmentException(ErrorCodes.WrongCredentials);
        }

        var model = Mapper.Map<UserDto>(result);

        model.Token = _jwtManager.GenerateToken(result);
        return model;
    }

    public async Task<UserDto> Register(RegisterInfo registerInfo)
    {
        var hasSameUser = UnitOfWork.UserRepository.CheckUserUnique(registerInfo.UserName, registerInfo.Email);
        if (hasSameUser)
        {
            throw new AntertainmentException(ErrorCodes.HasSameUser);
        }

        var user = Mapper.Map<User>(registerInfo);
        user.Password = Hash(registerInfo.Password);

        // TODO: replace with find by name/enum
        var role = await UnitOfWork.RoleRepository.GetById(new Guid("01FD5F33-5B52-4290-AB9B-17401EE1E512"));
        user.Role = role;

        var result = await UnitOfWork.UserRepository.Create(user);
        await UnitOfWork.UserRepository.SaveChanges();

        var model = Mapper.Map<UserDto>(result);

        model.Token = _jwtManager.GenerateToken(result);
        return model;
    }

    private static string Hash(string password)
    {
        var crypt = SHA256.Create();
        var hash = string.Empty;
        var crypto = crypt.ComputeHash(Encoding.Unicode.GetBytes(password));
        return crypto.Aggregate(hash, (current, theByte) => current + theByte.ToString("x2"));
    }
}