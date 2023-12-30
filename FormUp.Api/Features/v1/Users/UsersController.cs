using FormUp.Api.Common.Extensions;
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
    public async Task<IResult> GetByUid([FromRoute] string uid, CancellationToken cancellationToken = default)
    {
        var result = await _usersService.GetByUid(uid, cancellationToken);

        return result.MatchFirst(
            Results.Ok,
            error => error.ToResponse()
        );
    }

    [HttpPost(EndpointUrls.Users.Create)]
    public async Task<IResult> Create(CreateUserRequest request, CancellationToken cancellationToken = default)
    {
        var result = await _usersService.Create(request, cancellationToken);

        return result.MatchFirst(
            response => Results.Created(null as string, response),
            error => error.ToResponse()
        );
    }

    [HttpPost(EndpointUrls.Users.LogWeight)]
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
}