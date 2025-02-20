
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ServiceTypeEntity
{
    [Key]
    public int Id { get; set; }

    public string? TypeName { get; set; } 

    //kopplas till servicecategoryId:

    public int ServiceCategoryId { get; set; }
    public ServiceCategoryEntity? ServiceCategory { get; set; } 

}
