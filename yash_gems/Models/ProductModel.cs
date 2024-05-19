using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class ProductModel
    {
        [Key]
        [StringLength(10)]
        public string Prod_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Prod_Type { get; set; }
    }
}
