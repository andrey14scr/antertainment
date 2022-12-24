using Antertainment.BL.Abstraction;
using Antertainment.DTO;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Antertainment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class AntController : ControllerBase
{
    private readonly IAntService _antService;
    private readonly Serilog.ILogger _logger;
    private readonly string _controllerName = nameof(AntController);

    public AntController(IAntService antService, Serilog.ILogger logger)
    {
        _antService = antService;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public async Task<AntDto> GetById(Guid id)
    {
        var method = $"{_controllerName}.{nameof(GetById)}";
        _logger.Information($"{method} has started.");

        try
        {
            var ant = await _antService.GetById(id);
            _logger.Information($"{method} has finished.");
            return ant;
        }
        catch
        {
            _logger.Error($"Error while {method} execution.");
            throw;
        }
    }

    [HttpGet]
    public async Task<IEnumerable<AntDto>> GetAll(int take = 10, int skip = 0)
    {
        var method = $"{_controllerName}.{nameof(GetAll)}";
        _logger.Information($"{method} has started.");

        try
        {
            var ants = await _antService.GetAll(take, skip, true);
            _logger.Information($"{method} has finished.");
            return ants;
        }
        catch
        {
            _logger.Error($"Error while {method} execution.");
            throw;
        }
    }

    [HttpGet("short")]
    public async Task<IEnumerable<AntDto>> GetShortInfo(int take = 10, int skip = 0)
    {
        var method = $"{_controllerName}.{nameof(GetShortInfo)}";
        _logger.Information($"{method} has started.");

        try
        {
            var ants = await _antService.GetAll(take, skip, false);
            _logger.Information($"{method} has finished.");
            return ants;
        }
        catch
        {
            _logger.Error($"Error while {method} execution.");
            throw;
        }
    }

    [HttpPost]
    public async Task<AntDto> Create(AntDto createdAnt)
    {
        var method = $"{_controllerName}.{nameof(Create)}";
        _logger.Information($"{method} has started.");

        try
        {
            var ant = await _antService.Create(createdAnt);
            _logger.Information($"{method} has finished.");
            return ant;
        }
        catch
        {
            _logger.Error($"Error while {method} execution.");
            throw;
        }
    }

    [HttpPut]
    public async Task<AntDto> Update(AntDto updatedAnt)
    {
        var method = $"{_controllerName}.{nameof(Update)}";
        _logger.Information($"{method} has started.");

        try
        {
            var ant = await _antService.Update(updatedAnt);
            _logger.Information($"{method} has finished.");
            return ant;
        }
        catch
        {
            _logger.Error($"Error while {method} execution.");
            throw;
        }
    }

    [HttpDelete]
    public async Task<AntDto> Delete(Guid id)
    {
        var method = $"{_controllerName}.{nameof(Delete)}";
        _logger.Information($"{method} has started.");

        try
        {
            var ant = await _antService.Delete(id);
            _logger.Information($"{method} has finished.");
            return ant;
        }
        catch
        {
            _logger.Error($"Error while {method} execution.");
            throw;
        }
    }
}
