using FormUp.Api.Features.v1.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FormUp.Api.Features.v1.Gyms;

[ApiController]
[Route(EndpointUrLs.Gyms.GroupUrl)]
public class GymsController: ControllerBase
{
    [HttpGet(EndpointUrLs.Gyms.GetAll)]
    public IActionResult Get()
    {
        return Ok("Hello world");
    }
}