using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitchener.Controllers
{

    public class HomeController : Controller
    {

        // Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Enter a New Recipe.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = "New Recipe Added!";
            return View();
        }

        public ActionResult FullInv(string secret, string format)
        {
            if (secret != "full")
                return new HttpStatusCodeResult(403);
            if (format == "text")
                return Content("Full INventory");
            else if (format == "json")
                return Json(new { password = "Inventory", expires = DateTime.UtcNow.ToShortDateString() },
                    JsonRequestBehavior.AllowGet);
            else if (format == "clean")
                return PartialView();
            return View();
        }
    }
}