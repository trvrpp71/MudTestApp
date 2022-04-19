using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MudTestApp.Models.DataLayer
{
    [Keyless]
    [Table("MSysCompactError")]
    public partial class MsysCompactError
    {
        public int? ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        [MaxLength(510)]
        public byte[] ErrorRecid { get; set; }
        [StringLength(255)]
        public string ErrorTable { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
