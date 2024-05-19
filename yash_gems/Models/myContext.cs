using Microsoft.EntityFrameworkCore;
using yash_gems.Migrations;

namespace yash_gems.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options)
        {

        }

        // Admin Table
        public DbSet<AdminLoginModel> AdminLoginMst { get; set; }

        // User Table
        public DbSet<UsersModel> UserRegMst { get; set; }

        // Inquiry Table
        public DbSet<InquiryModel> Inquiry { get; set; }

        // Category Table
        public DbSet<CategoryModel> CatMst { get; set; }

        // Brand Table
        public DbSet<BrandModel> BrandMst { get; set; }

        // Product Table
        public DbSet<ProductModel> ProdMst { get; set; }

        // Dimaonds Quality Table 
        public DbSet<DiamondsQltyModel> DimQltyMst { get; set; }

        // Diamonds Sub Quality Table
        public DbSet<DiamondsQualitySubModel> DimQltySubMst { get; set; }

        // Diamonds Info Table
        public DbSet<DiamondsInfoModel> DimInfoMst { get; set; }

        // Diamonds Table
        public DbSet<DiamondsModel> DimMst { get; set; }

    }
}
