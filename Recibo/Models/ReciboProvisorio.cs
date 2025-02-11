﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recibo.Models;

[Table("recibos_provisorios")]
public partial class Recibo
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("data", TypeName = "timestamp")]
    public DateTime? Data { get; set; }

    [Required]
    [Column("requerente")]
    [StringLength(255)]
    public string Requerente { get; set; }

    [Column("cpf")]
    [StringLength(11)]
    public string Cpf { get; set; }

    [NotMapped]
    public decimal Total => ReciboProvisorioAtos.Sum(a => a.Total);

    [InverseProperty("ReciboProvisorio")]
    public virtual ICollection<ReciboProvisorioAto> ReciboProvisorioAtos { get; set; } = new List<ReciboProvisorioAto>();

    [InverseProperty("ReciboProvisorio")]
    public virtual ICollection<ReciboDefinitivo> Recibos { get; set; } = new List<ReciboDefinitivo>();
}