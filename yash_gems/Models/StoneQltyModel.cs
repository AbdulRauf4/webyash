using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class StoneQltyModel
    {
        [Key]
        [StringLength(10)]
        public string StoneQlty_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string StoneQlty { get; set; }
    }
}
