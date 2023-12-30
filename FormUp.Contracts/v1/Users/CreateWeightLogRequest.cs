namespace FormUp.Contracts.v1.Users;

public record CreateWeightLogRequest
{
    public float Value { get; set; }
    public DateTime LoggedAt { get; set; }
}