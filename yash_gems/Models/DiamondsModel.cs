using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class DiamondsModel
    {
        [Key]
        public int D_Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Style_Code { get; set; }

        [Required]
        [StringLength(10)]
        public string DimQlty { get; set; }

        [Required]
        [StringLength(10)]
        public string DimSubType { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Dim_Crt { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Dim_Pcs { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Dim_Gm { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Dim_Size { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Dim_Rate { get; set; }

        [Required]
        [Column(TypeName = "numeric(10,2)")]
        public decimal Dim_Amt { get; set; }
    }
}
