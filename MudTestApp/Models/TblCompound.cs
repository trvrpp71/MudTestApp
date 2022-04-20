using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MudTestApp.Models
{
    [Table("tblCompounds")]
    public partial class TblCompound
    {
        [Key]
        [Column("CompoundID")]
        public int CompoundId { get; set; }
        [StringLength(255)]
        public string Compound { get; set; }
        public int? Hardness { get; set; }
        [Column("25_Mod")]
        public int? _25Mod { get; set; }
        [Column("50_Mod")]
        public int? _50Mod { get; set; }
        [Column("100_Mod")]
        public int? _100Mod { get; set; }
        public int? Tensile { get; set; }
        public int? Elongation { get; set; }
        public bool Development { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }

        //tp added code
        public ICollection<Test> Tests { get; set; } //navigation property

    }
}
