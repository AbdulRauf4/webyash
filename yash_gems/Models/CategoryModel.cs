using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class CategoryModel
    {
        [Key]
        [StringLength(10)]
        public string Cat_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Cat_Name { get; set; }
    }
}
