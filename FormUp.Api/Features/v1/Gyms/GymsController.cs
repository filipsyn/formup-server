using FormUp.Api.Common.Config;
using FormUp.Api.Common.Extensions;
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
    public async Task<IResult> GetAll(
        [FromQuery] int take = Constants.List.DefaultPageSize,
        [FromQuery] int skip = Constants.List.DefaultSkip,
        CancellationToken cancellationToken = default)
    {
        return Results.Ok(await _gymsService.Get(skip, take, cancellationToken));
    }

    [HttpGet(EndpointUrls.Gyms.GetById)]
    [ProducesResponseType<ApiResponse<GymInfo>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status404NotFound)]
    public async Task<IResult> Get(Guid id, CancellationToken cancellationToken)
    {
        var result = await _gymsService.GetById(id, cancellationToken);

        return result.MatchFirst(
            Results.Ok,
            error => error.ToResponse()
        );
    }
}