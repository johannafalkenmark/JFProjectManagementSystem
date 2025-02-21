

using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class StatusTypeEntity
{
    [Key]

    public int Id { get; set; }

    public string TypeName { get; set; } = null!;


    ////om jag går via StatusType kan jag hämta alla projekt:
    public ICollection<ProjectEntity> Projects = [];

}
