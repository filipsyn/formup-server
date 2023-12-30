namespace FormUp.Contracts.v1.Users;

public record CreateHeightLogEntryRequest
{
    public float Value { get; set; }
    public DateTime At { get; set; }
}