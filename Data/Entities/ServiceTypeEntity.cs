
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ServiceTypeEntity
{
    [Key]
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    //kopplas till servicecategoryId:

    public int ServiceCategoryId { get; set; }
    public ServiceCategoryEntity? ServiceCategory { get; set; }


    ////om jag går via ServiceType kan jag hämta alla projekt:
    public ICollection<ProjectEntity> Projects = [];

}
