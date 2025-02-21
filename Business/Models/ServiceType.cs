namespace Business.Models;

public class ServiceType
{
    public int Id { get; set; }

    public string? TypeName { get; set; }

    public Cost? Cost { get; set; }

    public ServiceCategory? ServiceCategory { get; set; }

    public IEnumerable<Project> Projects { get; set; } = [];
}
