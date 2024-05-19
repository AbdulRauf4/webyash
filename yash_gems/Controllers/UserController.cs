using Microsoft.AspNetCore.Mvc;

namespace yash_gems.Controllers
{
    public class UserController : Controller
    {
        public IActionResult myAccount()
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

                ViewBag.Message = "Login Successfully";
                return View();
            }
            else
            {
                ViewBag.Message = "Something Went Wrong";

                return RedirectToAction("LoginRegister", "Home");
            }
        }
    }
}
