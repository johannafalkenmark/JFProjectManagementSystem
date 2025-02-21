

using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectNoteEntity
{
    [Key]
    public int Id { get; set; }

    public string? Notes { get; set; } 


    public ICollection<ProjectEntity> Projects = [];

}
