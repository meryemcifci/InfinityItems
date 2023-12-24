using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Game.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult gameConsole()
        {
            return View();
        }
        public ActionResult gamingComputers()
        {
            return View();
        }
        public ActionResult gamingHeadsets()
        {
            return View();
        }
        public ActionResult gamingTables()
        {
            return View();
        }
        public ActionResult gamingAccessories()
        {
            return View();
        }

    }
}