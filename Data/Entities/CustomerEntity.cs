
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

    public int CustomerReferenceId { get; set; }
    public CustomerReferenceEntity? CustomerReference { get; set; }


    ////om jag går via kund kan jag hämta alla projekt som tillhör den:
    public  ICollection<ProjectEntity> Projects = [];
}
