namespace yash_gems.Models
{
    public class DashboardListViewModel
    {
        public List<InquiryModel> InquiryList { get; set; } // List of inquiry table

        public List<CategoryModel> CategoryList { get; set; } // List of category table

        public List<ProductModel> ProductList { get; set; } // List of Product Table

        public List<BrandModel> BrandList { get; set; } // List of brand table
    }
}
