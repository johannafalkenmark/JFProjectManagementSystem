using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectManagerOrientationEntity
{

    [Key]
    public int Id { get; set; }

    public string? TypeOfOrientation { get; set; } 
}
