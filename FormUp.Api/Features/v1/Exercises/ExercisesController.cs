using FormUp.Api.Common.Extensions;
using FormUp.Api.Common.Models;
using FormUp.Api.Features.v1.Shared;
using FormUp.Contracts.v1.Exercises;

using Microsoft.AspNetCore.Mvc;

namespace FormUp.Api.Features.v1.Exercises;

[ApiController]
[Route(EndpointUrls.Exercises.GroupUrl)]
public class ExercisesController : ControllerBase
{
    private readonly IExercisesService _exercisesService;

    public ExercisesController(IExercisesService exercisesService)
    {
        _exercisesService = exercisesService;
    }

    [HttpGet(EndpointUrls.Exercises.Get)]
    [ProducesResponseType<ApiResponse<IList<ExerciseInfo>>>(StatusCodes.Status200OK)]
    public async Task<IResult> Get(
        [FromQuery(Name = "name")] string? searchedName = null,
        CancellationToken cancellationToken = default
    )
    {
        var result = await _exercisesService.Get(searchedName, cancellationToken);

        return Results.Ok(result);
    }

    [HttpGet(EndpointUrls.Exercises.GetById)]
    public async Task<IResult> GetById([FromRoute] Guid id, CancellationToken cancellationToken = default)
    {
        var result = await _exercisesService.GetById(id, cancellationToken);

        return result.MatchFirst(
            Results.Ok,
            error => error.ToResponse()
        );
    }
}