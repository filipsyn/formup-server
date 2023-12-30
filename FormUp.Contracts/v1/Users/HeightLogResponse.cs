namespace FormUp.Contracts.v1.Users;

public record HeightLogResponse
{
    public float Value { get; set; }
    public DateTime LoggedAt { get; set; }
}