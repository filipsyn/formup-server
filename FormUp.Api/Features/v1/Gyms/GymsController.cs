using FormUp.Api.Common.Config;
using FormUp.Api.Features.v1.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FormUp.Api.Features.v1.Gyms;

[ApiController]
[Route(EndpointUrls.Gyms.GroupUrl)]
public class GymsController : ControllerBase
{
    private readonly IGymsService _gymsService;

    public GymsController(IGymsService gymsService)
    {
        _gymsService = gymsService ?? throw new ArgumentNullException(nameof(gymsService));
    }

    [HttpGet(EndpointUrls.Gyms.GetAll)]
    public async Task<IActionResult> GetAll(
        [FromQuery] int take = Constants.List.DefaultPageSize,
        [FromQuery] int skip = Constants.List.DefaultSkip,
        CancellationToken cancellationToken = default)
    {
        return Ok(await _gymsService.Get(skip, take, cancellationToken));
    }

    [HttpGet(EndpointUrls.Gyms.GetById)]
    public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
    {
        var result = await _gymsService.Get(id, cancellationToken);

        return result.Match<IActionResult>(
            Ok,
            NotFound
        );
    }
}