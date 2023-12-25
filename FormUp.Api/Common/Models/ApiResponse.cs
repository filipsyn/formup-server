using System.Text.Json.Serialization;

namespace FormUp.Api.Common.Models;

public record ApiResponse
{
    public int StatusCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Message { get; init; }

    [JsonIgnore] public bool IsSuccess => StatusCode is >= 200 and < 400;

    [JsonIgnore] public bool IsFailure => !IsSuccess;

    public static ApiResponse Created(string? message = null)
    {
        return new ApiResponse { StatusCode = StatusCodes.Status201Created, Message = message };
    }

    public static ApiResponse NoContent()
    {
        return new ApiResponse { StatusCode = StatusCodes.Status204NoContent };
    }
}