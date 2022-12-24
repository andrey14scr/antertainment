using Antertainment.API.Account;
using Antertainment.DTO;

using Microsoft.AspNetCore.Mvc;

namespace Antertainment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly string _controllerName = nameof(AccountController);
    private readonly IAccountService _accountService;
    private readonly Serilog.ILogger _logger;

    public AccountController(Serilog.ILogger logger, IAccountService accountService)
    {
        _logger = logger;
        _accountService = accountService;
    }

    [HttpPost("Login")]
    public async Task<UserDto> Login(Credentials credentials)
    {
        var method = $"{_controllerName}.{nameof(Login)}";
        _logger.Information($"{method} has started.");

        try
        {
            var user = await _accountService.Login(credentials);
            _logger.Information($"{method} has finished.");
            return user;
        }
        catch
        {
            _logger.Error($"Error while {method} execution.");
            throw;
        }
    }

    [HttpPost("Register")]
    public async Task<UserDto> Register(RegisterInfo registerInfo)
    {
        var method = $"{_controllerName}.{nameof(Register)}";
        _logger.Information($"{method} has started.");

        try
        {
            var user = await _accountService.Register(registerInfo);
            _logger.Information($"{method} has finished.");
            return user;
        }
        catch
        {
            _logger.Error($"Error while {method} execution.");
            throw;
        }
    }
}
