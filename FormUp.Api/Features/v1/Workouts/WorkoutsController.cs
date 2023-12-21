using FormUp.Api.Common.Config;
using FormUp.Api.Common.Extensions;
using FormUp.Api.Common.Models;
using FormUp.Api.Features.v1.Shared;
using FormUp.Contracts.v1.Workouts;

using Microsoft.AspNetCore.Mvc;

namespace FormUp.Api.Features.v1.Workouts;

[ApiController]
[Route(EndpointUrls.Workouts.GroupUrl)]
[Produces("application/json")]
public class WorkoutsController : ControllerBase
{
    private readonly IWorkoutsService _workoutsService;

    public WorkoutsController(IWorkoutsService workoutsService)
    {
        _workoutsService = workoutsService;
    }

    [HttpGet(EndpointUrls.Workouts.Get)]
    [ProducesResponseType<ApiResponse<IList<WorkoutInfo>>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status404NotFound)]
    public async Task<IResult> Get(
        [FromRoute] string userId,
        [FromQuery] int skip = Constants.List.DefaultSkip,
        [FromQuery] int take = Constants.List.DefaultPageSize,
        CancellationToken cancellationToken = default)
    {
        var result = await _workoutsService.Get(userId, skip, take, cancellationToken);

        return result.MatchFirst(
            TypedResults.Ok,
            error => error.ToResponse()
        );
    }
}