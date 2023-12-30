namespace FormUp.Contracts.v1.Users;

public record UserInfoResponse
{
    public string Uid { get; set; }
    public string DisplayName { get; set; }
    public float? Height { get; set; }
    public float? Weight { get; set; }
}