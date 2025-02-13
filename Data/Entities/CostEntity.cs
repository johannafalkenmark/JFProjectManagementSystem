
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CostEntity
{
    [Key]
    public int Id { get; set; }

    public int Cost { get; set; }

    //Kopplas till ServiceTypeId:

    public int ServiceTypeId { get; set; }
    public ServiceTypeEntity ServiceType { get; set; } = null!;
}
