namespace Business.Models;

public class ProjectSchedule
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public Project? Project { get; set; }

    public IEnumerable<Project> Projects { get; set; } = [];
}
