using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class DiamondsQualitySubModel
    {
        [Key]
        [StringLength(10)]
        public string DimSubType_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string DimQlty { get; set; }

        [Required]
        [StringLength(50)]
        public string DimSubType { get; set; }
    }
}
