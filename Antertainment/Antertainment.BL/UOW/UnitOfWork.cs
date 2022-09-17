using Antertainment.DAL.Entities;
using Antertainment.DAL.Repositories.Abstraction;

namespace Antertainment.BL.UOW;

public sealed class UnitOfWork : IUnitOfWork
{
    public IAntRepository AntRepository { get; }
    public IEntityRepository<Image> ImageRepository { get; }
    public IEntityRepository<User> UserRepository { get; }

    public UnitOfWork(IAntRepository antRepository, IEntityRepository<Image> imageRepository, IEntityRepository<User> userRepository)
    {
        AntRepository = antRepository;
        ImageRepository = imageRepository;
        UserRepository = userRepository;
    }
}