namespace FormUp.Contracts.v1.Workouts.Requests;

public record UpdateWorkoutRequest
{
    public required string UserId { get; set; }
    public required DateTime At { get; set; } = DateTime.Now;
    public IList<UpdateActivityRequest> Activities { get; set; } = new List<UpdateActivityRequest>();
}