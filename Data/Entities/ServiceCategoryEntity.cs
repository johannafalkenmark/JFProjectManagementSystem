﻿
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ServiceCategoryEntity
{
    [Key]
    public int Id { get; set; }

    public string? CategoryName { get; set; } 

  


}
