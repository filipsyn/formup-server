using ErrorOr;

using FormUp.Api.Common.Models;

namespace FormUp.Api.Common.Extensions;

public static class ErrorExtensions
{
    public static IResult ToResponse(this Error error)
    {
        var statusCode = GetStatusCode(error);

        var responseBody = new ApiResponse { StatusCode = statusCode, Message = error.Description };

        return Results.Json(responseBody, statusCode: statusCode);
    }

    private static int GetStatusCode(Error error)
    {
        return error.Type switch
        {
            ErrorType.Failure => StatusCodes.Status400BadRequest,
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.Unauthorized => StatusCodes.Status401Unauthorized,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            _ => StatusCodes.Status500InternalServerError
        };
    }
}