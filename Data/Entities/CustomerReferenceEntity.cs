
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CustomerReferenceEntity
{


    [Key]
    public int Id { get; set; }

    public string Reference { get; set; } = null!;

    //Kopplas till CustomerId:
    public int CustomerId { get; set; }
    public CustomerEntity Customer { get; set; } = null!;
}
