namespace FormUp.Contracts.v1.Users;

public record HeightLogResponse
{
    public float Value { get; set; }
    public DateTime At { get; set; }
}