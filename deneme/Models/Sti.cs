using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace deneme.Models
{
    [Table("STI")]
    public partial class Sti
    {
        [Column("ID")]
        public int Id { get; set; }
        [Key]
        public short IslemTur { get; set; }
        [Key]
        [StringLength(16)]
        [Unicode(false)]
        public string EvrakNo { get; set; } = null!;
        [Key]
        public int Tarih { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string MalKodu { get; set; } = null!;
        [Column(TypeName = "numeric(25, 6)")]
        public decimal Miktar { get; set; }
        [Column(TypeName = "numeric(25, 6)")]
        public decimal Fiyat { get; set; }
        [Column(TypeName = "numeric(25, 6)")]
        public decimal Tutar { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string Birim { get; set; } = null!;
    }
}
