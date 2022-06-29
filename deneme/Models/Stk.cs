using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace deneme.Models
{
    [Table("STK")]
    public partial class Stk
    {
        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MalKodu { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string MalAdi { get; set; } = null!;

    }
}
