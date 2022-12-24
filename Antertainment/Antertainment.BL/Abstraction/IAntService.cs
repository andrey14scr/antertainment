using Antertainment.DTO;

namespace Antertainment.BL.Abstraction;

public interface IAntService
{
    Task<AntDto> GetById(Guid id);
    Task<IEnumerable<AntDto>> GetAll(int take, int skip, bool includeAllImages);
    Task<AntDto> Create(AntDto ant);
    Task<AntDto> Update(AntDto ant);
    Task<AntDto> Delete(Guid id);
}