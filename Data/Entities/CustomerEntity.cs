
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CustomerEntity
{
    [Key]
    public int Id { get; set; }
    public string CustomerName { get; set; } = null!;


    
    public int CustomerTypeId { get; set; }
    public CustomerTypeEntity? CustomerType { get; set; } 


    public int TypeOfIndustryId { get; set; }
    public TypeOfIndustryEntity? TypeOfIndustry { get; set; }


    public int CustomerAddressId { get; set; }
    public CustomerAddressEntity? CustomerAddress { get; set; } 


    ////om jag går via kund kan jag hämta alla projekt:
    public  ICollection<ProjectEntity> Projects = [];
}
