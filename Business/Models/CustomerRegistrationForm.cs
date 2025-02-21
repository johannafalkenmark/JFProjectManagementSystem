namespace Business.Models;

public class CustomerRegistrationForm
{

    public string CustomerName { get; set; } = null!;

    public int CustomerTypeId { get; set; } 

    public int TypeOfIndustryId { get; set; }

    public int CustomerAddressId {  get; set; } 

    public int CustomerReferenceId { get; set; }    
}
