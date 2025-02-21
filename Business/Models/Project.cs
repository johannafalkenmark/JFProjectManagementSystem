namespace Business.Models;

public class Project
{
    public int Id { get; set; }

    public string ProjectName { get; set; } = null!;

    public Customer Customer { get; set; } = null!;

    public ProjectManager? ProjectManager { get; set; }

    public ServiceType? ServiceType { get; set; }

    public StatusType StatusType { get; set; } = null!;

    public User User { get; set; } = null!;

    public ProjectSchedule ProjectSchedule { get; set; } = null!;

    public ProjectNote ProjectNote { get; set; } = null!;
}
