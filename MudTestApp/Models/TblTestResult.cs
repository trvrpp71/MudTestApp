using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MudTestApp.Models
{
    [Table("tblTestResults")]
    public partial class TblTestResult
    {
        [Key]
        [Column("TestID")]
        public int TestId { get; set; }
        [Column("MT")]
        public int? Mt { get; set; }
        [Column("CompoundID")]
        public int? CompoundId { get; set; }
        public int? TestTemp { get; set; }
        [Column("Thickness_1")]
        public double? Thickness1 { get; set; }
        [Column("ShoreAB_1")]
        public double? ShoreAb1 { get; set; }
        [Column("ShoreAA_1")]
        public double? ShoreAa1 { get; set; }
        [Column("Wt_AirB_1")]
        public double? WtAirB1 { get; set; }
        [Column("Wt_AirA_1")]
        public double? WtAirA1 { get; set; }
        [Column("Wt_WaterB_1")]
        public double? WtWaterB1 { get; set; }
        [Column("Wt_WaterA_1")]
        public double? WtWaterA1 { get; set; }
        [Column("25_Mod_1")]
        public int? _25Mod1 { get; set; }
        [Column("50_Mod_1")]
        public int? _50Mod1 { get; set; }
        [Column("100_Mod_1")]
        public int? _100Mod1 { get; set; }
        [Column("Tensile_1")]
        public int? Tensile1 { get; set; }
        [Column("Elongation_1")]
        public int? Elongation1 { get; set; }
        [Column("Thickness_2")]
        public double? Thickness2 { get; set; }
        [Column("ShoreAB_2")]
        public double? ShoreAb2 { get; set; }
        [Column("ShoreAA_2")]
        public double? ShoreAa2 { get; set; }
        [Column("Wt_AirB_2")]
        public double? WtAirB2 { get; set; }
        [Column("Wt_AirA_2")]
        public double? WtAirA2 { get; set; }
        [Column("Wt_WaterB_2")]
        public double? WtWaterB2 { get; set; }
        [Column("Wt_WaterA_2")]
        public double? WtWaterA2 { get; set; }
        [Column("25_Mod_2")]
        public int? _25Mod2 { get; set; }
        [Column("50_Mod_2")]
        public int? _50Mod2 { get; set; }
        [Column("100_Mod_2")]
        public int? _100Mod2 { get; set; }
        [Column("Tensile_2")]
        public int? Tensile2 { get; set; }
        [Column("Elongation_2")]
        public int? Elongation2 { get; set; }
        [Column("Thickness_3")]
        public double? Thickness3 { get; set; }
        [Column("ShoreAB_3")]
        public double? ShoreAb3 { get; set; }
        [Column("ShoreAA_3")]
        public double? ShoreAa3 { get; set; }
        [Column("Wt_AirB_3")]
        public double? WtAirB3 { get; set; }
        [Column("Wt_AirA_3")]
        public double? WtAirA3 { get; set; }
        [Column("Wt_WaterB_3")]
        public double? WtWaterB3 { get; set; }
        [Column("Wt_WaterA_3")]
        public double? WtWaterA3 { get; set; }
        [Column("25_Mod_3")]
        public int? _25Mod3 { get; set; }
        [Column("50_Mod_3")]
        public int? _50Mod3 { get; set; }
        [Column("100_Mod_3")]
        public int? _100Mod3 { get; set; }
        [Column("Tensile_3")]
        public int? Tensile3 { get; set; }
        [Column("Elongation_3")]
        public int? Elongation3 { get; set; }
        public string VisualObservations { get; set; }
        [Column("AVGHardness")]
        public int? Avghardness { get; set; }
        [Column("CIP")]
        public bool Cip { get; set; }
        public int? ExposureTime { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
