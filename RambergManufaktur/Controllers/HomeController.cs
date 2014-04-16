using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RambergManufaktur.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ramberg Manufaktur er eneste forhandler av klær og gardiner vest for Nappstraumen.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ta gjerne kontakt dersom det er noe du lurer på.";

            return View();
        }
    }
}