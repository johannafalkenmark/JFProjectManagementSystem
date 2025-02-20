
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectScheduleEntity
{
    [Key]
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; } 

    //koppling till project:
    public int ProjectId { get; set; }
    public ProjectEntity Project { get; set; } = null!;
}
