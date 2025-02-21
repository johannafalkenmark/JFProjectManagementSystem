namespace Business.Models;
    public class ProjectManager
    {
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }


    public ProjectManagerOrientation? ProjectManagerOrientation { get; set; }

    public IEnumerable<Project> Projects { get; set; } = [];
}

