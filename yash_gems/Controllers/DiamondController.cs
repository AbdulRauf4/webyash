using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using yash_gems.Models;

namespace yash_gems.Controllers
{
    public class DiamondController : Controller
    {
        private myContext _context;
        private IWebHostEnvironment _evn;

        public DiamondController(myContext context, IWebHostEnvironment evn)
        {
            _context = context;
            _evn = evn;
        }

        public IActionResult Diamonds()
        {
            // Counter
            int[] dimtable = new int[4];
            dimtable[0] = _context.DimQltyMst.Count();
            dimtable[1] = _context.DimQltySubMst.Count();
            dimtable[2] = _context.DimInfoMst.Count();
            dimtable[3] = _context.DimMst.Count();
            ViewBag.dimtable = dimtable;

            DiamondsViewModel dvm = new DiamondsViewModel()
            {
                listDimQlty = _context.DimQltyMst.ToList(),
                listDimSubQlty = _context.DimQltySubMst.ToList(),
                listDimInfo = _context.DimInfoMst.ToList(),
                listDims = _context.DimMst.ToList(),
            };

            // Login Access Code
            string adminU_Name = HttpContext.Session.GetString("admin_username");
            string adminF_Name = HttpContext.Session.GetString("admin_fullname");

            if (adminU_Name != null)
            {
                ViewBag.Admin_UserName = adminU_Name;
                ViewBag.Admin_FullName = adminF_Name;

                return View(dvm);
            }
            else
            {
                return RedirectToAction("LoginRegister", "Home");
            }
        }

        // Add Diamond Info Action
        [HttpPost]
        public IActionResult addDiamondInfo(DiamondsInfoModel dimInfo, IFormFile DimImg)
        {
            if (DimImg != null)
            {
                // New file path inside wwwroot/assets/diamondsimages
                var filePath = Path.Combine(_evn.WebRootPath, "/assets/", "diamondsimages/", DimImg.FileName);
                using (var diamond = new FileStream(filePath, FileMode.Create))
                {
                    DimImg.CopyTo(diamond);
                }
                dimInfo.DimImg = DimImg.FileName;
            }

            try
            {
                _context.DimInfoMst.Add(dimInfo);
                _context.SaveChanges();
                ViewBag.Message = "Diamond Information Added ✔";
                return RedirectToAction("Diamonds", "Diamond");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Addition failed: " + ex.Message;
                return RedirectToAction("Diamonds", "Diamond");
            }
        }

        // Edit Diamond Info Action
        public IActionResult editDiamondInfo(string id)
        {
            var findDimInfo = _context.DimInfoMst.Find(id);
            return View(findDimInfo);
        }
        [HttpPost]
        public IActionResult editDiamondInfo(DiamondsInfoModel diminfo)
        {
            try
            {
                _context.DimInfoMst.Update(diminfo);
                _context.SaveChanges();
                ViewBag.Message = "Diamond Information Updated ✔";
                return RedirectToAction("Diamonds", "Diamond");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Update failed" + ex.Message;
                return RedirectToAction("Diamonds", "Diamond");
            }
        }

        // Delete Diamond Info Action
        public IActionResult delDiamondInfo(int id)
        {
            var findDimInfo = _context.DimInfoMst.Find(id);
            if (findDimInfo != null)
            {
                _context.DimInfoMst.Remove(findDimInfo);
                ViewBag.Message = "Diamond Information Row Deleted";
                return RedirectToAction("Diamonds", "Diamond");
            }
            else
            {
                ViewBag.Message = "Oops! Diamond Information row not found.";
                return RedirectToAction("Diamonds", "Diamond");
            }
        }

        // Add Diamond Action
        [HttpPost]
        public IActionResult addDiamond(DiamondsModel dim)
        {
            try
            {
                _context.DimMst.Add(dim);
                _context.SaveChanges();
                ViewBag.Message = "Diamond Added ✔";
                return RedirectToAction("Diamonds", "Diamond");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Added Failed" + ex.Message;
                return RedirectToAction("Diamonds", "Diamond");
            }
        }
        // Edit Diamond Action
        public IActionResult editDiamond(string id)
        {
            var findDim = _context.DimMst.Find(id);
            return View(findDim);
        }
        [HttpPost]
        public IActionResult editDiamond(DiamondsModel dim)
        {
            try
            {
                _context.DimMst.Update(dim);
                _context.SaveChanges();
                ViewBag.Message = "Diamond Updated ✔";
                return RedirectToAction("Diamonds", "Diamond");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Update failed" + ex.Message;
                return RedirectToAction("Diamonds", "Diamond");
            }
        }

        // Delete Diamond Action
        public IActionResult delDiamond(int id)
        {
            var findDim = _context.DimMst.Find(id);
            if (findDim != null)
            {
                _context.DimMst.Remove(findDim);
                ViewBag.Message = "Diamond Row Deleted";
                return RedirectToAction("Diamonds", "Diamond");
            }
            else
            {
                ViewBag.Message = "Oops! Diamond row not found.";
                return RedirectToAction("Diamonds", "Diamond");
            }
        }

        // Add Diamond Quality Action
        [HttpPost]
        public IActionResult addDiamondQlty(DiamondsQltyModel dimqlty)
        {
            _context.DimQltyMst.Add(dimqlty);
            _context.SaveChanges();
            ViewBag.Message = "Diamond Quality Added ✔";
            return RedirectToAction("Diamonds", "Diamond");
        }
        // Edit Diamond Quality Action
        public IActionResult editDiamondQlty(string id)
        {
            var findDimQlty = _context.DimQltyMst.Find(id);
            return View(findDimQlty);
        }
        [HttpPost]
        public IActionResult editDiamondQlty(DiamondsQltyModel dimqlty)
        {
            try
            {
                _context.DimQltyMst.Update(dimqlty);
                _context.SaveChanges();
                ViewBag.Message = "Diamond Quality Updated ✔";
                return RedirectToAction("Diamonds", "Diamond");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Update failed" + ex.Message;
                return RedirectToAction("Diamonds", "Diamond");
            }
        }

        // Delete Diamond Quality Action
        public IActionResult delDiamondQlty(int id)
        {
            var findDimQlty = _context.DimQltyMst.Find(id);
            if (findDimQlty != null)
            {
                _context.DimQltyMst.Remove(findDimQlty);
                ViewBag.Message = "Diamond Quality Row Deleted";
                return RedirectToAction("Diamonds", "Diamond");
            }
            else
            {
                ViewBag.Message = "Oops! Diamond Quality row not found.";
                return RedirectToAction("Diamonds", "Diamond");
            }
        }

        // Add Diamond Sub Quality Action
        [HttpPost]
        public IActionResult addDiamondSubQlty(DiamondsQualitySubModel dimsubqlty)
        {
            try
            {
                _context.DimQltySubMst.Add(dimsubqlty);
                _context.SaveChanges();
                ViewBag.Message = "Diamond Quality Added ✔";
                return RedirectToAction("Diamonds", "Diamond");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Added Failed" + ex.Message;
                return RedirectToAction("Diamonds", "Diamond");
            }
        }
        // Edit Diamond Sub Quality Action
        public IActionResult editDiamondSubQlty(string id)
        {
            var findDimSubqQlty = _context.DimQltySubMst.Find(id);
            return View(findDimSubqQlty);
        }
        [HttpPost]
        public IActionResult editDiamondSubQlty(DiamondsQualitySubModel dimsubqlty)
        {
            try
            {
                _context.DimQltySubMst.Update(dimsubqlty);
                _context.SaveChanges();
                ViewBag.Message = "Diamond Sub Quality Updated ✔";
                return RedirectToAction("Diamonds", "Diamond");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Update failed" + ex.Message;
                return RedirectToAction("Diamonds", "Diamond");
            }
        }

        // Delete Diamond Sub Quality Action
        public IActionResult delDiamondSubQlty(int id)
        {
            var findDimSubQlty = _context.DimQltySubMst.Find(id);
            if (findDimSubQlty != null)
            {
                _context.DimQltySubMst.Remove(findDimSubQlty);
                ViewBag.Message = "Diamond Sub Quality Row Deleted";
                return RedirectToAction("Diamonds", "Diamond");
            }
            else
            {
                ViewBag.Message = "Oops! Diamond Sub Quality row not found.";
                return RedirectToAction("Diamonds", "Diamond");
            }
        }

        // UI Diamonds List Show Action
        public async Task<IActionResult> diamondlist(int pageNumber = 1)
        {
            int pageSize = 5; 
            var diamonds = await _context.DimMst.ToListAsync();
            var paginatedList = await PaginatedList<DiamondsModel>.CreateAsync(diamonds, pageNumber, pageSize);
            return View(paginatedList);
        }
    }
}
