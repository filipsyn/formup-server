using ErrorOr;

using FormUp.Api.Common.Config;
using FormUp.Api.Common.Models;
using FormUp.Api.Features.v1.Shared;
using FormUp.Contracts.v1.Gyms;

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
    [ProducesResponseType<ApiResponse<IList<GymInfo>>>(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(
        [FromQuery] int take = Constants.List.DefaultPageSize,
        [FromQuery] int skip = Constants.List.DefaultSkip,
        CancellationToken cancellationToken = default)
    {
        return Ok(await _gymsService.Get(skip, take, cancellationToken));
    }

    [HttpGet(EndpointUrls.Gyms.GetById)]
    [ProducesResponseType<ApiResponse<GymInfo>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
    {
        ErrorOr<ApiResponse<GymInfo>> result = await _gymsService.Get(id, cancellationToken);

        return result.Match<IActionResult>(
            Ok,
            NotFound
        );
    }
}