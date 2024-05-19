using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class StonesModel
    {
        [Key]
        public int StoneId { get; set; }

        [StringLength(50)]
        public string Style_Code { get; set; }

        [StringLength(50)]
        public string StoneQlty_ID { get; set; }

        [Required]
        [Range(0, 999)]
        public decimal Stone_Gm { get; set; }

        [Required]
        [Range(0, 999)]
        public decimal Stone_Pcs { get; set; }

        [Required]
        [Range(0, 999)]
        public decimal Stone_Crt { get; set; }

        [Required]
        [Range(0, 999)]
        public decimal Stone_Rate { get; set; }

        [Required]
        [Range(0, 999)]
        public decimal Stone_Amt { get; set; }
    }
}
