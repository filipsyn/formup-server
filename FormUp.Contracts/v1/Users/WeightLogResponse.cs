namespace FormUp.Contracts.v1.Users;

public record WeightLogResponse
{
    public float Value { get; set; }
    public DateTime LoggedAt { get; set; }
}