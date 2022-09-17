using Antertainment.BL.Abstraction;
using Antertainment.DTO;

using Microsoft.AspNetCore.Mvc;

namespace Antertainment.API.Controllers;

[Route("[controller]")]
[ApiController]
public class ImageController : ControllerBase
{
    private readonly IImageService _imageService;
    private readonly Serilog.ILogger _logger;

    public ImageController(IImageService imageService, Serilog.ILogger logger)
    {
        _imageService = imageService;
        _logger = logger;
    }

    [HttpGet]
    [Route("GetImage")]
    public async Task<ImageDto> GetImage(Guid imageId)
    {
        _logger.Information("GetImage has started.");

        try
        {
            var image = await _imageService.GetById(imageId);
            _logger.Information("GetImage has finished.");
            return image;
        }
        catch (Exception e)
        {
            _logger.Error("Error while GetImage execution.");
            throw;
        }
    }
}
