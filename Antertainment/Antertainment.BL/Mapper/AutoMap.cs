using Antertainment.DAL.Entities;
using Antertainment.DTO;

using AutoMapper;

namespace Antertainment.BL.Mapper;

public sealed class AutoMap : Profile
{
    public AutoMap()
    {
        CreateMap<ImageDto, Image>().ReverseMap();
    }
}