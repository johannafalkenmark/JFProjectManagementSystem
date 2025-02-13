
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class TypeOfIndustryEntity
{

    [Key]
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;
}
