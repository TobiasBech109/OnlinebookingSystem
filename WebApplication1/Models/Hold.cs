﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;




[Table("Hold")]
public partial class Hold
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Navn { get; set; }

    [InverseProperty("Hold")]
    public virtual ICollection<Fag> Fags { get; set; } = new List<Fag>();
}