namespace FormUp.Contracts.v1.Workouts.Requests;

public record CreateWorkout
{
    public required string UserId { get; set; }
    public required DateTime At { get; set; } = DateTime.Now;
    public IList<CreateActivity> Activities { get; set; } = new List<CreateActivity>();
}