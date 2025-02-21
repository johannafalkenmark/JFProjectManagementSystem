namespace Business.Models;

public class TypeOfIndustry
{
    public int Id { get; set; }

public string? TypeName { get; set; }

    public IEnumerable<Customer> Customers { get; set; } = [];


}
