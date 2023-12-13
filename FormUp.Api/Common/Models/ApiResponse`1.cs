using System.Text.Json.Serialization;

namespace FormUp.Api.Common.Models;

public record ApiResponse<TData>
{
    public int StatusCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public TData? Payload { get; init; }

    [JsonIgnore] public bool IsSuccess => StatusCode is >= 200 and < 400;

    [JsonIgnore] public bool IsFailure => !IsSuccess;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ResponseMetaData? Meta { get; init; }

    public static ApiResponse<T> Ok<T>(T payload, string? message = null, ResponseMetaData? metadata = null)
    {
        return new ApiResponse<T>
        {
            StatusCode = StatusCodes.Status200OK, Payload = payload, Message = message, Meta = metadata
        };
    }
}