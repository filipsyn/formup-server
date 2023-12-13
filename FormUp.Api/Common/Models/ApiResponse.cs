using System.Text.Json.Serialization;

namespace FormUp.Api.Common.Models;

public record ApiResponse
{
    public int StatusCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Message { get; init; }

    [JsonIgnore] public bool IsSuccess => StatusCode is >= 200 and < 400;

    [JsonIgnore] public bool IsFailure => !IsSuccess;
}