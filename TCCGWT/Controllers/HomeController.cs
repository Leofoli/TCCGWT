using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCCGWT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult IndexLogadoCli()
        {
            return View();
        }

        public ActionResult IndexLogadoMan()
        {
            return View();
        }

        public ActionResult Comandas()
        {
            return View();
        }

        public ActionResult IndexLogadoFunc()
        {
            return View();
        }
    }
}