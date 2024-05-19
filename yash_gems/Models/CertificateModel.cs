using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class CertificateModel
    {
        [Key]
        [StringLength(10)]
        public string Certify_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Certify_Type { get; set;  }
    }
}
