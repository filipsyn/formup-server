using FormUp.Api.Common.Extensions;
using FormUp.Api.Common.Models;
using FormUp.Api.Features.v1.Shared;
using FormUp.Contracts.v1.Users;

using Microsoft.AspNetCore.Mvc;

namespace FormUp.Api.Features.v1.Users;

[ApiController]
[Route(EndpointUrls.Users.GroupUrl)]
[Produces("application/json")]
public class UsersController : ControllerBase
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet(EndpointUrls.Users.GetByUid)]
    [ProducesResponseType<ApiResponse<UserInfoResponse>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status404NotFound)]
    public async Task<IResult> GetByUid([FromRoute] string uid, CancellationToken cancellationToken = default)
    {
        var result = await _usersService.GetByUid(uid, cancellationToken);

        return result.MatchFirst(
            Results.Ok,
            error => error.ToResponse()
        );
    }

    [HttpGet(EndpointUrls.Users.GetWeights)]
    [ProducesResponseType<ApiResponse<IList<WeightLogResponse>>>(StatusCodes.Status200OK)]
    public async Task<IResult> GetWeights(
        [FromRoute] string uid,
        [FromQuery] DateTime? from = null,
        [FromQuery] DateTime? to = null,
        CancellationToken cancellationToken = default)
    {
        var result = await _usersService.GetWeights(uid, from, to, cancellationToken);

        return Results.Ok(result);
    }

    [HttpGet(EndpointUrls.Users.GetHeights)]
    [ProducesResponseType<ApiResponse<IList<HeightLogResponse>>>(StatusCodes.Status200OK)]
    public async Task<IResult> GetHeights(
        string uid,
        DateTime? from = null,
        DateTime? to = null,
        CancellationToken cancellationToken = default)
    {
        var result = await _usersService.GetHeights(uid, from, to, cancellationToken);

        return Results.Ok(result);
    }

    [HttpPost(EndpointUrls.Users.Create)]
    [ProducesResponseType<ApiResponse<CreateUserResponse>>(StatusCodes.Status201Created)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status400BadRequest)]
    public async Task<IResult> Create(CreateUserRequest request, CancellationToken cancellationToken = default)
    {
        var result = await _usersService.Create(request, cancellationToken);

        return result.MatchFirst(
            response => Results.Created(null as string, response),
            error => error.ToResponse()
        );
    }

    [HttpPost(EndpointUrls.Users.LogWeight)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status400BadRequest)]
    public async Task<IResult> LogWeight([FromRoute] string uid, CreateWeightLogEntryRequest request,
        CancellationToken cancellationToken = default)
    {
        var result = await _usersService.LogWeight(uid, request, cancellationToken);

        return result.MatchFirst(
            response => Results.Created(null as string, response),
            error => error.ToResponse()
        );
    }

    [HttpPost(EndpointUrls.Users.LogHeight)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status400BadRequest)]
    public async Task<IResult> LogHeight(
        [FromRoute] string uid,
        CreateHeightLogEntryRequest request,
        CancellationToken cancellationToken = default)
    {
        var result = await _usersService.LogHeight(uid, request, cancellationToken);

        return result.MatchFirst(
            response => Results.Created(null as string, response),
            error => error.ToResponse()
        );
    }

    [HttpDelete(EndpointUrls.Users.Delete)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType<ApiResponse>(StatusCodes.Status400BadRequest)]
    public async Task<IResult> Delete(string uid, CancellationToken cancellationToken = default)
    {
        var result = await _usersService.Delete(uid, cancellationToken);

        return result.MatchFirst(
            _ => Results.NoContent(),
            error => error.ToResponse()
        );
    }
}