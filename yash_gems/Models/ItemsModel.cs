using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace yash_gems.Models
{
    public class ItemsModel
    {
        [Key]
        public int ItemId { get; set; }

        [MaxLength(50)]
        public string StyleCode { get; set; }

        [Range(0, 999)]
        public int Pairs { get; set; }

        [Required]
        [StringLength(10)]
        public string BrandID { get; set; }

        [Column(TypeName = "bigint default 0")]
        public int Quantity { get; set; }

        [Required]
        [StringLength(10)]
        public string CategoryID { get; set; }

        [MaxLength(50)]
        public string ProdQuality { get; set; }

        [Required]
        [StringLength(10)]
        public string CertifyID { get; set; }

        [Required]
        [StringLength(10)]
        public string ProdID { get; set; }

        [Required]
        [StringLength(10)]
        public string GoldTypeID { get; set; }

        [Column(TypeName = "decimal(10, 3)")]
        public decimal GoldWt { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal StoneWt { get; set; }

        [Column(TypeName = "decimal(10, 3)")]
        public decimal NetGold { get; set; }

        [Column(TypeName = "decimal(10, 3)")]
        public decimal WstgPer { get; set; }

        [Column(TypeName = "decimal(10, 3)")]
        public decimal Wstg { get; set; }

        [Column(TypeName = "decimal(10, 3)")]
        public decimal TotGrossWt { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal GoldRate { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal GoldAmt { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal GoldMaking { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal StoneMaking { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal OtherMaking { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotMaking { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal MRP { get; set; }

        [Required]
        [StringLength(500)]
        public string ImageUrl { get; set; } 

        public bool IsAvailable { get; set; } 

        public bool IsOnSale { get; set; }
    }
}
