using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ornekMVC2021.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "musteri,yonetici")]
        public ActionResult About()
        {
            ViewBag.Message = "Hakkında";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişim";

            return View();
        }
    }
}