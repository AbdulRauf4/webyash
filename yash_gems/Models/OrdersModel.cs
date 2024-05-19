using System;
using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class OrdersModel
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        public string CustomerEmail { get; set; }

        [Required]
        [Phone]
        public string CustomerPhone { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerCity { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerPostalCode { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerCountry { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerState { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerZipCode { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public int OrderStatus { get; set; } = 0; // Default value set to 0
    }
}
