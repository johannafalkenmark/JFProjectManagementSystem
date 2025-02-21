using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectManagerEntity
{
    [Key]
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;


    //Kopplas till typeoforientation
    public int TypeOfOrientationId { get; set; }
    public ProjectManagerOrientationEntity? TypeOfOrientation { get; set; }

    ////om jag går via Project manager kan jag hämta alla projekt:
    public ICollection<ProjectEntity> Projects = [];
}
