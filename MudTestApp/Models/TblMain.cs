using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


#nullable disable

namespace MudTestApp.Models
{
    [Table("tblMain")]
    public partial class TblMain
    {
        [Key]
        [Column("MT")]
        public int Mt { get; set; }
        [StringLength(255)]
        public string Customer { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        [StringLength(255)]
        public string LabTech { get; set; }
        [StringLength(255)]
        public string MudType { get; set; }
        [StringLength(255)]
        public string MudSystemName { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public int? ExposureTime { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? DateOut { get; set; }
        public DateTime? TimeOut { get; set; }
        [Column("LegacyMT")]
        public int? LegacyMt { get; set; }
        public string SpecialInstructions { get; set; }
        [Column("RMA")]
        [StringLength(15)]
        public string Rma { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }


        //tp code
        public int CompoundId { get; set; }  //foreign key property
        public Compound Compound { get; set; } //navigation property
    }
}
