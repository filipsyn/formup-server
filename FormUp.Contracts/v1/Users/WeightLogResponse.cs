namespace FormUp.Contracts.v1.Users;

public record WeightLogResponse
{
    public float Value { get; set; }
    public DateTime At { get; set; }
}