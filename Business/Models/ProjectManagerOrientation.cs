using Data.Entities;

namespace Business.Models;

public class ProjectManagerOrientation
{
    public int Id { get; set; }

    public string? TypeOfOrientation { get; set; }

    public IEnumerable<ProjectManagerEntity> ProjectManagers = [];
}
