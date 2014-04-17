using System.Web.Mvc;

namespace RambergManufaktur.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OmRambergManufaktur()
        {
            ViewBag.Message = "Ramberg Manufaktur er eneste forhandler av klær og gardiner vest for Nappstraumen.";

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Ta gjerne kontakt dersom det er noe du lurer på.";

            return View();
        }

        public ActionResult Gardiner()
        {
            ViewBag.Message = "Vi selger gardiner.";

            return View();
        }

        public ActionResult Dame()
        {
            ViewBag.Message = "Dameklær";

            return View();
        }
    }
}