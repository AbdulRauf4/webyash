using Microsoft.AspNetCore.Mvc;
using yash_gems.Models;

namespace yash_gems.Controllers
{
    public class AdminController : Controller
    {
        private myContext _context;
        private IWebHostEnvironment _evn;

        public AdminController(myContext context, IWebHostEnvironment evn)
        {
            _context = context;
            _evn = evn;
        }

        public IActionResult Dashboard()
        {
            // Total Users
            int totalUsers = _context.UserRegMst.Count();
            ViewBag.TotalUsers = totalUsers;

            // Total Inquiries
            int totalInquiry = _context.Inquiry.Count();
            ViewBag.TotalInquiry = totalInquiry;

            // Total Categories
            int totalCategory = _context.CatMst.Count();
            ViewBag.TotalCategory = totalCategory;

            // Total Products
            int totalProduct = _context.ProdMst.Count();
            ViewBag.TotalProduct = totalProduct;

            // Total Brands
            int totalBrand = _context.BrandMst.Count();
            ViewBag.TotalBrand = totalBrand;

            // All List View Models
            DashboardListViewModel dlvm = new DashboardListViewModel()
            {
                InquiryList = _context.Inquiry.ToList(),
                CategoryList = _context.CatMst.ToList(),
                ProductList = _context.ProdMst.ToList(),
                BrandList = _context.BrandMst.ToList(),
            };

            // Login Access
            string adminU_Name = HttpContext.Session.GetString("admin_username");
            string adminF_Name = HttpContext.Session.GetString("admin_fullname");

            if (adminU_Name != null)
            {
                ViewBag.Admin_UserName = adminU_Name;
                ViewBag.Admin_FullName = adminF_Name;

                return View(dlvm);
            }
            else
            {
                return RedirectToAction("LoginRegister", "Home");
            }
        }

        // Account Logut Action
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("admin_username");
            HttpContext.Session.Remove("admin_fullname");
            return RedirectToAction("Index", "Home");
        }

        // Delete Inquiry Row
        public IActionResult delInquiry(int id)
        {
            var inq = _context.Inquiry.Find(id);
            _context.Inquiry.Remove(inq);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Admin");
        }

        // Add Category
        [HttpPost]
        public IActionResult addCategory(CategoryModel categ)
        {
            try
            {
                _context.CatMst.Add(categ);
                _context.SaveChanges();
                ViewBag.Message = "Category Added ✔";
                return RedirectToAction("Dashboard", "Admin");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Something Went wrong!" + ex.Message;
                return RedirectToAction("Dashboard", "Admin");
            }
        }
        // Edit Category Fetch 
        public IActionResult editCategory(string id)
        {
            var row = _context.CatMst.Find(id);
            return View(row);
        }
        // Edit Category
        [HttpPost]
        public IActionResult editCategory(CategoryModel categ)
        {
            _context.CatMst.Update(categ);
            _context.SaveChanges();
            ViewBag.Message = "Updated Category ✔";
            return RedirectToAction("Dashboard", "Admin");
        }
        // Delete Category
        public IActionResult delCategory(string id)
        {
            var cat = _context.CatMst.Find(id);
            _context.CatMst.Remove(cat);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Admin");
        }

        // Add Product
        [HttpPost]
        public IActionResult addProduct(ProductModel prod)
        {
            try
            {
                _context.ProdMst.Add(prod);
                _context.SaveChanges();
                ViewBag.Message = "Product Added ✔";
                return RedirectToAction("Dashboard", "Admin");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Something Went wrong!" + ex.Message;
                return RedirectToAction("Dashboard", "Admin");
            }
        }
        // Edit Product Fetch 
        public IActionResult editProduct(string id)
        {
            var row = _context.ProdMst.Find(id);
            return View(row);
        }
        // Edit Product
        [HttpPost]
        public IActionResult editProduct(ProductModel prod)
        {
            _context.ProdMst.Update(prod);
            _context.SaveChanges();
            ViewBag.Message = "Updated Product ✔";
            return RedirectToAction("Dashboard", "Admin");
        }
        // Delete Product
        public IActionResult delProduct(string id)
        {
            var prod = _context.ProdMst.Find(id);
            _context.ProdMst.Remove(prod);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Admin");
        }

        // Add Brand
        [HttpPost]
        public IActionResult addBrand(BrandModel brand)
        {
            try
            {
                _context.BrandMst.Add(brand);
                _context.SaveChanges();
                ViewBag.Message = "Brand Added ✔";
                return RedirectToAction("Dashboard", "Admin");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Something Went wrong!" + ex.Message;
                return RedirectToAction("Dashboard", "Admin");
            }
        }
        // Edit Brand Fetch 
        public IActionResult editBrand(string id)
        {
            var row = _context.BrandMst.Find(id);
            return View(row);
        }
        // Edit Brand
        [HttpPost]
        public IActionResult editBrand(BrandModel brand)
        {
            _context.BrandMst.Update(brand);
            _context.SaveChanges();
            ViewBag.Message = "Updated Brand ✔";
            return RedirectToAction("Dashboard", "Admin");
        }
        // Delete Brand
        public IActionResult delBrand(string id)
        {
            var brand = _context.BrandMst.Find(id);
            _context.BrandMst.Remove(brand);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Admin");
        }

        //          ********************        Dashboard Page Actions End

        //          ******************************************

        //          ********************        Diamond Page Actions Start

        

        //          ********************        Diamond Page Actions End

        //          ******************************************

        //          ********************        Stones Page Actions Start

        public IActionResult Stones()
        {
            return View();
        }

        
        

        //          ********************        Stones Page Actions End

        //          ******************************************

        //          ********************        Items Page Actions Start

        public IActionResult Items()
        {
            return View();
        }

        //          ********************        Items Page Actions End

        //          ******************************************

        //          ********************        Jewellery AND Gold Page Actions Start

        public IActionResult JewelleryandGold()
        {
            return View();
        }

        //          ********************        Items Page Actions End

        //          ******************************************

        //          ********************        Users Page Actions Start

        public IActionResult Users()
        {
            return View();
        }

    }
}
