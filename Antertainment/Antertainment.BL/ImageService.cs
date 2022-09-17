using Antertainment.BL.Abstraction;
using Antertainment.BL.UOW;
using Antertainment.DTO;

using AutoMapper;

namespace Antertainment.BL;

public sealed class ImageService : BaseService, IImageService
{
    public ImageService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public async Task<ImageDto> GetById(Guid id)
    {
        var image = await UnitOfWork.ImageRepository.GetById(id);
        var imageModel = Mapper.Map<ImageDto>(image);
        return imageModel;
    }
}