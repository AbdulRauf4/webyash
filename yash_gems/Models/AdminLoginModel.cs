using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class AdminLoginModel
    {
        [Key]
        public int Admin_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string userName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Full_Name { get; set; }
    }
}
