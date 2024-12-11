﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recibo.Models;

[Table("atos")]
[Index("Nome", Name = "nome", IsUnique = true)]
public partial class Ato
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("nome")]
    [StringLength(3)]
    public string Nome { get; set; }

    [Column("custas_oficial")]
    [Precision(10, 2)]
    public decimal CustasOficial { get; set; }

    [Column("custas_iss")]
    [Precision(10, 2)]
    public decimal CustasIss { get; set; }

    [Column("custas_ipesp")]
    [Precision(10, 2)]
    public decimal CustasIpesp { get; set; }

    [Required]
    [Column("descricao")]
    [StringLength(63)]
    public string Descricao { get; set; }

    [NotMapped]
    public decimal Total => CustasIpesp + CustasIss + CustasOficial;

    [InverseProperty("Ato")]
    public virtual ICollection<ReciboAto> ReciboAtos { get; set; } = new List<ReciboAto>();

    [InverseProperty("Ato")]
    public virtual ICollection<ReciboProvisorioAto> ReciboProvisorioAtos { get; set; } = new List<ReciboProvisorioAto>();
}