using Antertainment.DTO;

namespace Antertainment.BL.Abstraction;

public interface IImageService
{
    Task<ImageDto> GetById(Guid id);
}