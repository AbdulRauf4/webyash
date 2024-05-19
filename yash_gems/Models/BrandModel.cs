using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class BrandModel
    {
        [Key]
        [StringLength(10)]
        public string Brand_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand_Type { get; set; }
    }
}
