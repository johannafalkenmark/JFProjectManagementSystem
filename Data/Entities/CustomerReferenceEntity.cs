
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CustomerReferenceEntity
{


    [Key]
    public int Id { get; set; }

    public string? Reference { get; set; }

 

    //Navigation property
    public ICollection<CustomerEntity> Customers = [];
}
