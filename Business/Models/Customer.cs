namespace Business.Models;

public class Customer
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public CustomerType? CustomerType { get; set; }

    public TypeOfIndustry? TypeOfIndustry { get; set; }

    public CustomerAddress? CustomerAddress { get; set; }

    public CustomerReference? CustomerReference { get; set; }

    public IEnumerable<Project> Projects { get; set; } = [];
}
