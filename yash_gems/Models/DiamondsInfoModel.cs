using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class DiamondsInfoModel
    {
        [Key]
        [StringLength(10)]
        public string DimID { get; set; }

        [Required]
        [StringLength(10)]
        public string DimType { get; set; }

        [Required]
        [StringLength(10)]
        public string DimSubType { get; set; }

        [Required]
        [StringLength(50)]
        public string DimCrt { get; set; }

        [Required]
        [StringLength(50)]
        public string DimPrice { get; set; }

        [Required]
        [StringLength(255)]
        public string DimImg { get; set; }
    }
}
