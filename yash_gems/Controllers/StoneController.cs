using Microsoft.AspNetCore.Mvc;

namespace yash_gems.Controllers
{
    public class StoneController : Controller
    {
        public IActionResult Stones()
        {
            // Login Access
            string adminU_Name = HttpContext.Session.GetString("admin_username");
            string adminF_Name = HttpContext.Session.GetString("admin_fullname");

            if (adminU_Name != null)
            {
                ViewBag.Admin_UserName = adminU_Name;
                ViewBag.Admin_FullName = adminF_Name;

                return View();
            }
            else
            {
                ViewBag.Error = "Login problem";
                return RedirectToAction("LoginRegister", "Home");
            }
        }
    }
}
