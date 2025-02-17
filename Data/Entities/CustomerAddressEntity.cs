
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CustomerAddressEntity
{

    [Key]
    public int Id { get; set; }

    public string? Address { get; set; }

}
