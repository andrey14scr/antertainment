using Antertainment.DAL.Entities;
using Antertainment.DAL.Repositories.Abstraction;

namespace Antertainment.BL.UOW;

public sealed class UnitOfWork : IUnitOfWork
{
    public IAntRepository AntRepository { get; }
    public IEntityRepository<Image> ImageRepository { get; }
    public IUserRepository UserRepository { get; }
    public IEntityRepository<Role> RoleRepository { get; }

    public UnitOfWork(IAntRepository antRepository,
        IEntityRepository<Image> imageRepository,
        IUserRepository userRepository,
        IEntityRepository<Role> roleRepository)
    {
        AntRepository = antRepository;
        ImageRepository = imageRepository;
        UserRepository = userRepository;
        RoleRepository = roleRepository;
    }
}