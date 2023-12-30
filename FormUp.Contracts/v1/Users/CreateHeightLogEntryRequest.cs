namespace FormUp.Contracts.v1.Users;

public record CreateHeightLogEntryRequest
{
    public float Value { get; set; }
    public DateTime LoggedAt { get; set; }
}