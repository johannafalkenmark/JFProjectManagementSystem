namespace Business.Models;

public class CustomerReference
{
    public int Id { get; set; }
    public string? Reference { get; set; }
    public Customer? Customer { get; set; }

}
