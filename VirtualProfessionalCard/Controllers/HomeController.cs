using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualCard.Models;

namespace VirtualCard.Controllers
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

        public ActionResult SignUp()
        {
            ViewBag.Message = "Customer Sign Up";

            return View();
        }

        [HttpPost] // is this like overloading a method? clearly an API call though?
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(CustomerModel model)
        {
            if (ModelState.IsValid) // extra security? extra-validation that all the critera we added to our model class is authentic
            {

                return RedirectToAction("Index");

            }

            return View(); 
        }

    }
}