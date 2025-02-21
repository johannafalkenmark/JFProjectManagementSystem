
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectScheduleEntity
{
    [Key]
    public int Id { get; set; }

    public DateOnly StartDate { get; set; } 

    public DateOnly EndDate { get; set; } 

  

    public ICollection<ProjectEntity> Projects = [];
}
