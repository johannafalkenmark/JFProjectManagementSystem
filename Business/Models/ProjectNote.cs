namespace Business.Models;

public class ProjectNote
{
    public int Id { get; set; }
public string? Notes { get; set; }

    public Project? Project { get; set; }

    public IEnumerable<Project> Projects { get; set; } = [];
}
