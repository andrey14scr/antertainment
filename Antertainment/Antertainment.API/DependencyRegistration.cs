using Antertainment.API.Account;
using Antertainment.API.Account.Jwt;
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
        services.AddTransient<IEntityRepository<Image>, EntityRepository<Image>>();
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IEntityRepository<Role>, EntityRepository<Role>>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IImageService, ImageService>();
        services.AddScoped<IAntService, AntService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IJwtManager, JwtManager>();
        services.AddScoped<IAccountService, AccountService>();

        services.AddAutoMapper(typeof(AutoMap).Assembly);
    }
}