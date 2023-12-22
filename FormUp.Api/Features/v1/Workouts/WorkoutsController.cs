using FormUp.Api.Common.Config;
using FormUp.Api.Common.Extensions;
using FormUp.Api.Common.Models;
using FormUp.Api.Features.v1.Shared;
using FormUp.Contracts.v1.Workouts;
using FormUp.Contracts.v1.Workouts.Requests;

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
            Results.Ok,
            error => error.ToResponse()
        );
    }

    [HttpGet(EndpointUrls.Workouts.GetById)]
    [ProducesResponseType<ApiResponse<WorkoutInfo>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status404NotFound)]
    public async Task<IResult> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        var result = await _workoutsService.GetById(id, cancellationToken);

        return result.MatchFirst(
            Results.Ok,
            error => error.ToResponse()
        );
    }

    [HttpPost(EndpointUrls.Workouts.Create)]
    [ProducesResponseType<ApiResponse<CreateWorkoutResponse>>(StatusCodes.Status201Created)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status400BadRequest)]
    public async Task<IResult> Create(CreateWorkout request, CancellationToken cancellationToken = default)
    {
        var result = await _workoutsService.Create(request, cancellationToken);

        return result.MatchFirst(
            response => Results.Created(null as string, response),
            error => error.ToResponse()
        );
    }
}