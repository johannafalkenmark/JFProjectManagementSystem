
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectScheduleEntity
{
    [Key]
    public int Id { get; set; }

    public string StartDate { get; set; } = null!;

    public string EndDate { get; set; } = null!;

    //koppling till project:
    public int ProjectId { get; set; }
    public ProjectEntity Project { get; set; } = null!;
}
