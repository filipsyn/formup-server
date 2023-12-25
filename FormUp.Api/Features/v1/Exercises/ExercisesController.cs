using FormUp.Api.Common.Extensions;
using FormUp.Api.Common.Models;
using FormUp.Api.Features.v1.Shared;
using FormUp.Contracts.v1.Exercises;

using Microsoft.AspNetCore.Mvc;

namespace FormUp.Api.Features.v1.Exercises;

[ApiController]
[Route(EndpointUrls.Exercises.GroupUrl)]
[Produces("application/json")]
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
        [FromHeader(Name = "Content-Language")]
        string language = "en",
        CancellationToken cancellationToken = default
    )
    {
        var result = await _exercisesService.Get(searchedName, language, cancellationToken);

        return Results.Ok(result);
    }

    [HttpGet(EndpointUrls.Exercises.GetById)]
    [ProducesResponseType<ApiResponse<ExerciseInfo>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status404NotFound)]
    public async Task<IResult> GetById([FromRoute] Guid id, CancellationToken cancellationToken = default)
    {
        var result = await _exercisesService.GetById(id, cancellationToken);

        return result.MatchFirst(
            Results.Ok,
            error => error.ToResponse()
        );
    }
}