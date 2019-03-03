using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitchener.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddSku()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddSku(string skuName, string skuStore, string skuUnitSize)
        {
            // handle DB posting
            return View();
        }

        [HttpGet]
        public ActionResult Stock()
        {
            // call DB for existing SKUs
            return View();
        }

        [HttpPost]
        public ActionResult Stock(string placeholder)
        {
            // post new stock to DB
            return View();
        }

        [HttpGet]
        public ActionResult FullInv()
        {
            // get full inv from DB
            return View();
        }
    }
}