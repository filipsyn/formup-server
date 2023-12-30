namespace FormUp.Contracts.v1.Users;

public record CreateHeightLogRequest
{
    public float Value { get; set; }
    public DateTime LoggedAt { get; set; }
}