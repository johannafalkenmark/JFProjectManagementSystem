namespace Business.Models;

public class Project
{
    public int Id { get; set; }

    public string ProjectName { get; set; } = null!;

    public Customer Customer { get; set; } = null!;

    public ProjectManager? ProjectManager { get; set; }

    public ServiceType? ServiceType { get; set; }

    public StatusType? StatusType { get; set; }

    public User? User { get; set; }

    public ProjectSchedule? ProjectSchedule { get; set; }

    public ProjectNote? ProjectNote { get; set; }
}
