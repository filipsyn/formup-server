using FormUp.Api.Common.Extensions;
using FormUp.Api.Features.v1.Shared;

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
}