using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class DiamondsQltyModel
    {
        [Key]
        [StringLength(10)]
        public string DimQlty_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DimQlty { get; set; }
    }
}
