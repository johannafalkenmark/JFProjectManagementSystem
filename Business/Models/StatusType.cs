namespace Business.Models;

public class StatusType
{
    public int Id { get; set; }

    public string? TypeName { get; set; } 
    public IEnumerable<Project> Projects { get; set; } = [];
}
