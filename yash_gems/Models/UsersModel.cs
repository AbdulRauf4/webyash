using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class UsersModel
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [MaxLength(125)]
        public string UserFname { get; set; }

        [Required]
        [MaxLength(125)]
        public string UserLname { get; set; }

        [MaxLength]
        public string Address { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(20)]
        public string MobNo { get; set; }

        [Required]
        [EmailAddress]
        public string EmailID { get; set; }

        [MaxLength(50)]
        public string DOB { get; set; }

        [Required]
        public DateTime Cdate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
