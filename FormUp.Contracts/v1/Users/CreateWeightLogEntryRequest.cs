namespace FormUp.Contracts.v1.Users;

public record CreateWeightLogEntryRequest
{
    public float Value { get; set; }
    public DateTime At { get; set; }
}