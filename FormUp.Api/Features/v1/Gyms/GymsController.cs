using FormUp.Api.Features.v1.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FormUp.Api.Features.v1.Gyms;

[ApiController]
[Route(EndpointUrls.Gyms.GroupUrl)]
public class GymsController: ControllerBase
{
    [HttpGet(EndpointUrls.Gyms.GetAll)]
    public IActionResult Get()
    {
        return Ok("Hello world");
    }
}