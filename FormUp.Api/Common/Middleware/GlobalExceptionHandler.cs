using FormUp.Api.Common.Models;

using Microsoft.AspNetCore.Diagnostics;

namespace FormUp.Api.Common.Middleware;

public class GlobalExceptionHandler : IExceptionHandler
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        var responseBody = new ApiResponse
        {
            StatusCode = StatusCodes.Status500InternalServerError, Message = "Unexpected server error has occured."
        };

        httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        await httpContext.Response.WriteAsJsonAsync(responseBody, cancellationToken);

        _logger.LogError("Unhandled exception: {@Exception}", exception);

        return true;
    }
}