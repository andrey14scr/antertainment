using Antertainment.DAL.Entities;
using Antertainment.DAL.Repositories.Abstraction;

namespace Antertainment.BL.UOW;

public interface IUnitOfWork
{
    public IAntRepository AntRepository { get; }
    public IEntityRepository<Image> ImageRepository { get; }
    public IUserRepository UserRepository { get; }
    public IEntityRepository<Role> RoleRepository { get; }
}