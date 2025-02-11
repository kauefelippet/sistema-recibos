﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;

namespace Recibo.Models;

[Table("recibo_provisorio_atos")]
[Index("AtoId", Name = "ato_id")]
[Index("ReciboProvisorioId", Name = "recibo_provisorio_id")]
public partial class ReciboProvisorioAto
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("recibo_provisorio_id")]
    public int? ReciboProvisorioId { get; set; }

    [Column("ato_id")]
    public int? AtoId { get; set; }

    [Column("descricao")]
    [StringLength(127)]
    public string Descricao { get; set; }

    [Column("quantidade")]
    public int Quantidade { get; set; }

    [NotMapped]
    public string AtoNome => Ato?.Nome;

    [NotMapped]
    public decimal Total => Ato.Total * Quantidade;

    [ForeignKey("AtoId")]
    [InverseProperty("ReciboProvisorioAtos")]
    public virtual Ato Ato { get; set; }

    [ForeignKey("ReciboProvisorioId")]
    [InverseProperty("ReciboProvisorioAtos")]
    public virtual Recibo ReciboProvisorio { get; set; }
}