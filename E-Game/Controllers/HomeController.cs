using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Game.Controllers
{
    public class HomeController : Controller
    {
        //Anasayfa
        public ActionResult Index()
        {
            return View();
        }

        //Hakkımızda
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Katagoriler
        [HttpPost]
        public ActionResult Categories()
        {
            ViewBag.Message = "Your categories page.";

            return View();
        }

        //İletişim
        public ActionResult Contact()
        {

            return View();
        }
        
    }
}