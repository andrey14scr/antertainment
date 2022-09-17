using Antertainment.BL;
using Antertainment.BL.Abstraction;
using Antertainment.BL.Mapper;
using Antertainment.BL.UOW;
using Antertainment.DAL.Entities;
using Antertainment.DAL.Repositories;
using Antertainment.DAL.Repositories.Abstraction;

namespace Antertainment.API;

internal static class DependencyRegistration
{
    public static void Register(IServiceCollection services)
    {
        services.AddTransient<IAntRepository, AntRepository>();
        services.AddTransient<IEntityRepository<Image>, ImageRepository>();
        services.AddTransient<IEntityRepository<User>, UserRepository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IImageService, ImageService>();

        services.AddAutoMapper(typeof(AutoMap).Assembly);
    }
}