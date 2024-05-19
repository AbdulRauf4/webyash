using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class InquiryModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(10)]
        public string Contact { get; set; }

        [Required]
        [EmailAddress]
        public string EmailID { get; set; }

        [Required]
        [MaxLength]
        public string Comment { get; set; }

        [Required]
        public DateTime Cdate { get; set; }
    }
}
