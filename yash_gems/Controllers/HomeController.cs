using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using yash_gems.Models;

namespace yash_gems.Controllers
{
    public class HomeController : Controller
    {
        private myContext _context;

        public HomeController(myContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Login & Register Start
        public IActionResult LoginRegister()
        {
            return View();
        }

        // Admin Login
        [HttpPost]
        public IActionResult AdminLogin(string getusername, string getpassword)
        {
            var row = _context.AdminLoginMst.FirstOrDefault(u => u.userName == getusername || u.Email == getusername);

            if (row != null && row.Password == getpassword)
            {
                HttpContext.Session.SetString("admin_username", row.userName);
                HttpContext.Session.SetString("admin_fullname", row.Full_Name);

                ViewBag.Message = "Admin Logged in Successfully";

                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                ViewBag.Message = "Incorrect Username or password";
                return RedirectToAction("LoginRegister", "Home");
            }
        }

        // User Register
        [HttpPost]
        public IActionResult UserRegister(UsersModel userReg)
        {
            try
            {
                _context.UserRegMst.Add(userReg);
                _context.SaveChanges();
                ViewBag.Message = "Successfully Registered ?";
                return RedirectToAction("LoginRegister", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Registeration Failed Check" + ex.Message;
                return RedirectToAction("LoginRegister", "Home");
            }
        }

        // User Login
        public IActionResult UserLogin(string getEmail, string getpass)
        {
            var userRow = _context.UserRegMst.FirstOrDefault(u => u.EmailID == getEmail);

            if (userRow != null && userRow.Password == getpass)
            {
                HttpContext.Session.SetString("user_email", userRow.EmailID);
                HttpContext.Session.SetString("user_pass", userRow.Password);
                HttpContext.Session.SetString("user_fullname", $"{userRow.UserFname} {userRow.UserLname}");
                HttpContext.Session.SetString("user_f_name", userRow.UserFname);
                HttpContext.Session.SetString("user_l_name", userRow.UserLname);
                HttpContext.Session.SetString("user_mobile", userRow.MobNo);
                HttpContext.Session.SetString("user_state", userRow.State);
                HttpContext.Session.SetString("user_address", userRow.Address);
                HttpContext.Session.SetString("user_city", userRow.City);
                HttpContext.Session.SetString("user_dob", userRow.DOB);

                ViewBag.Message = "Successfully Logged in";

                return RedirectToAction("myAccount", "User");
            }
            else
            {
                ViewBag.Error = "Incorrect Username or password";
                return RedirectToAction("LoginRegister", "Home");
            }
        }

        // Update User Data
        [HttpPost]
        public IActionResult UserUpdate(UsersModel userup)
        {
            try
            {
                _context.UserRegMst.Update(userup);
                _context.SaveChanges();
                ViewBag.Message = "Account Updated";
                return RedirectToAction("myAccount", "Home");
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Something went wrong" + ex.Message;
                return RedirectToAction("myAccount", "Home");
            }
        }

        // User Logout
        public IActionResult UserLogout()
        {
            HttpContext.Session.Remove("user_email");
            HttpContext.Session.Remove("user_pass");
            HttpContext.Session.Remove("user_fullname");
            HttpContext.Session.Remove("user_f_name");
            HttpContext.Session.Remove("user_l_name");
            HttpContext.Session.Remove("user_state");
            HttpContext.Session.Remove("user_address");
            HttpContext.Session.Remove("user_city");
            HttpContext.Session.Remove("user_dob");

            return RedirectToAction("LoginRegister", "Home");
        }
                
        // Contact Action
        public IActionResult Contact()
        {
            return View();
        }

        // Inquiry Contact Action
        [HttpPost]
        public IActionResult SendInquiry(InquiryModel inq)
        {
            _context.Inquiry.Add(inq);
            _context.SaveChanges();
            ViewBag.Message = "Thank You for Contacting!";
            return RedirectToAction("Index", "Home");
        }

        // About Action
        public IActionResult About()
        {
            return View();
        }

        // Shop Action
        public IActionResult Shop()
        {
            return View();
        }

        // Shopping Cart Action
        public IActionResult Cart()
        {
            string userEmail = HttpContext.Session.GetString("user_email");
            string userPass = HttpContext.Session.GetString("user_pass");

            // User Extra Details 
            string userName = HttpContext.Session.GetString("user_fullname");
            string userFName = HttpContext.Session.GetString("user_f_name");
            string userLName = HttpContext.Session.GetString("user_l_name");
            string userMob = HttpContext.Session.GetString("user_mobile");
            string userState = HttpContext.Session.GetString("user_state");
            string userAddress = HttpContext.Session.GetString("user_address");
            string userCity = HttpContext.Session.GetString("user_city");
            string userDob = HttpContext.Session.GetString("user_dob");


            if (userEmail != null)
            {
                ViewBag.UserEmail = userEmail;
                ViewBag.UserPass = userPass;
                ViewBag.UserName = userName;
                ViewBag.UserF_name = userFName;
                ViewBag.UserL_name = userLName;
                ViewBag.UserMob = userMob;
                ViewBag.UserState = userState;
                ViewBag.UserAddress = userAddress;
                ViewBag.UserCity = userCity;
                ViewBag.UserDob = userDob;

                return View();
            }
            else
            {
                ViewBag.Message = "Something Went Wrong";

                return RedirectToAction("LoginRegister", "Home");
            }
        }

        // WishList Action
        public IActionResult Wishlist()
        {
            string userEmail = HttpContext.Session.GetString("user_email");
            string userPass = HttpContext.Session.GetString("user_pass");

            // User Extra Details 
            string userName = HttpContext.Session.GetString("user_fullname");
            string userFName = HttpContext.Session.GetString("user_f_name");
            string userLName = HttpContext.Session.GetString("user_l_name");
            string userMob = HttpContext.Session.GetString("user_mobile");
            string userState = HttpContext.Session.GetString("user_state");
            string userAddress = HttpContext.Session.GetString("user_address");
            string userCity = HttpContext.Session.GetString("user_city");
            string userDob = HttpContext.Session.GetString("user_dob");


            if (userEmail != null)
            {
                ViewBag.UserEmail = userEmail;
                ViewBag.UserPass = userPass;
                ViewBag.UserName = userName;
                ViewBag.UserF_name = userFName;
                ViewBag.UserL_name = userLName;
                ViewBag.UserMob = userMob;
                ViewBag.UserState = userState;
                ViewBag.UserAddress = userAddress;
                ViewBag.UserCity = userCity;
                ViewBag.UserDob = userDob;

                return View();
            }
            else
            {
                ViewBag.Message = "Something Went Wrong";

                return RedirectToAction("LoginRegister", "Home");
            }
        }

        // Checkout Action
        public IActionResult Checkout()
        {
            string userEmail = HttpContext.Session.GetString("user_email");
            string userPass = HttpContext.Session.GetString("user_pass");

            // User Extra Details 
            string userName = HttpContext.Session.GetString("user_fullname");
            string userFName = HttpContext.Session.GetString("user_f_name");
            string userLName = HttpContext.Session.GetString("user_l_name");
            string userMob = HttpContext.Session.GetString("user_mobile");
            string userState = HttpContext.Session.GetString("user_state");
            string userAddress = HttpContext.Session.GetString("user_address");
            string userCity = HttpContext.Session.GetString("user_city");
            string userDob = HttpContext.Session.GetString("user_dob");


            if (userEmail != null)
            {
                ViewBag.UserEmail = userEmail;
                ViewBag.UserPass = userPass;
                ViewBag.UserName = userName;
                ViewBag.UserF_name = userFName;
                ViewBag.UserL_name = userLName;
                ViewBag.UserMob = userMob;
                ViewBag.UserState = userState;
                ViewBag.UserAddress = userAddress;
                ViewBag.UserCity = userCity;
                ViewBag.UserDob = userDob;

                return View();
            }
            else
            {
                ViewBag.Message = "Something Went Wrong";

                return RedirectToAction("LoginRegister", "Home");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
