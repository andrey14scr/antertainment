using Antertainment.BL.UOW;

using AutoMapper;

namespace Antertainment.BL;

public abstract class BaseService
{
    protected IMapper Mapper;
    protected IUnitOfWork UnitOfWork;

    protected BaseService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        Mapper = mapper;
        UnitOfWork = unitOfWork;
    }
}