

using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectNoteEntity
{
    [Key]
    public int Id { get; set; }

    public string? Notes { get; set; } 

    //koppling till project:
    public int ProjectId { get; set; }
    public ProjectEntity? Project { get; set; } 

}
