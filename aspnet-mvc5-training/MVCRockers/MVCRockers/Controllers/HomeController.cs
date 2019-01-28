using MVCRockers.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers.Controllers
{
    public class HomeController : Controller
    {
        // Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [MyLoggingFilter]
        // Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "What do you think?";

            return View();
        }

        // Add an Action Selector method for saving data or information from Contact form.
        [HttpPost]
        public ActionResult Contact(string message)
        {
            // Save this information from form and act on it.
            ViewBag.Message = "Thanks for the feedback.";

            return PartialView("_ThanksForFeedback");
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        // Add a new action method for Backstage.
        public ActionResult Backstage(string secret, string format)
        {
            if (secret != "special")
            {
                return new HttpStatusCodeResult(403); // forbidden View.
            }

            if (format == "text")
            {
                return Content("You Rock!");
            }
            else if (format == "json")
            {
                return Json(new { password = "You Rock!", expiry = DateTime.UtcNow.ToShortDateString() }, JsonRequestBehavior.AllowGet);
            }
            else if (format == "clean")
            {
                return PartialView();
            }

            return View();
        }
    }
}