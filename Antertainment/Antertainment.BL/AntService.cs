using Antertainment.BL.Abstraction;
using Antertainment.BL.UOW;
using Antertainment.DAL.Entities;
using Antertainment.DTO;

using AutoMapper;

namespace Antertainment.BL;

public sealed class AntService : BaseService, IAntService
{
    public AntService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public async Task<AntDto> GetById(Guid id)
    {
        var entity = await UnitOfWork.AntRepository.GetById(id);
        var model = Mapper.Map<AntDto>(entity);
        return model;
    }

    public async Task<IEnumerable<AntDto>> GetAll(int take, int skip, bool includeAllImages)
    {
        var entity = await UnitOfWork.AntRepository.GetAll(take, skip, includeAllImages);
        var model = Mapper.Map<IEnumerable<AntDto>>(entity);
        return model;
    }

    public async Task<AntDto> Create(AntDto ant)
    {
        var entityToCreate = Mapper.Map<Ant>(ant);
        var entity = UnitOfWork.AntRepository.Create(entityToCreate);
        var model = Mapper.Map<AntDto>(entity);
        return await Task.FromResult(model);
    }

    public async Task<AntDto> Update(AntDto ant)
    {
        var entityToUpdate = Mapper.Map<Ant>(ant);
        var entity = UnitOfWork.AntRepository.Update(entityToUpdate);
        var model = Mapper.Map<AntDto>(entity);
        return await Task.FromResult(model);
    }

    public async Task<AntDto> Delete(Guid id)
    {
        var entity = UnitOfWork.AntRepository.Delete(new Ant { Id = id });
        var model = Mapper.Map<AntDto>(entity);
        return await Task.FromResult(model);
    }
}