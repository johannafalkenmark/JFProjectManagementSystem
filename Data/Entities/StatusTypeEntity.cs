﻿

using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class StatusTypeEntity
{
    [Key]

    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    //Är en lista
}
