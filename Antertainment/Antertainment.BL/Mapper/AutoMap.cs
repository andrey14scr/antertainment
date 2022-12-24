using Antertainment.DAL.Entities;
using Antertainment.DTO;

using AutoMapper;

namespace Antertainment.BL.Mapper;

public sealed class AutoMap : Profile
{
    public AutoMap()
    {
        CreateMap<ImageDto, Image>().ReverseMap();
        CreateMap<AntDto, Ant>().ReverseMap();
        CreateMap<UserDto, User>().ReverseMap();
        CreateMap<UserDto, RegisterInfo>().ReverseMap();
        CreateMap<User, RegisterInfo>().ReverseMap();
        CreateMap<UserDto, Credentials>().ReverseMap();
    }
}